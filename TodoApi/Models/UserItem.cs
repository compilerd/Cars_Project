using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class UserItem
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }

        public string UserPassword { get; set; }

        public UserItem()
        {

        }
    }

}