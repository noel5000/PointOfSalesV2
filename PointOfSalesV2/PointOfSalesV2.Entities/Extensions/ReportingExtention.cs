using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NPOI.SS.Formula.Functions;
using PointOfSalesV2.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using static PointOfSalesV2.Common.ExcelImport;

namespace PointOfSalesV2.Entities
{






    public class ExportAttribute : Attribute
    {

      public  int Order { get; set; } = 0;
        public string ChildProperty { get; set; } = "";
        public ExportAttribute() { }

        public ExportAttribute(int Order)
        {
            this.Order = Order;
        }
        public ExportAttribute(int Order,string ChildPropertyName)
        {
            this.Order = Order;
            this.ChildProperty = ChildPropertyName;
        }
    }

    public class ExportUtility
    {
        /// <summary>
        /// Get the data to insert in ExcelImport from T where T has N properties with the ExportAttribute
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns>Tuple with headers(properties names) and list of values</returns>
        public static Tuple<string[],List<List<EntityPropValue>>> GetExcelData<T>(IEnumerable<T> data,string languageId="ES", List<LanguageKey> languageKeys=null) where T : class, new()
        {
            List<List<EntityPropValue>> result = new List<List<EntityPropValue>>();
            
            for (int i = 0; i < data.Count(); i++) 
            {
                T obj = data.ElementAt(i);
                var toExportProperties = obj.GetType().GetProperties().Where(t => t.GetCustomAttributes(typeof(ExportAttribute), true).Length > 0).OrderBy(x=>x.GetCustomAttributes<ExportAttribute>().FirstOrDefault().Order).ToList();

                var ojbProps = new List<EntityPropValue>();
                foreach (var prop in toExportProperties)
                {
                    string propType = prop.PropertyType.Name;
                    string propName = prop.Name;
                    string value = "";
                    if (string.IsNullOrEmpty(prop.GetCustomAttribute<ExportAttribute>().ChildProperty))
                    {
                        value = prop.GetValue(obj) != null ? prop.GetValue(obj).ToString() : "";
                    }
                    else
                    {
                        string childPropName = prop.GetCustomAttribute<ExportAttribute>().ChildProperty;
                        if (prop.GetValue(obj) != null) 
                        {
                            var childObject = prop.GetValue(obj);
                        var childProp=    childObject.GetType().GetProperty(childPropName);
                            if (childProp != null)
                                value = childProp.GetValue(childObject).ToString();
                        }
                    } 
                    KeyValuePair<string, Enums.ExcelColumnsDef> columnDef = Enums.PropertyTypesToExcelEnum.FirstOrDefault(x => x.Key.ToLower() == propType.ToLower());
                   
                    var temp = new EntityPropValue(propName, columnDef.Value, value);
                    ojbProps.Add(temp);
                }
                
                result.Add(ojbProps);
            }

            
            string[] headers = new T().GetType().GetProperties()
                .Where(t => t.GetCustomAttributes(typeof(ExportAttribute), true).Length > 0)
                .OrderBy(x => x.GetCustomAttributes<ExportAttribute>().FirstOrDefault().Order).Select(x => x.Name).ToArray();
            string[] translations = new string[headers.Length];
            if (languageKeys != null && languageKeys.Count > 0) 
            {
                for (int i = 0; i < headers.Length; i++) 
                {
                    string keyVal = languageKeys.FirstOrDefault(k => k.LanguageCode.ToLower() == languageId.ToLower() && k.Key.ToLower() == $"{headers[i].ToLower()}_lbl")?.Value;
                    translations[i] = !string.IsNullOrEmpty(keyVal) ? keyVal : headers[i];
                }
            }
            return new Tuple<string[], List<List<EntityPropValue>>>(translations,
                result
                );
        }
    }

 
}
