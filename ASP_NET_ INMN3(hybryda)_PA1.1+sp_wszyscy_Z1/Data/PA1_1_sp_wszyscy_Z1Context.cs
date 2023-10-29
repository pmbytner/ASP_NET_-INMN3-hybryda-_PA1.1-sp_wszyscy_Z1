using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_NET__INMN3_hybryda__PA1._1_sp_wszyscy_Z1.Models;

namespace ASP_NET__INMN3_hybryda__PA1._1_sp_wszyscy_Z1.Data
{
    public class PA1_1_sp_wszyscy_Z1Context : DbContext
    {
        public PA1_1_sp_wszyscy_Z1Context (DbContextOptions<PA1_1_sp_wszyscy_Z1Context> options)
            : base(options)
        {
        }

        public DbSet<Miasto> Miasta { get; set; } = default!;
    }
}
