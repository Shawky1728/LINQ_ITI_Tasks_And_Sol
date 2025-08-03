using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Day2_Sol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };


            //Query1: Display numbers without any repeated Data and sorted 

            //var res = numbers.Distinct().OrderBy(i=>i);


            //Query2: using Query1  result and show each number and it’s multiplication 

            //var res = numbers.Distinct().Order().Select(i => new {Number=i,Multiply=i*i});



            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            //Query1: Select names with length equal 3.  

            //var res = names.Where(i => i.Length == 3);


            //Query2: Select names that contains “a” letter (Capital or Small )then sort them by length


            //var res = names.Where(i => i.ToLower().Contains('a')).OrderBy(i=>i.Length);


            //Query3: Display the first 2 names 

            //var res = names.Take(2);

            List<Student> students = new List<Student>()
{
    new Student()
    {
        ID = 1,
        FirstName = "Ali",
        LastName = "Mohammed",
        subjects = new Subject[]
        {
            new Subject() { Code = 22, Name = "EF" },
            new Subject() { Code = 33, Name = "UML" }
        }
    },

    new Student()
    {
        ID = 2,
        FirstName = "Mona",
        LastName = "Gala",
        subjects = new Subject[]
        {
            new Subject() { Code = 22, Name = "EF" },
            new Subject() { Code = 34, Name = "XML" },
            new Subject() { Code = 25, Name = "JS" }
        }
    },

    new Student()
    {
        ID = 3,
        FirstName = "Yara",
        LastName = "Yousf",
        subjects = new Subject[]
        {
            new Subject() { Code = 22, Name = "EF" },
            new Subject() { Code = 25, Name = "JS" }
        }
    },

    new Student()
    {
        ID = 4,
        FirstName = "Ali",
        LastName = "Ali",
        subjects = new Subject[]
        {
            new Subject() { Code = 33, Name = "UML" }
        }
    }
};


            //Query1: Display Full name and number of subjects for each student as follow 

            //var res = students.Select(i => new { Fullname = i.FirstName + " " + i.LastName , NoOfSubjects=i.subjects.Length });



            //Query2: Write a query which orders the elements in the list by FirstName
            //Descending then by LastName Ascending and result of query displays only first
            //names and last names for the elements in list as follow

            //var res = students
            //    .OrderByDescending(i => i.FirstName)
            //    .ThenBy(i => i.LastName)
            //    .Select(i => i.FirstName+" "+i.LastName);


            //Query3:Display each student and student’s subject as follow (use selectMany) 

            //var res = students.SelectMany(i => i.subjects, (st, su) =>new
            //{
            //    FullName=st.FirstName+" "+st.LastName,
            //    SubjectName=su.Name
            //}).GroupBy(i=>i.FullName);

          

        }
    }
}
