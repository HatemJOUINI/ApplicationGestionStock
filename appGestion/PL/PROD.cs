using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;

namespace appGestion.PL
{
    public partial class PROD : Form
    {
        public PROD()
        {
            InitializeComponent();
        }

        DataTableCollection tableCollection;
        private void btnbrowser_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog=new OpenFileDialog () { Filter= "Excel 97-2018  workbook |*.xls|Excel workbook |*.xlsx"})
                {
                    if ( openFileDialog.ShowDialog () == DialogResult.OK)
                {
                    txtFile.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_)=> new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cboSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cboSheet.Items.Add(table.TableName);
                        }
                    }
                }
                }
        }

        private void PROD_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }
    }
}
