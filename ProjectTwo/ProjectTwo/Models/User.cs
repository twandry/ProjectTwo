using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectTwo.Models
{
    public class User
    {
        [DisplayName("Name")]
        public string name { get; set; }
        [DisplayName("Email")]
        public string email { get; set; }
        [DisplayName("Subject")]
        public string subject { get; set; }
        [DataType(DataType.MultilineText)]
        [DisplayName("Message")]
        public string message { get; set; }

    }
}