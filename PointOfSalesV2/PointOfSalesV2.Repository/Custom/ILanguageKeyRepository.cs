using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Repository
{
    public interface ILanguageKeyRepository : IBase<LanguageKey>
    {
        public Result<object> UploadI18nDictionaries(string path, ServerDirectoryType serverDirectoryType= ServerDirectoryType.Folder);
    }
}
