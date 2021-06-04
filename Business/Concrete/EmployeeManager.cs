using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDAL _employeeDAL;
        public EmployeeManager(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }
        public List<Employee> GetAll()
        {
            return _employeeDAL.GetAll();
        }

        public Employee GetEmployeeById(int empId)
        {
            return _employeeDAL.Get(e=>e.EmployeeID == empId);
        }
    }
}
