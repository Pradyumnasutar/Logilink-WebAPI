using LES_USER_ADMINISTRATION_LIB.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_USER_ADMINISTRATION_LIB.DAL
{
    public class UserAdminDbContext : DbContext
    {
        public static IConfiguration configuration { get; set; }
        public UserAdminDbContext(DbContextOptions<UserAdminDbContext> options) : base(options)
        {

        }

        //public DbExecutionStrategy GetCustomExecutionStrategy()
        //{
        //    // You can adjust the retry settings as needed (e.g., number of retries and delay between retries)
        //    int maxRetryCount = 5;
        //    TimeSpan maxDelay = TimeSpan.FromSeconds(30);
        //    return new CustomExecutionStrategy(maxRetryCount, maxDelay);
        //}

        #region tables 
        public DbSet<LES_APPLICATIONS> les_applications { get; set; }
        public DbSet<LES_COMPANY> les_company { get; set; }
        public DbSet<LES_MODULE> les_module { get; set; }
        public DbSet<LES_USER_COMPANY_LINK> les_user_company_link { get; set; }
        public DbSet<LES_USERTYPE> les_usertype { get; set; }
        public DbSet<LES_COMPANY_DETAILS> les_company_details { get; set; }
        public DbSet<LES_USERTYPE_MODULE_ACCESS> les_usertype_module_access { get; set; }
        public DbSet<SM_EXTERNAL_USERS> sm_external_users { get; set; }

        #endregion

        #region Views
        public DbSet<V_APPLICATION_MODULE_ACCESS> v_application_module_access { get; set; }
        public DbSet<V_COMPANY_DETAILS> v_company_details { get; set; }
        public DbSet<V_USER_LIST> v_user_list { get; set; }
        public DbSet<V_USERLINKED_COMPANIES> v_userlinked_companies { get; set; }
        public DbSet<V_USERTYPE_MODULE_ACCESS>v_usertype_module_access { get; set; }
		#endregion

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//modelBuilder.Entity<VehicleFeature>().HasKey(vf => new { vf.VehicleId, vf.FeatureId }); // for composite unique key
		}

	}

    //public class CustomExecutionStrategy : DbExecutionStrategy
    //{
    //    public CustomExecutionStrategy(int maxRetryCount, TimeSpan maxDelay) : base(maxRetryCount, maxDelay)
    //    {

    //    }
    //    protected override bool ShouldRetryOn(Exception exception)
    //    {
    //        // Determine if the exception is a transient fault that should be retried
    //        // You can customize this logic based on the specific exceptions you want to handle
    //        return true;
    //    }
    //}
}
