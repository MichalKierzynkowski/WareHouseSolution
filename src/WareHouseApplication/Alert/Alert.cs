using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseApplication.Alert
{
    public partial class Alert : Form
    {
        private DataGridView dataGridView1;



        public Alert(DataGridView dataGridView1)
        {
            InitializeComponent();
            this.dataGridView1 = dataGridView1;
        }

        private void AnulujButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "ListaProduktow";

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                worksheet.Cells[1, i].EntireRow.Font.Bold = true;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Produkty";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void TekstowyButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Produkty";
            saveFileDialog.DefaultExt = ".txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextWriter writer = new StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        writer.Write("\t"+dataGridView1.Rows[i].Cells[j].Value.ToString()+"\t"+"|");
                    }
                    writer.WriteLine("");
                    writer.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                }
                writer.Close();
                MessageBox.Show("Nice");
            }
        }
        
    }
}
