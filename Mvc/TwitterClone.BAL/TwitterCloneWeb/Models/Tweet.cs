using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwitterCloneWeb.Models
{
    public class Tweet
    {
        public int tweet_id { get; set; }
        public int user_id { get; set; }

        public string Message { get; set; }

        public DateTime Created { get; set; }
    }
}