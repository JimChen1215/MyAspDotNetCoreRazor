using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetRazorDemo.Data;
using AspNetRazorDemo.Models;
using AspNetRazorDemo.InputModels;

namespace AspNetRazorDemo.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly AspNetRazorDemo.Data.SchoolContext _context;

        public IndexModel(AspNetRazorDemo.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<CourseViewModel> CourseVM { get; set; }

        public async Task OnGetAsync()
        {
            CourseVM = await _context.Courses
                    .Select(p => new CourseViewModel
                    {
                        CourseID = p.CourseID,
                        Title = p.Title,
                        Credits = p.Credits,
                        DepartmentName = p.Department.Name
                    }).ToListAsync();
        }

        //public IList<Course> Course { get;set; }

        //public async Task OnGetAsync()
        //{
        //    Course = await _context.Courses
        //        .Include(c => c.Department).AsNoTracking().ToListAsync();
        //}
    }
}
