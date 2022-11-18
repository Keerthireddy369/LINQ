using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Linq_EntityFramework
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }



        public static void Main(String[] args)
        {

             List<Employee> empList = new List<Employee>()
        {

            new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager",DOB = new DateTime(1984, 11, 16),DOJ = new DateTime(2011, 06, 8, 0, 0, 0), City = "Mumbai" } ,
            new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "Asst.Manager", DOB = new DateTime(1984, 08, 20, 0, 0, 0), DOJ = new DateTime(2012, 07, 7, 0, 0, 0), City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14, 0, 0, 0), DOJ = new DateTime(2015, 04, 12, 0, 0, 0), City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 06, 3, 0, 0, 0), DOJ = new DateTime(2016, 02, 2, 0, 0, 0), City = "Pune" },
            new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 03,8, 0, 0, 0), DOJ = new DateTime(2016, 02, 2, 0, 0, 0), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7, 0, 0, 0), DOJ = new DateTime(2014, 08, 8, 0, 0, 0), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2, 0, 0, 0), DOJ = new DateTime(2015, 06, 1, 0, 0, 0), City = "Mumbai" },
            new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB =new DateTime(1993, 11, 11, 0, 0, 0), DOJ = new DateTime(2014, 11, 6, 0, 0, 0), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Misthry", Title = "Associate", DOB = new DateTime(1992, 12, 8, 0, 0, 0), DOJ = new DateTime(2014, 12, 3, 0, 0, 0), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 04, 12, 0, 0, 0),DOJ = new DateTime(2016, 01, 2, 0, 0, 0), City = "Pune" }





        };

            IEnumerable<Employee> EmpQuery =
                 from Employee in empList
                 
                 select Employee;
            Console.WriteLine("-------------------All Employee Details-------------------");
            foreach (Employee emp in EmpQuery)
            {
               

                Console.WriteLine("{0}, {1},{2},{3},{4},{5},{6}",emp.EmployeeID, emp.FirstName,emp.LastName,emp.Title,emp.DOB,emp.DOJ,emp.City);
            }
            Console.WriteLine();

            IEnumerable<Employee> EmpQuery1= from Employee in empList
                                             where Employee.City!= "Mumbai"
                                             select Employee;
            Console.WriteLine("---------------Employee Details Who Are Not In Mumbai---------------");
            foreach (Employee emp in EmpQuery1)
            {
                Console.WriteLine("{0}, {1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title, emp.DOB, emp.DOJ, emp.City);

            }
            Console.WriteLine();    

            IEnumerable<Employee> EmpQuery2= from Employee in empList
                                             where Employee.Title=="Asst.Manager"
                                             select Employee;
            Console.WriteLine("---------------Employees Whose Title is Asst Manager---------------------------------");
            foreach (Employee emp in EmpQuery2)
            {
                Console.WriteLine("{0}, {1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title, emp.DOB, emp.DOJ, emp.City);

            }
            Console.WriteLine();

            IEnumerable<Employee> EmpQuery3 = from Employee in empList
                                              where Employee.LastName.StartsWith("S")
                                              select Employee;
            Console.WriteLine("--------------Employee Whose Name Starts With 'S'----------------------------");
            foreach (Employee emp in EmpQuery3)
            {
                Console.WriteLine("{0}, {1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title, emp.DOB, emp.DOJ, emp.City);

            }
            Console.WriteLine();


            IEnumerable<Employee> EmpQuery4 = from Employee in empList
                                              where Employee.DOJ < new DateTime(2015, 01, 1,0,0,0)
                                              select Employee;
            Console.WriteLine("--------------------------Employees who had joined before 1/1/2015------------------------------------------");
            foreach (Employee emp in EmpQuery4)
            {
                Console.WriteLine("{0}, {1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title, emp.DOB, emp.DOJ, emp.City);

            }
            Console.WriteLine();

            IEnumerable<Employee> EmpQuery5= from Employee in empList
                                             where Employee.DOB > new DateTime(1990, 01, 1, 0, 0, 0)
                                             select Employee;
            Console.WriteLine("---------------------------Employees whose DOB after 1/1/1990----------------------------------");
            foreach (Employee emp in EmpQuery5)
            {
                Console.WriteLine("{0}, {1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title, emp.DOB, emp.DOJ, emp.City);

            }
            Console.WriteLine();

            IEnumerable<Employee> EmpQuery6= from Employee in empList
                                             where Employee.Title== "Consultant" || Employee.Title== "Associate"
                                             select Employee;
            Console.WriteLine("-------------------------------All Consultants and Associate-----------------------------------");
            foreach (Employee emp in EmpQuery6)
            {
                Console.WriteLine("{0}, {1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title, emp.DOB, emp.DOJ, emp.City);

            }
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Total Number of Employees : {0}", empList.Count);
            Console.WriteLine();

            int EmpQuery8= (from Employee in empList
                                            where Employee.City=="Chennai"
                                            select Employee).Count();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Total Number of Employess Present in Chennai : {0}",EmpQuery8);
            Console.WriteLine();
            
            int EmpQuery9= empList.Max(x => x.EmployeeID);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Highest Employee Id from the List was : {0}" ,EmpQuery9);

            Console.WriteLine();

            int EmpQuery10 = (from Employee in empList
                              where Employee.DOJ > new DateTime(2015, 01, 1, 0, 0, 0)
                              select Employee).Count();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Total Number of Employees Joined after 1/1/2015 was : {0}",EmpQuery10);
            Console.WriteLine();

            int EmpQuery11 = (from Employee in empList
                              where Employee.Title!="Associate"
                              select Employee).Count();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Total Number of Employess who are not Associates : {0}", EmpQuery11);
            Console.WriteLine();

            var EmpQuery12 = from Employee in empList
                              group Employee by new
                              {
                                  Employee.City,

                              } into Employee1
                              select new
                              {
                                  City = Employee1.Key.City,
                                  Count_Cit = Employee1.OrderBy(x => x.City)
                              };
            Console.WriteLine("---------------------------------------------------");
            foreach (var item in EmpQuery12)
            {
                
                Console.WriteLine($"City: {item.City} ----Number of Employees = {item.Count_Cit.Count()}");
                Console.WriteLine('\n');
            }


             Console.WriteLine();

            var EmpQuery13 = from Employee in empList
                             group Employee by new
                             {
                                 Employee.City,
                                 Employee.Title,

                             } into Employee2
                             select new
                             {
                                 City = Employee2.Key.City,
                                 Title = Employee2.Key.Title,
                                 Count_Cit = Employee2.OrderBy(x => x.City),
                                 Count_Tit = Employee2.OrderBy(x => x.Title)
                             };
            Console.WriteLine("---------------------------------------------------");
            foreach (var item in EmpQuery13)
            {

                Console.WriteLine($"City: {item.City} , Title: {item.Title} ----Number of Employees = {item.Count_Cit.Count()}");
                Console.WriteLine();
                
            }
            
            Console.WriteLine();



            var EmpQuery14 = empList.Select(em => em.DOB) ;
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Youngest Employee DOB : {0}", EmpQuery14.Max());



            Console.WriteLine();





            Console.ReadKey();

        }
    }
}
