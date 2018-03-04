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
    public partial class new_document : UserControl
    {
        public new_document()
        {
            InitializeComponent();
        }

        private void save_doc_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Yadda saxla";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    sw.Write(doc_box);

            }
        }

        private void new_document_Load(object sender, EventArgs e)
        {

        }
    }
}
