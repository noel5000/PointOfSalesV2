
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PointOfSalesV2.Entities
{
    public class CommonData : ICommonData
    {
       

        private string _jsonData;
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Guid CreatedBy { get; set; }
        [MaxLength(100)]
        [JsonIgnore]
        public virtual string CreatedByName { get; set; }
        [JsonIgnore]
        public virtual Guid? ModifiedBy { get; set; }
        [MaxLength(100)]
        [JsonIgnore]
        public virtual string ModifiedByName { get; set; }
        [JsonIgnore]
        public virtual DateTime CreatedDate { get; set; }
        [JsonIgnore]
        public virtual DateTime? ModifiedDate { get; set; }

        [Key]
        public virtual long Id { get; set; }

        public virtual bool Active { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual string TranslationData 
        {
            get
            {
                if (!string.IsNullOrEmpty(_jsonData)) 
                {
                    TranslateUtility.Translate(this, _jsonData);
                }
                return this._jsonData;
            }
            set 
            {
                this._jsonData = value ;
                if (!string.IsNullOrEmpty(this._jsonData)) 
                {
                    TranslateUtility.Translate(this, _jsonData);
                }
            }
        }
    }
}
