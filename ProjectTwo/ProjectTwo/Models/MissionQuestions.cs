using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ProjectTwo.Models
{
      [Table("MissionQuestions")]
     
      public class MissionQuestions
      {
         [Key]
         public int missionQuestionID { get; set; }

        [DisplayName("Question")]
         public string question { get; set; }
        [DisplayName("Answer")]
         public string answer { get; set; }

         public virtual int? missionID {get;set;}
         public virtual int? userID { get; set; }
      }
}