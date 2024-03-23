﻿using Microsoft.AspNetCore.Mvc;
using Route.C41.G02.BLL.Interfaces;
using Route.C41.G02.BLL.Repositories;
using Route.C41.G02.DAL.Models;

namespace Route.C41.G02.PL.Controllers
{
    // Inhertiance
    // Associattion Composttion or Agragation => maby null or object
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepo;

        //private readonly IDepartmentRepository _departmentRepo;

        public DepartmentController(IDepartmentRepository departmentRepo) // ask CLR for Createing 
        {
            _departmentRepo = departmentRepo;
        }


        public IActionResult Index()// Return master Paspe 
        {
            //var department-_departmentRepo.
            return View();
        }
    }
}