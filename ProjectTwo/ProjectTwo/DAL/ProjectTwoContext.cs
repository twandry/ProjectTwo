using ProjectTwo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectTwo.DAL
{
    public class ProjectTwoContext : DbContext
    {
        public ProjectTwoContext() : base("ProjectTwoContext")
        {

        }
        public DbSet<Users>Users { get; set; }
        public DbSet<Missions>Missions { get; set; }
        public DbSet<MissionQuestions> MissionQuestions { get; set; }
    }
}