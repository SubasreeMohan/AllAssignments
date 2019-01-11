using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwitterCloneWeb.Models
{
    public class TwitterCloneModel
    {

        public TwitterCloneModel()
        {
            this.User = new Person();
            this.User_Tweet = new Tweet();
            this.User_Followers = new List<Following>();
            this.User_Following = new List<Following>();
            this.User_Tweets = new List<Tweet>();

        }

        public Person User { get; set; }

        public Tweet User_Tweet { get; set; }

        public List<Following> User_Following { get; set; }

        public List<Following> User_Followers { get; set; }

        public List<Tweet> User_Tweets { get; set; }
    }
}