
namespace Conceptionary.Backend.Models
{
    using Domain.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class LocalDataContext : DataCotext
    {
        public System.Data.Entity.DbSet<Conceptionary.Common.Models.Vehicle> Vehicles { get; set; }
    }
}