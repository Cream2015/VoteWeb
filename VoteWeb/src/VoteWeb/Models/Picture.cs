using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoteWeb.Models
{
    public class Picture
    {
        /// <summary>
        /// 作者ID
        /// </summary>
        public long PictureID { get; set; }
        /// <summary>
        /// 作品名称
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 作品地址
        /// </summary>
        public string PictureURL { get; set; }
        /// <summary>
        /// 作者ID
        /// </summary>
        public long AuthorID { get; set; }
        /// <summary>
        /// 分类ID
        /// </summary>
        public long CategoryID { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 作品简介
        /// </summary>
        public string Introduction { get; set; }
        /// <summary>
        /// 作品简介
        /// </summary>
        public int Votes { get; set; }
        /// <summary>
        /// 是否展示
        /// </summary>
        public int IsDisplay { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public int IsDelete { get; set; }
    }
}
