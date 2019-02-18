using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace myEcomerce.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Product> Products {get; set;}

        public DbSet<PersonalInfo> PersonalInfos {get; set;}

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Order_detail> Order_details { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).Created_at = DateTime.UtcNow;
                }

                ((BaseEntity)entity.Entity).Updated_at = DateTime.UtcNow;
            }
        }
    }

    public class Product: BaseEntity {

        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public int stock { get; set; }
        public string features { get; set; }
        public string rate_val { get; set; }
        public string tags { get; set; }
        public string brand { get; set; }
        public int rate_count { get; set; }
        public int? status { get; set; }
        public int view_counts { get; set; }
        public int sale_counts { get; set; }
        public string condition { get; set; }
        public string images { get; set; }

        public int[] image_array() {
            return images.Split(",").Select(n=>int.Parse(n)).ToArray();
        }


        public Feature ParseFeature() {
            return JsonConvert.DeserializeObject<Feature>(features);
        }
    }

    public class Feature {
        public string color;
        public string dimensions;
        public string weight;
    }

    public class BaseEntity
    {
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}
