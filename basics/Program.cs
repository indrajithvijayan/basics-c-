//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//   Variable AND Variable types 

//    LOCAL ARIABLE

//void Show() {

//    int x = 10;
//}
//class calculation
//{
//    public void Calculate() {

//        int rate = 100;      // local variable
//        int quantity = 22;// local variable

//        int result = rate * quantity;// local variable
//        Console.WriteLine(result);

//    }
//    public static void Main() {

//        calculation c = new calculation();
//        c.Calculate();
//    }

//}

//        INSTANCE VARIABLE

//class Bankaccount
//{

//    public string Accountholder; // instance variable
//    public double Balance; // instance variable
//    public void deposit(double money)
//    {
//        Console.WriteLine(Balance += money);
//    }

//    public static void Main()
//    {
//        Bankaccount b = new Bankaccount();
//       b.deposit(1500);

//    }
//}

//class Balancecheck {

//    public double Balance; // instance variable


//    public void Person(double fund)
//    {
//        Balance += fund;
//    }

//    public static void Main()
//    {
//        Balancecheck B = new Balancecheck();
//        Balancecheck B1 = new Balancecheck();
//        Balancecheck B2 = new Balancecheck();
//        B.Person(1000);
//        B1.Person(2500);
//        B2.Person(50000);
//        Console.WriteLine(B1.Balance);

//    }
//}
//  STATIC VARIABLE
//class Student
//{
//    public string Name;
//    public static int count;

//    public Student(string name) {

//        Name = name;
//        count++;

//    }
//    public static void Main() {

//        Student s1 = new Student("Ram");
//        Student s2 = new Student("Ravi");

//        Console.WriteLine(Student.count);  
//    }
//}

//parameterise variable

//class Calculator
//{
//    public int Add(int a, int b)  // Parameter variables
//    {
//        return a + b;
//    }


//    public static void Main() {

//        Calculator c = new Calculator();
//        int result = c.Add(10, 20);


//    }
//}

//class Bankaccount
//{
//    public readonly int accountnumber;

//    private double balance;

//    public Bankaccount(int accNo, double initialbalance)
//    {
//        accountnumber = accNo;
//        balance = initialbalance;

//    }

//    public void Deposit(double amount)
//    {
//        if (amount > 0)
//        {
//            balance += amount;
//        }
//        else {

//            Console.WriteLine("invalid amount");
//        }
//    }

//    public void ShowDetails()
//    {
//        Console.WriteLine("account number" + accountnumber);
//        Console.WriteLine("Balance: " + balance);
//    }
//    public static void Main()
//    {
//        Bankaccount a1 = new Bankaccount(1001, 5000);
//        Bankaccount a2 = new Bankaccount(1002, 2000);

//        a1.Deposit(1500);
//        a2.Deposit(3000);

//        a1.ShowDetails();
//        a2.ShowDetails();


//    }
//}

//    DATA TYPES

//int AGE = 20;
//byte small = 200;
//long big = 900000000000000;
//double pi = 3.14;
//decimal money = 199.99m;
//bool isLoggedin = true;
//char grade = 'a';
//string name = "indran";
//int[] numbers = { 1,2,3};

//var x = 10;
//var y = "gvh";

//implicit
//int a = 10;
// double b = a;
//Console.WriteLine(b);

//explicit
//double a = 10.3;
//    int b = (int)a;
//Console.WriteLine(b);

//convert class.

//string s = "123";
//int n = Convert.ToInt32(s);
//Console.WriteLine(n);

//string b = "456";
//int y = Convert.ToInt32(b);
//Console.WriteLine(b);

//    Parse 
//string s = "1234";
//int n = int.Parse(s);
//Console.WriteLine(s);

//string g = "123";
//int y = int.Parse(g);
//Console.WriteLine(g);

//string s = "abc";
//int n = int.Parse(s);     //if set a string letter to int it will crash there is tyhe use of try parse 
//                          //itb will catch the error without crashing
//Console.WriteLine(s);

// Try parse
//it only returns true or false

//string s = "abc";
//int n;
//bool ok = int.TryParse(s, out n);

//if (ok)
//    Console.WriteLine(n);
//else
//    Console.WriteLine("invalid number");

//string s = "12345";
//int n;
//bool ok = int.TryParse(s, out n);

//if (ok)
//    Console.WriteLine(n);
//else
//    Console.WriteLine("invalid number");

// SWITCH

//class program
//{
//    public static void Main()
//    {

//        Console.Write("enter your first number:  ");
//        int a = int.Parse(Console.ReadLine());

//        Console.WriteLine("enter your second number :  ");
//        int b = int.Parse(Console.ReadLine());

//        Console.WriteLine("enter your operation(+ - * /)" );
//        char op = char.Parse(Console.ReadLine());


//        switch (op)
//        {

//            case '+':
//                Console.WriteLine("result = " + (a + b));
//                break;


//            case '-':
//                Console.WriteLine("Result = " + (a - b));
//                break;

//            case '*':
//               Console.WriteLine("Result = " + (a * b));
//                break;

//            case '/':
//               Console.WriteLine("Result = " + (a / b));
//                break;

//            default:
//                Console.WriteLine("Invalid Operation");
//                  break;

//        }

//    }
//}

// if / if else

//int a = 10, b = 25, c = 15;

//if (a > b && a > c)
//    Console.WriteLine("A biggest");
//else if (b > c)
//    Console.WriteLine("B biggest");
//else
//     Console.WriteLine("C biggest");



//int balance = 500;

//if (balance >= 1000)
//    Console.WriteLine("Withdraw allowed");
//else
//    Console.WriteLine("Low balance");

// para with retyurn


//class Program
//{
//    static int Add(int a, int b)
//    {
//        return a + b;
//    }

//    static void Main()
//    {
//        int result = Add(5, 3);
//        Console.WriteLine(result);
//    }
//}


//class Program
//{
//    static void Add(int a, int b)
//    {
//        Console.WriteLine("Sum = " + (a + b));
//    }

//    static void Main()
//    {
//        Add(10, 20);
//    }
//}

//class Program
//{
//    static void Hello()
//    {
//        Console.WriteLine("Hello Indran");
//    }

//    static void Main()
//    {
//        Hello();   // calling function
//    }
//}

//    COLLECTIONS
// array
//int[] nums = { 1,2,3,4,5,6};
//foreach (int n in nums)
//    Console.WriteLine(n);

//string[] names = new string[2];
//names[0] = "indran";
//names[1] = "siyad";

//  LIST
//List<int> nums = new List<int>();
//nums.Add(10);
//nums.Add(15);
//nums.Remove(0);
//Console.WriteLine(nums);




