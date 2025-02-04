
using App_Domain_Core.ToDoList.Tasks.Entities;
using App_Domain_Core.ToDoList.Users.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace App_infra_Data_SQLServer_EF
{
    public class AppDBContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-03R7JG5\\SQLEXPRESS;Database=ToDoList;Integrated Security=true;TrustServerCertificate=True");
        //    base.OnConfiguring(optionsBuilder);
        //}
        public DbSet<App_Domain_Core.ToDoList.Tasks.Entities.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
