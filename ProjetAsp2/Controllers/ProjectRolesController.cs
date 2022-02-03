using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetAsp2.Data;
using ProjetAsp2.Models;

namespace ProjetAsp2.Controllers
{
   [Authorize(Roles ="Admin")]
    public class ProjectRolesController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly RoleManager<IdentityRole> roleManager;

        public ProjectRolesController(ApplicationDbContext context, RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
            _context = context;
        }

        // GET: Roles
        public async Task<IActionResult> Index()
        {

            return View(await _context.ProjectRole.ToListAsync());
        }
       

        // GET: ProjectRoles/Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(ProjectRole role)
        {
            var roleExist = await roleManager.RoleExistsAsync(role.RoleName);
            if (!roleExist)
            {
                var result = await roleManager.CreateAsync(new IdentityRole(role.RoleName));

            }
            return View();
        }
    }
}

