using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AspNetRazorDemo.Data;
using AspNetRazorDemo.Models;
using AspNetRazorDemo.InputModels;

namespace AspNetRazorDemo.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly AspNetRazorDemo.Data.SchoolContext _context;

        public CreateModel(AspNetRazorDemo.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public StudentVM StudentVM { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Copy the fields based on identical names
            var entry = _context.Add(new Student());
            entry.CurrentValues.SetValues(StudentVM);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }

        /********
        [BindProperty]
        public Student Student { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            //auto generated code 
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            //_context.Students.Add(Student);
            //await _context.SaveChangesAsync();
            //return RedirectToPage("./Index");
            var emptyStudent = new Student();
            //this method can prevent overpost attack
            if (await TryUpdateModelAsync<Student>(
                emptyStudent,
                "student",   // Prefix for form value.
                s => s.FirstMidName, s => s.LastName, s => s.EnrollmentDate))
            {
                _context.Students.Add(emptyStudent);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            return Page();
        }
        *****/
    }
}
