using System;
using helpdesk_app.infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace helpdesk_app.infrastructure
{
    public static class StartupSetup
    {
        public static void AddDbContext(this IServiceCollection services, string connectionString) =>
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString)); // will be created in web project root
    }
}

