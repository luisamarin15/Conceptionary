﻿

namespace Conceptionary.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
     public class DataCotext : DbContext
    {
        public DataCotext() : base("DefaultConnection")
        {

        }
    }
}
