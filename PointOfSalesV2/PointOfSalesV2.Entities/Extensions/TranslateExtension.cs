using Microsoft.AspNetCore.Http;
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
        static IHttpContextAccessor httpContextAccessor = null;
        public static void SetHttpContext(IHttpContextAccessor newContext)
        {
            httpContextAccessor = newContext;
        }
        public static string GetRequestLanguage()
        {
            string requestLanguage = "EN";
            if (httpContextAccessor != null && httpContextAccessor.HttpContext != null && httpContextAccessor.HttpContext.Request != null && httpContextAccessor.HttpContext.Request.Headers != null)
                requestLanguage = httpContextAccessor.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "languageid").Value.ToString();

            return string.IsNullOrEmpty(requestLanguage) ? "EN" : requestLanguage;
        }

        public static int GetRequestUser()
        {
            string currentUserId = httpContextAccessor.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "UserId").Value.ToString();
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

        public static void Translate<T>(T obj, string translationData, string languageId = null) where T : class, new()
        {
            if (obj != null)
            {

                string requestLanguage = "";
                if (httpContextAccessor != null && httpContextAccessor.HttpContext != null && httpContextAccessor.HttpContext.Request != null && httpContextAccessor.HttpContext.Request.Headers != null)
                {
                    requestLanguage = httpContextAccessor.HttpContext.Request.Headers.Any(x => x.Key == "languageid")
                        ? httpContextAccessor.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "languageid").Value.ToString().ToUpper()
                        : "ES";
                }
                else
                    requestLanguage = "ES";

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

        public static string SaveTranslation<T>(T obj, string translationData, List<Language> languages = null) where T : class, new()

        {


            string requestLanguage = "";
            if (httpContextAccessor != null && httpContextAccessor.HttpContext != null && httpContextAccessor.HttpContext.Request != null && httpContextAccessor.HttpContext.Request.Headers != null)
            {
                requestLanguage = httpContextAccessor.HttpContext.Request.Headers.Any(x => x.Key == "languageid")
                           ? httpContextAccessor.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "languageid").Value.ToString().ToUpper()
                           : "ES";


                if (string.IsNullOrEmpty(translationData) || !TranslateUtility.IsValidJson(translationData))
                {
                    translationData = "";
                }
                Dictionary<string, List<TranslateData>> dictionary = JsonConvert.DeserializeObject<Dictionary<string, List<TranslateData>>>(translationData) ?? new Dictionary<string, List<TranslateData>>();
                if (dictionary.Count() == 0 && languages != null)
                {
                    languages.ForEach(l =>
                    {
                        dictionary.Add(l.Code.ToUpper(), new List<TranslateData>());
                    });
                }

                var translateProperties = obj.GetType().GetProperties().Where(t => t.GetCustomAttributes(typeof(TranslateAttribute), true).Length > 0).ToList();
                foreach (var prop in translateProperties)
                {
                    var currentDictionary = dictionary.ContainsKey(requestLanguage.ToUpper()) ? dictionary.GetValueOrDefault(requestLanguage) : new List<TranslateData>();
                    bool existData = currentDictionary.Exists(x => x.PropertyName.ToLower() == prop.Name.ToLower());
                    var currentProp = new TranslateData()
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

                    var otherLanguages = languages != null ? languages.Where(x => x.Code.ToUpper() != requestLanguage.ToUpper()).ToList() : new List<Language>();
                    otherLanguages.ForEach(ol =>
                    {
                        var currentLanguageDictionary = dictionary.ContainsKey(ol.Code.ToUpper()) ? dictionary.GetValueOrDefault(ol.Code.ToUpper()) : new List<TranslateData>();
                        if (currentLanguageDictionary.FindIndex(x => x.PropertyName.ToLower() == currentProp.PropertyName.ToLower()) < 0)
                        {
                            currentLanguageDictionary.Add(currentProp);
                            dictionary[ol.Code.ToUpper()] = currentLanguageDictionary;
                        }
                    });

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
