using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DisplayName("Mission Name")]
        public string missionName { get; set; }
        [DisplayName("Mission President Name")]
        public string missionPresName { get; set; }
        [DisplayName("Mission Address")]
        public string missionAddress { get; set; }
        [DisplayName("Mission Language")]
        public string language { get; set; }
        [DisplayName("Mission Climate")]
        public string climate { get; set; }
        [DisplayName("Dominant Religion")]
        public string domReligion { get; set; }

    
    }
}