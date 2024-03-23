﻿using Microsoft.EntityFrameworkCore;
using Route.C41.G02.BLL.Interfaces;
using Route.C41.G02.DAL.Data;
using Route.C41.G02.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.C41.G02.BLL.Repositories
{
    internal class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public DepartmentRepository(ApplicationDbContext dbContext) // Ask CLR for Createing Object from "ApplicationDbContext"
        {
            _dbContext = dbContext;
            /*new ApplicationDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDbContext>());*/

        }
        public int Add(Department entity)
        {
           _dbContext.Departments.Add(entity);
            return _dbContext.SaveChanges();
        }

        public int Delete(Department entity)
        {
            _dbContext.Departments.Update(entity);
            return _dbContext.SaveChanges();

        }

        public Department Get(int id)
        {
            //var department = _dbContext.Departments.Local.Where(x => x.Id == id).FirstOrDefault();
            //if (department == null)
            //{
            //     department = _dbContext.Departments.Where(x => x.Id == id).FirstOrDefault();

            //}
            //return department;


            //return _dbContext.Departments.Find(id);


            return _dbContext.Find<Department>(id);// EF 3.1
        }

        public IEnumerable<Department> GetAll()
        {
            return _dbContext.Departments.AsNoTracking().ToList();
        }

        public int Update(Department entity)
        {
            _dbContext.Departments.Update(entity);
            return _dbContext.SaveChanges();

        }
    }
}
