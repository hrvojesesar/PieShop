using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieShop.HR
{
    internal class Manager : Employee
    {
        public Manager(string firstName, string lastName, string email, DateTime birthDay) : base(firstName, lastName, email, birthDay)
        {



        }


        public void AttendManagementMeeting() //metoda dostupna samo za managera
        {
            NumberOfHoursWorked += 10;
        }


        public override void GiveBonus()
        {
        if (NumberOfHoursWorked > 5) {
                Console.WriteLine($"Manager {FirstName} {LastName} received a management bonus of 500!");
            }
        else
            {
                Console.WriteLine($"Manager {FirstName} {LastName} received a management bonus of 250!");
            }
            
            
            
            
        }


    }
}
