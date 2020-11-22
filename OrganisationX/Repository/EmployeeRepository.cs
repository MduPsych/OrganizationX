using OrganisationX.Contracts;
using OrganisationX.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganisationX.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _db;
        public EmployeeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Employees entity)
        {
            _db.Employeee.Add(entity);
            return Save();
        }

        public bool Delete(Employees entity)
        {
            _db.Employeee.Remove(entity);
            return Save();
        }

        public ICollection<Employees> FindAll()
        {
            var employees = _db.Employeee.ToList();
            return employees;
        }

        public Employees FindById(string id)
        {
            var employees = _db.Employeee.Find(id);
            return employees;
        }

        public bool isExists(string id)
        {
            var exists = _db.Employeee.Any(q => q.Id.Equals(id));
            return exists;
        }

        public bool Save()
        {
           var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Employees entity)
        {
            _db.Employeee.Update(entity);
            return Save();
        }
    }
}
