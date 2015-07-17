namespace ASP_NET_MVC_HOMEWORK.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.SqlClient;

    [MetadataType(typeof(客戶聯絡人MetaData))]
    public partial class 客戶聯絡人 : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //var results = new List<ValidationResult>();

            //if (this.姓名.Length > 2)
            //    yield return new ValidationResult("The last name has too many words!", new[] { "姓名" });

            using (var db = new CustomEntities())
            {
                
                
                //var custcontact = db.客戶聯絡人.SqlQuery("select Id from 客戶聯絡人 where 客戶Id = @客戶Id and Email = @Email",
                //    new SqlParameter("@客戶Id",this.客戶Id),    
                //    new SqlParameter("@Email",this.Email)).;
                //if(custcontact != null && custcontact.Result.Count > 0)
                    yield return new ValidationResult("該客戶Id的Email重複!", new[] { "Email" });

            }

            
        }
    }

    public partial class 客戶聯絡人MetaData
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int 客戶Id { get; set; }

        [StringLength(50, ErrorMessage = "欄位長度不得大於 50 個字元")]
        [Required]
        public string 職稱 { get; set; }

        [StringLength(50, ErrorMessage = "欄位長度不得大於 50 個字元")]
        [Required]
        public string 姓名 { get; set; }

        [StringLength(250, ErrorMessage = "欄位長度不得大於 250 個字元")]
        [Required]
        public string Email { get; set; }

        [StringLength(50, ErrorMessage = "欄位長度不得大於 50 個字元")]
        public string 手機 { get; set; }

        [StringLength(50, ErrorMessage = "欄位長度不得大於 50 個字元")]
        public string 電話 { get; set; }
        [Required]
        public bool fbDELETE { get; set; }

        public virtual 客戶資料 客戶資料 { get; set; }

    }
}
