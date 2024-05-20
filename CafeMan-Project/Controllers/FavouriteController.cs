﻿using CafeMan_Project.Models.Dal;
using CafeMan_Project.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CafeMan_Project.Controllers
{
    [Authorize(Policy = "Roles")]
    public class FavouriteController : Controller
    {
        private readonly CafemanDbContext ctx;
        private readonly UserManager<User> userManager;

        public FavouriteController(CafemanDbContext ctx,UserManager<User> userManager)
        {
            this.ctx = ctx;
            this.userManager = userManager;
        }

        [Route("Favourite/List")]
        public async Task<IActionResult> Favourite(string q)
        {
            ViewBag.Title = "علاقه مندی ها";
            var user = await userManager.FindByIdAsync(q);
            
            return View(user);
        }
    }
}
