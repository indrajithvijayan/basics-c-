using System;
using System.Collections.Generic;
using System.Text;

//namespace basics
//{
//    public class Class1
//{
//        static void Main()
//        {
//            List<string> students = new List<string>();
//            students.Add("indran");
//            students.Add("gokul");
//            students.Add("ajmal");
//            students.Add("jithin");

//            Console.WriteLine("student lisgt");
//            ShowStudents(students);

//            students.Remove("jithin");
//            Console.WriteLine("enter name to search");
//            string name = Console.ReadLine();

//            if (students.Contains(name))
//                Console.WriteLine("student found");
//            else
//                Console.WriteLine("student not found");
//            Console.WriteLine("\ntotal students =" + students.Count);

//        }
//    }


//    class Listexample
//{
//    static void Main() {

//        List<string> names = new List<string>();
//        names.Add("indran");
//        names.Add("siyad");
//        names.Add("jithin");
//        names.Add("gokul"); 



//    }
//}
//}

// encapsulation

//class Bank
//{ 
//private int Balance; // hidden data

//    public void Deposit(int amount)
//    {
//        Balance += amount;
//    }

//    public void ShowBalance() {

//        Console.WriteLine(Balance);
//    }

//}
//class Program
//{ 
//public static void Main()
//    {
//        Bank b = new Bank();
//        b.Deposit(1000);
//        b.ShowBalance();
//    }
//}

//class Student
//{
//    private int Mark;
//    public void SetMark(int m) {

//        if (m >= 0 && m <= 100)  // student mark validation 
//            Mark = m;
//        else
//            Console.WriteLine("invalid mark");

//    }

//    public int ShowMark() {

//        return Mark;
//    }

//    public static void Main() {

//        Student s = new Student();
//        s.SetMark(50);
//        Console.WriteLine(s.ShowMark());

//        Student s1 = new Student();
//        s.SetMark(-2);
//        Console.WriteLine(s1.ShowMark());
//    }

//}

// employee salary bonus

//class Employe
//{
//    private int Salary;

//    public void Setsalary(int s)
//    {
//        if (s > 0)
//            Salary = s;
//    }

//    public double Getsalarywithbonus()
//    {
//        return Salary + (Salary*0.1);
//    }

//    public static void Main() {

//        Employe E = new Employe();
//        E.Setsalary(10000);
//       Console.WriteLine( E.Getsalarywithbonus());
//    }

//}
//class Car
//{
//    private int speed;

//    public int Speed
//    {
//        get { return speed; }
//        set { if (value >= 0 && value <= 200)
//                speed = value;
//        }
//    }
//    public static void Main()
//    {
//        Car c = new Car();
//        c.Speed = -5;
//        Console.WriteLine(c.Speed);
//    }
//}
// polymorphism and the methods
// method ovberloading compiletime
//class Calc
//{
//    public int add(int a,int b)
//    {
//        return a + b;
//    }
//    public int add(int a, int b, int c)
//    {
//        return a + b + c;
//    }

//    public double add(double a, double b)
//    {
//        return a + b;
//    }

//    public static void Main()
//    {
//        Calc c = new Calc();
//       Console.WriteLine( c.add(1,2,3));
//        Console.WriteLine(c.add(1, 2));
//        Console.WriteLine(c.add(1.2, 3.5));



//    }
//}

//method overriding

//class Animal
//{
//    public virtual void sound()
//    {
//        Console.WriteLine("animal sound");
//    }
//}
//class Dog : Animal
//{
//    public override void sound()
//    {
//        Console.WriteLine("bark");
//    }
//}

//abstract class shape
//{
//    public abstract void Draw();

//}

//class circle : shape
//{

//    public override void Draw()
//    {
//        Console.WriteLine("drawing circle");
//    }
//}


// Linq
//class Program
//{
//    public static void Main()
//    {
//        int[] nums = { 1, 2, 3, 4, 5, 6 };

//        var even = nums.Where(n => n % 2 == 0);

//        foreach (var n in even)
//            Console.WriteLine(n);
//    }
//}
//class Student
//{
//    public string Name;
//    public int Marks;

//}
//class Program
//{
//    public static void Main()
//    {
//        List<Student> list = new List<Student>()
//        {

//        new Student(){Name ="arun",Marks=50 },
//        new Student(){Name="vijay", Marks=70 },
//        new Student(){ Name="ajay", Marks=70}
//        };
//        var passed = list.Where(n => n.Marks > 60);
//        foreach (var n in passed)
//            Console.WriteLine(n.Name);
//    }
//}

// groupby city  and count numbers

//class Person
//{
//    public int PersonId;
//    public string Name;
//    public int Age;
//    public string City;
//}
//class Order
//{
//    public int OrderId;
//    public int PersonId;
//    public double Amount;

//}
//class Program
//{
//    static void Main()
//    {

//        static List<Person> GetPeople()
//        {
//            return new List<Person>()
//        {
//            new Person{ PersonId=1, Name="Arun", Age=25, City="Kochi"},
//            new Person{ PersonId=2, Name="Ajay", Age=30, City="Calicut"},
//            new Person{ PersonId=3, Name="Anu", Age=18, City="Kochi"},
//            new Person{ PersonId=4, Name="Vijay", Age=45, City="Trivandrum"},
//            new Person{ PersonId=5, Name="Arun", Age=35, City="Calicut"}
//        };
//        }

//        static List<Order> GetOrders()
//        {
//            return new List<Order>()
//        {
//            new Order{ OrderId=1, PersonId=1, Amount=500 },
//            new Order{ OrderId=2, PersonId=1, Amount=200 },
//            new Order{ OrderId=3, PersonId=2, Amount=1000 },
//            new Order{ OrderId=4, PersonId=3, Amount=300 },
//            new Order{ OrderId=5, PersonId=5, Amount=700 }
//        };
//        }


//        var People = GetPeople();
//        var orders = GetOrders();


        //Console.WriteLine("1.group by city count");

        //var q1 = People.GroupBy(p => p.City)
        //    .Select(g => new { city = g.Key, count = g.Count() });  // q1

        //foreach (var x in q1)
        //    Console.WriteLine($"{x.city} - {x.count}");


        //Console.WriteLine("top 3 oldest");
        //var q2 = People.OrderByDescending(p => p.Age).Take(3);   // q2
        //foreach (var p in q2)
        //    Console.WriteLine($"{p.Name} {p.Age}");

        //Console.WriteLine("Nmae starts with A and age <30");
        //var q3 = People.Where(n => n.Age < 30 && n.Name.StartsWith("A"));    // q3
        //foreach (var n in q3)
        //    Console.WriteLine($"{n.Name}-{n.Age}");

        //Console.WriteLine(" group by age range");
        //var q4 = People.GroupBy(p =>
        //p.Age <= 20 ? "teen" :
        //p.Age <= 40 ? "adult" : "senior")
        //    .Select(g => new { g.Key, Count = g.Count() });  // q4

        //foreach (var n in q4)
        //    Console.WriteLine($"{n.Count}-{n.Key}");

        //Console.WriteLine("join people + orders");
        //var q5 = People.Join(orders,
        //    p => p.PersonId,
        //    o => o.PersonId,
        //    (p, o) => new { p.Name, o.Amount });   // q5r

        //foreach (var x in q5)
        ////    Console.WriteLine($"{x.Name}");

        //Console.WriteLine("duplicate names");

        //var q7 = People.GroupBy(g => g.Name)
        //    .Where(g => g.Count() > 1)
        //    .Select(g => g.Key);
        //foreach (var name in q7)      // q7
        //    Console.WriteLine(name);


        //Console.WriteLine("average age per city");
        //var q8 = People.GroupBy(g => g.City)
        //    .Select(g => new { g.Key, avg = g.Average(p => p.Age) });

        //Console.WriteLine("dictionary name age");
        //var q10 = People.GroupBy(p => p.Name)
        //         .ToDictionary(g => g.Key, g => g.First().Age);

        //foreach (var x in q10)
        //    Console.WriteLine($"{x.Key}-{x.Value}");


//    }
//}



//class Student
//{
//    public int Id;
//    public string Name;
//    public int Age;
//    public int CourseId;
//}

//class Course
//{
//    public int CourseId;
//    public string CourseName;
//}

//class StudentManager
//{
//    private List<Student> students = new List<Student>();

//    public void AddStudent(Student s)
//    {
//        students.Add(s);
//    }

//    public void ViewStudents()
//    {
//        foreach (var s in students)
//            Console.WriteLine($"{s.Id} {s.Name} {s.Age} Course:{s.CourseId}");
//    }

//    public void UpdateStudent(int id, string name, int age)
//    {
//        var student = students.FirstOrDefault(s => s.Id == id);
//        if (student != null)
//        {
//            student.Name = name;
//            student.Age = age;
//        }
//    }

//    public void DeleteStudent(int id)
//    {
//        var student = students.FirstOrDefault(s => s.Id == id);
//        if (student != null)
//            students.Remove(student);
//    }

//    public List<Student> GetStudents()
//    {
//        return students;
//    }
//}

//class CourseManager
//{
//    private List<Course> courses = new List<Course>();

//    public void AddCourse(Course c)
//    {
//        courses.Add(c);
//    }

//    public void ViewCourses()
//    {
//        foreach (var c in courses)
//            Console.WriteLine($"{c.CourseId} {c.CourseName}");
//    }

//    public List<Course> GetCourses()
//    {
//        return courses;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var sm = new StudentManager();
//        var cm = new CourseManager();

        
//        cm.AddCourse(new Course { CourseId = 1, CourseName = "C#" });
//        cm.AddCourse(new Course { CourseId = 2, CourseName = "Python" });

      
//        sm.AddStudent(new Student { Id = 1, Name = "Arun", Age = 25, CourseId = 1 });
//        sm.AddStudent(new Student { Id = 2, Name = "Ajay", Age = 19, CourseId = 2 });
//        sm.AddStudent(new Student { Id = 3, Name = "Anu", Age = 30, CourseId = 1 });

//        Console.WriteLine("All Students");
//        sm.ViewStudents();

//        Console.WriteLine("\nStudents Above Age 20");
//        var aboveAge = sm.GetStudents()
//                         .Where(s => s.Age > 20);

//        foreach (var s in aboveAge)
//            Console.WriteLine(s.Name);

//        Console.WriteLine("\nStudents in Course C#");

//        var studentsInCourse =
//            sm.GetStudents().Join(
//                cm.GetCourses(),
//                s => s.CourseId,
//                c => c.CourseId,
//                (s, c) => new { s.Name, c.CourseName })
//            .Where(x => x.CourseName == "C#");

//        foreach (var x in studentsInCourse)
//            Console.WriteLine(x.Name);
//    }
//}
