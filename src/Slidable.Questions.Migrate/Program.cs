﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RendleLabs.EntityFrameworkCore.MigrateHelper;
using Slidable.Questions.Data;

namespace Slidable.Questions.Migrate
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var loggerFactory = new LoggerFactory().AddConsole((_, level) => true);
            await new MigrationHelper(loggerFactory).TryMigrate(args);
        }
    }
}
