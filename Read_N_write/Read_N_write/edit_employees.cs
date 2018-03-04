using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Read_N_write
{
    public partial class edit_employees : UserControl
    {
        public edit_employees()
        {
            InitializeComponent();
        }
        public void listLoad()
        {
            StreamReader sr = new StreamReader("C:\\Text\\text.txt");

            string line = sr.ReadLine();
            while (line != null)
            {
                employe_list.Items.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }
        private void edit_employees_Load(object sender, EventArgs e)
        {

            listLoad();


            foreach (var item in Employee.EmployeeList)
            {
                employe_list.Items.Add(item.Name + " " + item.Surname + " " + item.About);
            }
        }

        private void employe_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string employee = employe_list.GetItemText(employe_list.SelectedItem);
            string[] words = employee.Split(' ');
            edit_name.Text = employee.Trim(' ');

            string[] lines = File.ReadAllLines("C:\\Text\\text.txt");
            edit_name.Text = words[0];
            edit_surname.Text = words[1];
            edit_text.Text = words[2];
        }

        private void edit_save_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("C:\\Text\\text.txt");
            List<string> linesList = lines.OfType<string>().ToList();
            string line_delete = employe_list.GetItemText(employe_list.SelectedItem);
            linesList.Remove(line_delete);
            lines = linesList.ToArray();
            File.WriteAllLines("C:\\Text\\text.txt", lines);
            Employee employee = new Employee(edit_name.Text, edit_surname.Text, edit_text.Text);
            TextWriter txt = new StreamWriter("C:\\Text\\text.txt", true);
            txt.WriteLine(employee.Name + " " + employee.Surname + " " + employee.About);
            txt.Close();
            edit_name.Clear();
            edit_surname.Clear();
            edit_text.Clear();
            employe_list.Text = " ";
            listLoad();

        }
    }
}
