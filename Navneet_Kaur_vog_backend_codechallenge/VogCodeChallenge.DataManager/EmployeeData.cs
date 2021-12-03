using System;
using System.Collections.Generic;
using System.Text;
using VogCodeChallenge.Entities.Models;

namespace VogCodeChallenge.DataManager
{
     public class EmployeeData
    {
        public static List<Employee> GetSampleData()
        {
            List<Employee> lstEmp = new List<Employee>();
           lstEmp.Add(new Employee() {
           EmployeeId=1,FirstName="Navneet",LastName="Kaur",JobTitle="Software Developer",Address="Punjab",
               deptId=1
           });
            lstEmp.Add(new Employee()
            {
                EmployeeId = 2,
                FirstName = "Emmu",
                LastName = "Su",
                JobTitle = "Sr.Software Developer",
                Address = "USA",
                deptId=1

            });
            lstEmp.Add(new Employee()
            {
                EmployeeId = 2,
                FirstName = "Johan",
                LastName = "Tiwari",
                JobTitle = "Lead",
                Address = "Canada",
                deptId=2
            });
            lstEmp.Add(new Employee()
            {
                EmployeeId = 1,
                FirstName = "Navneet",
                LastName = "Kaur",
                JobTitle = "Software Developer",
                Address = "Punjab",
                deptId = 3
            });
            return lstEmp;
        }

        public static IEnumerable<Employee> GetSampleEnumerableData()
        {
            List<Employee> lstEmp = new List<Employee>();
            lstEmp.Add(new Employee()
            {
                EmployeeId = 1,
                FirstName = "Navneet",
                LastName = "Kaur",
                JobTitle = "Software Developer",
                Address = "Punjab",
                deptId = 1
            });
            lstEmp.Add(new Employee()
            {
                EmployeeId = 2,
                FirstName = "Emmu",
                LastName = "Su",
                JobTitle = "Sr.Software Developer",
                Address = "USA",
                deptId = 1

            });
            lstEmp.Add(new Employee()
            {
                EmployeeId = 2,
                FirstName = "Johan",
                LastName = "Tiwari",
                JobTitle = "Lead",
                Address = "Canada",
                deptId = 2
            });
            lstEmp.Add(new Employee()
            {
                EmployeeId = 1,
                FirstName = "Navneet",
                LastName = "Kaur",
                JobTitle = "Software Developer",
                Address = "Punjab",
                deptId = 3
            });
            for (int i = 0; i < 3; i++)
            {
                yield return lstEmp[i];
            } 
        }

     

    } 
}
