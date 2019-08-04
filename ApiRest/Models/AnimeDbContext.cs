using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace ApiRest.Models
{
    public class AnimeDbContext : DbContext
    {


        public AnimeDbContext() : base()
        {

        }


        public DbSet<Anime> Animes{get;set;}
        public DbSet<User> Users {get;set;}
        public DbSet<Comment> Comments{get;set;}
        public DbSet<Link> Links  {get;set;}
        public DbSet<SubComment> SubComments{get;set;}
        public DbSet<Post> Posts {get;set;}
      
    }
}