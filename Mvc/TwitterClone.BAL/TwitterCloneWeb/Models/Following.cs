using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwitterCloneWeb.Models
{
    public class Following
    {
        public int Following_id { get; set; }

        public int user_id { get; set; }

        public string user_name { get; set; }

        public string Following_name { get; set; }
    }
}