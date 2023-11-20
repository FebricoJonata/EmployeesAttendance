using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KawanLamaTest.Data;
using KawanLamaTest.Model;

namespace KawanLamaTest.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly KawanLamaTest.Data.KawanLamaTestContext _context;

        public IndexModel(KawanLamaTest.Data.KawanLamaTestContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync();
        }
    }
}
