using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetrolStationDB.Database;
using PetrolStationDB.Database.Models;
using PetrolStationDB.Services;
using Microsoft.EntityFrameworkCore;

namespace PetrolStationDB.Controllers
{
    public class EmployeeController
    {
        public List<Employee> GetEmployees(string search = "", string field = "")
        {
            List<Employee> employees = null;

            using (_ContextDb db = new _ContextDb())
            {
                if(search == "")
                {
                    return employees = db.Employees.ToList();
                }
                else
                {
                    switch (field)
                    {
                        case "common":
                            employees = db.Employees
                                .Where(
                                    e => e.LastName.ToLower().Contains(search.ToLower())
                                    || e.FirstName.ToLower().Contains(search.ToLower())
                                    || e.MiddleName.ToLower().Contains(search.ToLower())
                                    || e.CreatedBy.ToLower().Contains(search.ToLower())
                                    || e.UpdatedBy.ToLower().Contains(search.ToLower())
                                    || e.CreatedDate.ToString().ToLower().Contains(search.ToLower())
                                    || e.UpdatedDate.ToString().ToLower().Contains(search.ToLower())
                                ).ToList();
                            break;

                        case "lastname":
                            employees = db.Employees
                                .Where(
                                    e => e.LastName.ToLower().Contains(search.ToLower())
                                ).ToList();
                            break;

                        case "firstname":
                            employees = db.Employees
                                .Where(
                                    e => e.FirstName.ToLower().Contains(search.ToLower())
                                ).ToList();
                            break;

                        case "middlename":
                            employees = db.Employees
                                .Where(
                                    e => e.MiddleName.ToLower().Contains(search.ToLower())
                                ).ToList();
                            break;

                        default:
                            employees = db.Employees.ToList();
                            break;
                    }
                }
            }

            return employees;
        }

        public bool SaveChangesSingleEmployee(
            Guid _guid,
            string _user,
            string _lastName = "",
            string _firstName = "",
            string _middleName = ""
        )
        {
            bool result = false;

            Employee employee = null;

            using(_ContextDb db = new _ContextDb())
            {
                employee = db.Employees.FirstOrDefault(e => e.Id == _guid);
                if(employee != null)
                {
                    employee.UpdatedBy = _user;
                    employee.UpdatedDate = DateTime.Now;

                    if(_lastName != "") { employee.LastName = _lastName; }
                    if(_firstName != "") { employee.FirstName = _firstName; }
                    if(_middleName != "") { employee.MiddleName = _middleName; }

                    db.Employees.Update(employee);
                    db.SaveChanges();
                    result = true;
                }
            }
            return result;
        }

        public bool DeleteSingleEmployee(Guid _guid)
        {
            bool deleted = false;

            Employee employee = null;

            using(_ContextDb db = new _ContextDb())
            {
                employee = db.Employees.FirstOrDefault(e => e.Id == _guid);

                if(employee != null)
                {
                    db.Employees.Remove(employee);
                    db.SaveChanges();
                    deleted = true;
                }
            }
            return deleted;
        }

        public bool AddSingleEmployee(string _user, Employee _employee)
        {
            bool added = false;
            Guid guid = Guid.NewGuid();
            _employee.Id = guid;
            _employee.CreatedBy = _user;
            _employee.UpdatedBy = _user;
            _employee.CreatedDate = DateTime.Now;
            _employee.UpdatedDate = DateTime.Now;

            using(_ContextDb db = new _ContextDb())
            {
                db.Employees.Add(_employee);
                db.SaveChanges();
            }

            using(_ContextDb db = new _ContextDb())
            {
                if(db.Employees.Any(e => e.Id == guid))
                {
                    added = true;
                }
            }
            return added;
        }

        public int GetMaxNumEmployees()
        {
            int num = 0;

            using (_ContextDb db = new _ContextDb())
            {
                if(db.Employees.ToList().Count > 0)
                {
                    num = db.Employees.Max(e => e.PersonnelNumber);
                }
            }

            return num;
        }

        public Employee GetSingleEmployeeById(Guid _guid)
        {
            Employee employee = null;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    employee = db.Employees.FirstOrDefault(e => e.Id == _guid);
                }
            }catch(Exception ex)
            {
                return null;
            }

            return employee;
        }
    }
}
