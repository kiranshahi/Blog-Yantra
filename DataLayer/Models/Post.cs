using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string PostAuthor { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime PostDateGMT { get; set; }
        public string PostContent { get; set; }
        public string PostTitle { get; set; }
        public string PostSummary { get; set; }
        public string PostStatus { get; set; }
        public string CommentStatus { get; set; }
        public string PingStatus { get; set; }
        public string PostPassword { get; set; }
        public string PostName { get; set; }
        public string ToPing { get; set; }
        public string Pinged { get; set; }
        public DateTime PostModified { get; set; }
        public DateTime PostModifiedGMT { get; set; }
        public String PostContentFiltered { get; set; }
        public string PostParent { get; set; }
        public string Guid { get; set; }
        public int MenuOrder { get; set; }
        public string PostType { get; set; }
        public string PostMimeType { get; set; }
        public string CommentCount { get; set; }
    }
}
