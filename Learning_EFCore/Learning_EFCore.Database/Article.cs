﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Learning_EFCore.Database
{
    /// <summary>
    /// 文章
    /// </summary>
    public partial class Article
    {
        public int Id { get; set; }
        public string CategoryId { get; set; }
        public string Title { get; set; }
        public string[] Tags { get; set; }
        public string AuthorName { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ModifyTime { get; set; }
        public bool Published { get; set; }
        public string ContentType { get; set; }
        public string Content { get; set; }
        public string Summary { get; set; }
        public string CoverUrl { get; set; }
        public Guid? OldId { get; set; }
    }
}