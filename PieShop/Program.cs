using PieShop.Accounting;
using PieShop.HR;
using System.Text;



//int a = 42;
//int aCopy = a;
//Console.WriteLine($"Value of a: {a} and value of copy of a: {aCopy}");
//aCopy = 100;
//Console.WriteLine($"Value of a: {a} and value of copy of a: {aCopy}");

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");


Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager); //čim pozovem new, konstruktor se pozove

Employee george = new("George","Jones","george@snowball.be", new DateTime(1980, 2, 17), null, EmployeeType.Research);

//Employee mysteryEmployee = null;
//mysteryEmployee.DisplayEmployeeDetails();

#region First run Bethany

bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();
bethany.ReceiveWage();
bethany.DisplayEmployeeDetails();

#endregion 


#region First run George

george.PerformWork(10);
george.PerformWork();
george.PerformWork();
george.ReceiveWage();
george.DisplayEmployeeDetails();

#endregion

Employee.taxRate = 0.02;

#region Second run Bethany
    
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.ReceiveWage();
bethany.DisplayEmployeeDetails();

#endregion


#region Second run George

george.PerformWork();
george.PerformWork();
george.PerformWork();
george.ReceiveWage();
george.DisplayEmployeeDetails();

#endregion

Employee.DisplayTaxRate();


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
