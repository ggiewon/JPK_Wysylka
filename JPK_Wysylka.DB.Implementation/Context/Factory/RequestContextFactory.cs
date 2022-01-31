using System;
using Microsoft.EntityFrameworkCore;
using UnitSoftware.Common.Interfaces.Wrappers.IO;

namespace JPK_Wysylka.DB.Implementation.Context.Factory
{
    public class RequestContextFactory : IRequestContextFactory
    {
        private readonly IPathWrapper _pathWrapper;
        private readonly IDirectoryWrapper _directoryWrapper;

        public RequestContextFactory(IPathWrapper pathWrapper, IDirectoryWrapper directoryWrapper)
        {
            if (pathWrapper == null) throw new ArgumentNullException("pathWrapper");
            if (directoryWrapper == null) throw new ArgumentNullException("directoryWrapper");

            _pathWrapper = pathWrapper;
            _directoryWrapper = directoryWrapper;
        }

        public RequestContext Create(string appDataFolder)
        {
            var path = _pathWrapper.Combine(appDataFolder, @"JPK_WysylkaXML.db");

            //var connectionString = string.Format("Data Source={0}", path);

            var options = new DbContextOptionsBuilder();

            options.UseSqlite($"Data Source={path}");


            var context = new RequestContext(options.Options);

            context.Database.EnsureCreated();

            return context;
        }
    }
}