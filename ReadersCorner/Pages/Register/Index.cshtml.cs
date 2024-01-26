using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ReadersCorner.Data;
using ReadersCorner.Models;

namespace ReadersCorner.Pages.Register
{
    public class IndexModel : PageModel
    {
        private readonly ReadersCorner.Data.ReadersCornerContext _context;

        public IndexModel(ReadersCorner.Data.ReadersCornerContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
