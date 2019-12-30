﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PointOfSalesV2.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Entities
{




    public class TranslateUtility 
    {
        static IHttpContextAccessor httpContext = AppDomain.CurrentDomain.GetService<IHttpContextAccessor>();
        public static string GetRequestLanguage()
        {
            string requestLanguage = "";
            if (httpContext != null && httpContext.HttpContext != null && httpContext.HttpContext.Request != null && httpContext.HttpContext.Request.Headers != null)
                requestLanguage = httpContext.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "LanguageId").Value.ToString();

            return string.IsNullOrEmpty(requestLanguage) ? "EN" : requestLanguage;
        }

        public static int GetRequestUser()
        {
            string currentUserId = httpContext.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "UserId").Value.ToString();
            int userId = !string.IsNullOrEmpty(currentUserId) ? Convert.ToInt32(currentUserId) : 1;

            return userId;
        }

        public static bool IsValidJson(string strInput)
        {
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex) //some other exception
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static void Translate<T>( T obj,string translationData, string languageId = null) where T: class, new()
        {
            if (obj != null)
            {
                IHttpContextAccessor httpContextAccessor = AppDomain.CurrentDomain.GetService<IHttpContextAccessor>();
                string requestLanguage = "";
                if (httpContextAccessor != null && httpContextAccessor.HttpContext != null && httpContextAccessor.HttpContext.Request != null && httpContextAccessor.HttpContext.Request.Headers != null)
                {
                    requestLanguage = httpContextAccessor.HttpContext.Request.Headers.Any(x => x.Key == "LanguageId")
                        ? httpContextAccessor.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "LanguageId").Value.ToString().ToUpper()
                        : "EN";

                    if (!string.IsNullOrEmpty(translationData) && TranslateUtility.IsValidJson(translationData))
                    {
                        Dictionary<string, List<TranslateData>> dictionary = JsonConvert.DeserializeObject<Dictionary<string, List<TranslateData>>>(translationData) ?? new Dictionary<string, List<TranslateData>>();
                        var translateProperties = obj.GetType().GetProperties().Where(t => t.GetCustomAttributes(typeof(TranslateAttribute), true).Length > 0).ToList();
                        foreach (var prop in translateProperties)
                        {
                            var currentDictionary = dictionary.ContainsKey(requestLanguage.ToUpper()) ? dictionary.GetValueOrDefault(requestLanguage) : new List<TranslateData>();
                            string value = currentDictionary.FirstOrDefault(x => x.PropertyName.ToLower() == prop.Name.ToLower())?.Value ?? "";
                            prop.SetValue(obj, value);
                        }

                    }
                }
            }
        }

        public static string SaveTranslation<T>( T obj, string translationData) where T:class,new ()

        {

            IHttpContextAccessor httpContextAccessor = AppDomain.CurrentDomain.GetService<IHttpContextAccessor>();
            string requestLanguage = "";
            if (httpContextAccessor != null && httpContextAccessor.HttpContext != null && httpContextAccessor.HttpContext.Request != null && httpContextAccessor.HttpContext.Request.Headers != null)
            {
                requestLanguage = httpContextAccessor.HttpContext.Request.Headers.Any(x => x.Key == "LanguageId")
                           ? httpContextAccessor.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "LanguageId").Value.ToString().ToUpper()
                           : "EN";


                if (string.IsNullOrEmpty(translationData) || !TranslateUtility.IsValidJson(translationData))
                {
                    translationData = "";
                }
                Dictionary<string, List<TranslateData>> dictionary = JsonConvert.DeserializeObject<Dictionary<string, List<TranslateData>>>(translationData) ?? new Dictionary<string, List<TranslateData>>();

                var translateProperties = obj.GetType().GetProperties().Where(t => t.GetCustomAttributes(typeof(TranslateAttribute), true).Length > 0).ToList();
                foreach (var prop in translateProperties)
                {
                    var currentDictionary = dictionary.ContainsKey(requestLanguage.ToUpper()) ? dictionary.GetValueOrDefault(requestLanguage) : new List<TranslateData>();
                    bool existData = currentDictionary.Exists(x => x.PropertyName.ToLower() == prop.Name.ToLower());
                    var currentProp = existData ? currentDictionary.FirstOrDefault(x => x.PropertyName.ToLower() == prop.Name.ToLower()) : new TranslateData()
                    {
                        PropertyName = prop.Name,
                        Value = prop.GetValue(obj).ToString()
                    };
                    if (existData)
                    {
                        int index = currentDictionary.FindIndex(x => x.PropertyName.ToLower() == currentProp.PropertyName.ToLower());
                        if (index >= 0)
                            currentDictionary.RemoveAt(index);
                    }
                    currentDictionary.Add(currentProp);

                    if (dictionary.ContainsKey(requestLanguage.ToUpper()))
                    {
                        dictionary[requestLanguage.ToUpper()] = currentDictionary;
                    }
                    else
                        dictionary.Add(requestLanguage.ToUpper(), currentDictionary);

                }

                translationData = JsonConvert.SerializeObject(dictionary);
                return translationData;
            }
            return "";
        }
    }

    public class TranslateAttribute : NotMappedAttribute
    {
       

        public TranslateAttribute() { }

        public TranslateAttribute(string name)
        {
           
        }
    }

    public class TranslateData 
    {
    public string PropertyName { get; set; }
        public string Value { get; set; }
    }
}
