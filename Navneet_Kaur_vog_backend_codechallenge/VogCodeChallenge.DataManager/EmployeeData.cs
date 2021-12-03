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
           EmployeeId=1,FirstName="Navneet",LastName="Kaur",JobTitle="Software Developer",Address="Punjab"
           });
            lstEmp.Add(new Employee()
            {
                EmployeeId = 2,
                FirstName = "Emmu",
                LastName = "Su",
                JobTitle = "Sr.Software Developer",
                Address = "USA"
            });
            lstEmp.Add(new Employee()
            {
                EmployeeId = 2,
                FirstName = "Johan",
                LastName = "Tiwari",
                JobTitle = "Lead",
                Address = "Canada"
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
                Address = "Punjab"
            });
            lstEmp.Add(new Employee()
            {
                EmployeeId = 2,
                FirstName = "Emmu",
                LastName = "Su",
                JobTitle = "Sr.Software Developer",
                Address = "USA"
            });
            lstEmp.Add(new Employee()
            {
                EmployeeId = 2,
                FirstName = "Johan",
                LastName = "Tiwari",
                JobTitle = "Lead",
                Address = "Canada"
            });
            for (int i = 0; i < 3; i++)
            {
                yield return lstEmp[i];
            } 
        }





    } 
}
