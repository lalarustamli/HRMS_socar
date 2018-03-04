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
    public partial class employee_list : UserControl
    {
        public employee_list()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void gridview_data()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Ad", typeof(string));
            dataTable.Columns.Add("Soyad", typeof(string));
            dataTable.Columns.Add("Text", typeof(string));
            employee_data.DataSource = dataTable;
            string[] lines = File.ReadAllLines("C:\\Text\\text.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                dataTable.Rows.Add(lines[i].Split(' '));
            }
            
        }

        private void employee_list_Load(object sender, EventArgs e)
        {
            gridview_data();
  
        }

        
    }
}
