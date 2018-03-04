using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read_N_write
{
    //İşçi classı
    public class Employee
    {
        public static List<Employee> EmployeeList = new List<Employee>();
        public string Name { get; set; }
        public string Surname { get; set; }
        public string About { get; set; }
        //Konstruktor
        public Employee(string name, string surname, string about)
        {
            this.Name = name;
            this.Surname = surname;
            this.About = about;
            EmployeeList.Add(this);
            
        }
        

    }
}
