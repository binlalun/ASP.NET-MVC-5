//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP_NET_MVC_HOMEWORK.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class 客戶資料
    {
        public 客戶資料()
        {
            this.客戶銀行資訊 = new HashSet<客戶銀行資訊>();
            this.客戶聯絡人 = new HashSet<客戶聯絡人>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "必填")]
        [MaxLength(50)]
        public string 客戶名稱 { get; set; }

        [Required(ErrorMessage = "必填")]
        [MaxLength(8, ErrorMessage = "統一編號須為8碼")]
        [MinLength(8, ErrorMessage = "統一編號須為8碼")]
        public string 統一編號 { get; set; }

        [Required(ErrorMessage = "必填")]
        [MaxLength(50)]
        public string 電話 { get; set; }

        [MaxLength(50)]
        public string 傳真 { get; set; }

        [MaxLength(100)]
        public string 地址 { get; set; }

        [MaxLength(250)]
        [Required(ErrorMessage = "必填")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Email格式錯誤")]
        public string Email { get; set; }


        public bool fbDELETE { get; set; }

        public virtual ICollection<客戶銀行資訊> 客戶銀行資訊 { get; set; }
        public virtual ICollection<客戶聯絡人> 客戶聯絡人 { get; set; }
    }
}
