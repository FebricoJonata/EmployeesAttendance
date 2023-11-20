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
    public class DetailsModel : PageModel
    {
        private readonly KawanLamaTest.Data.KawanLamaTestContext _context;

        public DetailsModel(KawanLamaTest.Data.KawanLamaTestContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                Employee = employee;
            }
            return Page();
        }
    }
}
