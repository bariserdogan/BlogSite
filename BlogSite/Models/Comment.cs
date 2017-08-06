namespace BlogSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        [Key]
        public int Comment_id { get; set; }

        [Required]
        public string Comment_Icerik { get; set; }

        public int MemberID { get; set; }

        public int ArticleID { get; set; }

        public DateTime? Comment_Date { get; set; }

        public virtual Article Article { get; set; }

        public virtual Member Member { get; set; }
    }
}
