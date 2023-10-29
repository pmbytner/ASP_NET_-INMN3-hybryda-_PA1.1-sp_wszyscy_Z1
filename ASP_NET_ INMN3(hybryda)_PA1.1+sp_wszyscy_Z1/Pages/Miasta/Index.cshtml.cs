using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_NET__INMN3_hybryda__PA1._1_sp_wszyscy_Z1.Data;
using ASP_NET__INMN3_hybryda__PA1._1_sp_wszyscy_Z1.Models;

namespace ASP_NET__INMN3_hybryda__PA1._1_sp_wszyscy_Z1.Pages.Miasta
{
    public class IndexModel : PageModel
    {
        private readonly PA1_1_sp_wszyscy_Z1Context _context;

        public IndexModel(PA1_1_sp_wszyscy_Z1Context context)
        {
            _context = context;
        }

        public IList<Miasto> Miasta { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Miasta != null)
            {
                Miasta = await _context.Miasta.ToListAsync();
            }
        }
    }
}
