using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace TodoApi.Models
{
    public class UserOrder
    {
       
        public int id { get; set; }

       
        public int userid { get; set; }

        
        public int carid { get; set; }
         
    }
}
