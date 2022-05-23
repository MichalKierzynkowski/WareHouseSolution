using Infrastructure.Data;
using Infrastructure.SqlLiteConnectionSettings;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalityTests
{
    public class DependencySetupFixture
    {
        public ServiceProvider ServiceProvider { get; private set; }

        public DependencySetupFixture()
        {
            var services = new ServiceCollection();
            services.AddEntityFrameworkSqlite().AddDbContext<WareHouseDbContext>();
            services.AddScoped<ISqlLiteDataAccess, SqlLiteDataAccess>();
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}