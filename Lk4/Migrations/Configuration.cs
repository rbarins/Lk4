using Lk4.Models;
using System.Data.Entity.Migrations;

namespace Lk4.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AppLookHereContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AppLookHereContext context)
        {

        }
    }
}
