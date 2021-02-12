using Fyro.Data;
using Fyro.Data.Abstractions;
using FYRO.Data.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class SqlServerExtensions
    {
        public static FyroBuilder WithSqlServer(this FyroBuilder builder, string connectionString)
        {
            builder.Services.AddDbContext<FyroDbContext>(optionsBuilder =>
            {
                optionsBuilder.UseSqlServer(connectionString);
            });

            builder.Services.AddScoped<IFyroRepository, SqlServerFyroRepository>();

            builder.Services.AddAutoMapper(typeof(SqlServerExtensions).Assembly);
            return builder;
        }
    }
}
