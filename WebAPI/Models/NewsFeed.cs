using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class NewsFeed
    {
        public int ID { get; set; }
        public string Topic { get; set; }
        public string News { get; set; }
        public string AddedDate { get; set; }
        public string Image_URL { get; set; }
    }
}