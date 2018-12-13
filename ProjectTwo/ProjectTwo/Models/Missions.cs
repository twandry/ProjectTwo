using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectTwo.Models
{
    [Table("Missions")]
    public class Missions
    {
        [Key]  
         public int missionID { get; set; }

        public string missionName { get; set; }
        public string missionPresName { get; set; }
        public string missionAddress { get; set; }
        public string language { get; set; }
        public string climate { get; set; }
        public string domReligon { get; set; }

    
    }
}