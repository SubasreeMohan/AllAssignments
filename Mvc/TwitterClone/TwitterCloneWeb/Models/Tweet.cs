using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TwitterCloneWeb.Models
{
    public class Tweet
    {
        [DisplayName("Tweet")]
        public int tweet_id { get; set; }
        public int user_id { get; set; }

        [DisplayName("Message")]
        public string Message { get; set; }

        [DisplayName("Created")]
        public DateTime Created { get; set; }
    }
}