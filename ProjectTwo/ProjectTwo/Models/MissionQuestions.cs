using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTwo.Models
{
   public class MissionQuestions
   {
      Table["MissionQuestions"]
      public class MissionQuestions
      {
         [Key]
         public int missionQuestionID { get; set; }

         public string question { get; set; }
         public string answer { get; set; }

         public virtual int? missionID {get;set;}
         public virtual int? userID { get; set; }
      }
   }
}