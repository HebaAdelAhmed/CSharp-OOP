using Demo.BLL.Interfaces;
using Demo.DAL.Entities;
using Demo.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    internal class DepartmentRepository : IDepartmentRepositoty
    {
        private readonly CompanyDbContext _CompanyDbContext;
        public DepartmentRepository(CompanyDbContext CompanyDbContext)
        {
            _CompanyDbContext = CompanyDbContext;

        }
        public int Add(Department department)
        {
            _CompanyDbContext.Departments.Add(department);
            return _CompanyDbContext.SaveChanges();
        }

        public int Delete(Department department)
        {
            _CompanyDbContext.Departments.Remove(department);
            return _CompanyDbContext.SaveChanges();
        }

        public IEnumerable<Department> GetAll()
        {
            return _CompanyDbContext.Departments.ToList();
        }

        public Department GetById(int id)
        {
            return _CompanyDbContext.Departments.Where(D => D.Id == id).FirstOrDefault();
        }

        public int Update(Department department)
        {
            _CompanyDbContext.Departments.Update(department);
            return _CompanyDbContext.SaveChanges();
        }
    }
}
