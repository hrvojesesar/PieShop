using PieShop.Accounting;
using PieShop.HR;
using System.Text;





IEmployee bethany = new StoreManager("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979,1,16),25);


Console.WriteLine("How many hours do we need to register for Bethany?");
int numberOfHours = 0;
string input = Console.ReadLine();  
numberOfHours=int.Parse(input);


bethany.DisplayEmployeeDetails();
bethany.PerformWork();
bethany.PerformWork(numberOfHours);



//int a = 42;
//int aCopy = a;
//Console.WriteLine($"Value of a: {a} and value of copy of a: {aCopy}");
//aCopy = 100;
//Console.WriteLine($"Value of a: {a} and value of copy of a: {aCopy}");

//Console.WriteLine("Creating an employee");
//Console.WriteLine("--------------------\n");





//int[] sampleArray1 = new int[5];

//int[] sampleArray2 = new int[] {1, 2, 3, 4 ,5 };


//int length = int.Parse(Console.ReadLine());

//int[] employeeIDs = new int[length];

//var testID = employeeIDs[0];////int[] sampleA = new int[5] {1, 2, 3, 4 ,5, 6};

//Console.WriteLine("How many employees IDs you want to register?");


//var errorID = employeeIDs[length];


//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine("Enter the employee ID: ");
//    int id = int.Parse(Console.ReadLine()); //let's assume here that the user will always enter a number
//    employeeIDs[i] = id;

//}

//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIDs[i]}");
//}

//Array.Sort(employeeIDs);


//Console.WriteLine("After sorting: ");
//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIDs[i]}");
//}


//int[] employeeIdsCopy = new int[length];

//employeeIDs.CopyTo(employeeIdsCopy, 0);

//Array.Reverse(employeeIdsCopy);



//Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager); //čim pozovem new, konstruktor se pozove

//Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1980, 2, 17), 25, EmployeeType.Research);

//Employee mary = new("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30, EmployeeType.Manager);

//Employee bobJunior = new("Bob ", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17, EmployeeType.Research);

//Employee kevin = new("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10, EmployeeType.StoreManager);

//Employee kate = new("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10, EmployeeType.StoreManager);

//Employee kim = new("Kim", "Jacobs", "kim@snowball.be", new DateTime(1975, 5, 14), 22, EmployeeType.StoreManager);

//Employee[] employees = new Employee[7];

//employees[0] = bethany;
//employees[1] = george;
//employees[2] = mary;
//employees[3] = bobJunior;
//employees[4] = kevin;
//employees[5] = kate;
//employees[6] = kim;

//foreach (Employee e in employees)
//{
//    e.DisplayEmployeeDetails();
//    var numberOfHoursWorked = new Random().Next(25);
//    e.PerformWork(numberOfHoursWorked);
//    e.ReceiveWage();
//}


//Employee mysteryEmployee = null;
//mysteryEmployee.DisplayEmployeeDetails();


//List<Employee> employees = new List<Employee>();
//for (int i = 0; i < 10000000; i++)
//{
//    Employee randomEmployee = new Employee(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),
//        Guid.NewGuid().ToString(), new DateTime(1979, 1, 16), null, EmployeeType.StoreManager);
//    employees.Add(randomEmployee);
//}

//employees.Clear();
//employees = null;

//GC.Collect();


//Console.ReadLine();


//string bethanyAsJson = bethany.ConvertToJson();
//Console.WriteLine(bethanyAsJson);



//string name = "bethany";
//string anotherName  =name;
//name+=" smith";
//Console.WriteLine($"Value of name: {name} and value of copy of name: {anotherName}");


//string upperCaseName= name.ToUpper();

//Console.WriteLine("Name: " + name);
//Console.WriteLine("Upper case name: "  +upperCaseName);


//string firstName  ="Bethany";
//string lastName  ="Smith";


//StringBuilder builder = new StringBuilder();

//builder.Append("Last name: ");
//builder.AppendLine(lastName);
//builder.Append("First name: ");
//builder.AppendLine(firstName);
//string result = builder.ToString();
//Console.WriteLine(result);


//StringBuilder builder2=new StringBuilder();

//for (int i=0; i<2500; i++)
//{
//    builder2.Append(i);
//    builder2.Append(" ");
//}
//string list=builder2.ToString();
//Console.WriteLine(list);


//bethany.PerformWork(25);

//int minimumBonus = 100;
//int receivedBonus = bethany.CalculateBonus(minimumBonus);
//Console.WriteLine($"The minimum bonus is {minimumBonus} and {bethany.firstName} has received a bonus of {receivedBonus}");

//int minimumBonus=100;
//int bonusTax;
//int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, out bonusTax);
//Console.WriteLine($"The minimum bonus is {minimumBonus} and {bethany.firstName} has received a bonus of {receivedBonus} and the bonus tax is {bonusTax}");


//Employee testEmployee = bethany;
//testEmployee.firstName = "Gill";
//testEmployee.DisplayEmployeeDetails();
//bethany.DisplayEmployeeDetails();


//bethany.DisplayEmployeeDetails();

//bethany.PerformWork();
//bethany.PerformWork();
//bethany.PerformWork(5);
//bethany.PerformWork();

//bethany.firstName = "John";
//bethany.hourlyRate = 10;

//bethany.DisplayEmployeeDetails();
//bethany.PerformWork();
//bethany.PerformWork(12);
//bethany.PerformWork();
//bethany.ReceiveWage();


//string fn = bethany.firstName;

//double receivedWageBethany = bethany.ReceiveWage(true);
//Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");


//StructTask task;
//task.description = "Create a new pie";
//task.hours = 2;

//task.PerformTaskWork();


//Customer customer = new();

//Console.WriteLine("Creating an employee");
//Console.WriteLine("--------------------\n");

//Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984,3,28),30);

//george.DisplayEmployeeDetails();
//george.PerformWork();
//george.PerformWork();
//george.PerformWork(3);
//george.PerformWork();
//george.PerformWork(8);

//var receivedWageGeorge = george.ReceiveWage(true);


//IEmployee bethany = new StoreManager("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25); //čim pozovem new, konstruktor se pozove


//IEmployee mary = new Manager("Mary","Jones","mary@snowball.be", new DateTime(1965,1,16));


//IEmployee bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988,1,23),17);
//bobJunior.ResearchNewPieTastes(5);
//bobJunior.ResearchNewPieTastes(5);


//IEmployee kevin = new StoreManager("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10);

//IEmployee kate = new StoreManager("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);



//List<IEmployee> employees = new List<IEmployee>();
//employees.Add(bethany);
//employees.Add(mary);
//employees.Add(bobJunior);
//employees.Add(kevin);
//employees.Add(kate);



//foreach (Employee employee in employees)
//{
//    employee.DisplayEmployeeDetails();
//    employee.GiveBonus();
//    employee.GiveCommplient();
//}


//bethany.DisplayEmployeeDetails();
//bethany.PerformWork(8);
//bethany.PerformWork();
//bethany.PerformWork(3);
//bethany.ReceiveWage();



//mary.DisplayEmployeeDetails();
//mary.PerformWork(25);
//mary.PerformWork();
//mary.PerformWork(0);
//mary.ReceiveWage();
////mary.AttendManagementMeeting();


//mary.GiveBonus();

//bobJunior.ResearchNewPieTastes(5);
//bobJunior.ResearchNewPieTastes(5);



//bethany.FirstName = "John"; //odnosi se na set
//string fn = bethany.FirstName; //odnosi se na get 


//var wage = bethany.Wage; //odnosi se na get






//List<int> employeeIds = new List<int>();

//employeeIds.Add(55);
//employeeIds.Add(1);
//employeeIds.Add(943);
//employeeIds.Add(78);
//employeeIds.Add(79);


//if (employeeIds.Contains(78))
//{
//    Console.WriteLine("Employee ID 78 is in the list");
//}
//else
//{
//    Console.WriteLine("Employee ID 78 is not in the list");
//}

//int currentAmountOfEmployees=employeeIds.Count();

//var employeeIdsArray = employeeIds.ToArray();


//employeeIds.Clear();


//Console.WriteLine("How many employees IDs do you want to register?");

//int length=int.Parse(Console.ReadLine());

//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine("Enter employee ID:");
//    int employeeId = int.Parse(Console.ReadLine());
//    employeeIds.Add(employeeId);
//}


//Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager); //čim pozovem new, konstruktor se pozove

//Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1980, 2, 17), 25, EmployeeType.Research);

//Employee mary = new("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30, EmployeeType.Manager);

//Employee bobJunior = new("Bob ", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17, EmployeeType.Research);

//Employee kevin = new("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10, EmployeeType.StoreManager);

//Employee kate = new("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10, EmployeeType.StoreManager);

//Employee kim = new("Kim", "Jacobs", "kim@snowball.be", new DateTime(1975, 5, 14), 22, EmployeeType.StoreManager);


//List<Employee> employees = new List<Employee>();
//employees.Add(george);
//employees.Insert(0, bethany);
//employees.Add(mary);
//employees.Add(bobJunior);

//employees.Add(kevin);
//employees.Add(kate);
//employees.Add(kim);

//foreach (Employee employee in employees)
//{
//    employee.DisplayEmployeeDetails();
//}