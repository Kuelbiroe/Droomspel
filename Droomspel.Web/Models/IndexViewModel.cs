using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Droomspel.Web.Models
{
    public class IndexViewModel
    {
        public string UserName { get; set; }

        public string GetUserName ()
        {
            return UserName;
        }
    }
}