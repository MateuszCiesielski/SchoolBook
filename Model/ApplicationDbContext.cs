using Microsoft.AspNet.Identity.EntityFramework;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ActivityDates> ActivityDates { get; set; }
        public DbSet<ActivityTerms> ActivityTerms { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<CsvFile> CsvFile { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<MessageReceiver> MessageReceiver { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonGroup> PersonGroup { get; set; }
        public DbSet<UserPerson> UserPerson { get; set; }

        public ApplicationDbContext() : base("AppConnection", throwIfV1Schema: false) { }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
