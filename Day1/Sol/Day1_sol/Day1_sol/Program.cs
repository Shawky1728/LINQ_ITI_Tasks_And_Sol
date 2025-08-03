namespace Day1_sol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Example 1: Filtering even numbers

            //var res = numbers.Where(i => i % 2 == 0);


            //Example 2: Filtering numbers greater than 5 

            //var res = numbers.Where(i => i > 5);


            //Example 3: Filtering numbers less than or equal to 5

            //var res = numbers.Where(i => i <= 5);


            //Example 4: Filtering odd numbers 

            //var res = numbers.Where(i => i % 2 == 1);


            //Example 5: Filtering numbers between 3 and 7

            //var res = numbers.Where(i => i > 3 && i < 7);





            //////////////////////////////////////////////////////////////

            List<Student> students = new List<Student>()
{
    new Student()
    {
        ID = 1,
        FirstName = "Sara",
        LastName = "Mohammed",
        Subjects = new Subject[]
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
        Subjects = new Subject[]
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
        Subjects = new Subject[]
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
        Subjects = new Subject[]
        {
            new Subject() { Code = 33, Name = "UML" }
        }
    },

    new Student()
    {
        ID = 5,
        FirstName = "Ali",
        LastName = "Ahmed",
        Subjects = new Subject[]
        {
            new Subject() { Code = 22, Name = "EF" },
            new Subject() { Code = 33, Name = "UML" }
        }
    }
};

            //Example 1: Students with the first name "Ali" 

            //var res = students.Where(i => i.FirstName == "Ali");



            //Example 2: Students enrolled in the subject with code 22

            //var res = students.Where(i => i.Subjects.Any(i=>i.Code==22));


            //Example 3: Students with the last name "Mohammed"

            //var res = students.Where(i => i.LastName == "Mohammed");


            //Example 4: Students with more than one subject

            //var res = students.Where(i => i.Subjects.Length>1);


        }
    }
}
