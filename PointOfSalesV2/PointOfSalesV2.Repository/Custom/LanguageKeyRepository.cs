using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using static PointOfSalesV2.Common.Enums;
using Microsoft.EntityFrameworkCore;

namespace PointOfSalesV2.Repository
{
    public class LanguageKeyRepository : Repository<LanguageKey>, ILanguageKeyRepository
    {
        public LanguageKeyRepository(MainDataContext context) : base(context)
        {
        }

        public Result<object> UploadI18nDictionaries(string path, ServerDirectoryType serverDirectoryType = ServerDirectoryType.Folder)
        {
            Result<object> result = new Result<object>(-1, -1, "error_msg");
            try
            {
                bool exist = Directory.Exists(path + "/i18n/");

                if (!exist)
                {
                    Directory.CreateDirectory(path + "/i18n/");
                }

                Dictionary<string, Dictionary<string, string>> dictionaries = new Dictionary<string, Dictionary<string, string>>();
                var languages = _Context.Languages.ToList();
                foreach (var language in languages)
                {
                    var keys = _Context.LanguageKeys.AsNoTracking().Where(k => k.Active == true && k.LanguageCode.ToLower() == language.Code.ToLower()).ToList();
                    Dictionary<string, string> currentLanguageDict = new Dictionary<string, string>();
                    keys.ForEach(k =>
                    {
                        currentLanguageDict.Add(k.Key, k.Value);
                    });

                    dictionaries.Add(language.Code.ToUpper(), currentLanguageDict);

                }

                switch (serverDirectoryType) 
                {
                    case ServerDirectoryType.FTP:
                        throw new NotImplementedException();
                        break;
                    default:
                    result=    this.WriteDictionaryInFolder(path, dictionaries);
                        break;
                }

            }
            catch (Exception ex)
            {
                result = new Result<object>(-1, -1, "error_msg", null, ex);
                
            }
            return result;
        }

        Result<object> WriteDictionaryInFolder(string path, Dictionary<string, Dictionary<string, string>> dictionaries) 
        {
            try
            {
                foreach (var dictionary in dictionaries)
                {
                    string fileName = $"{dictionary.Key}.json";
                    string content = JsonConvert.SerializeObject(dictionary.Value);
                    var transPath = System.IO.Path.Combine(path + "/i18n/" + dictionary.Key.ToUpper() + ".json");
                    if (File.Exists(transPath))
                        File.Delete(transPath);

                    File.WriteAllText(transPath, content);
                }

                return new Result<object>(0, 0, "ok_msg");
            }

            catch (Exception ex) 
            {
                return new Result<object>(-1, -1, "error_msg", null, ex);
            }
        }
    }
}
