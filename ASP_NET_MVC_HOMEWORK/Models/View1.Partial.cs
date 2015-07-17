namespace ASP_NET_MVC_HOMEWORK.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(View1MetaData))]
    public partial class View1
    {
    }
    
    public partial class View1MetaData
    {
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 客戶名稱 { get; set; }
        [Required]
        public int 銀行帳戶數量 { get; set; }
        [Required]
        public int 聯絡人數量 { get; set; }
    }
}
