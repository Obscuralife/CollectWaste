using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using DataAccessLayer;
using SystemForCollectWaste.Service;
using System.Threading.Tasks;
using SystemForCollectWaste.Model;

namespace SystemForCollectWaste
{
    public partial class SolidWastesList : Form
    {
        private readonly ApplicationDbContext dbContext;
        private readonly SolidWasteService solidWasteService;
        public SolidWastesList(ApplicationDbContext context)
        {
            dbContext = context;
            solidWasteService = new SolidWasteService(dbContext);
            InitializeComponent();
        }

        public async Task ShowDataAsync()
        {
            SolidWasteGridView.DataSource = await solidWasteService.GetGridDataAsync();
        }

        private async void SolidWasteForm_LoadAsync(object sender, EventArgs e)
        {
            await ShowDataAsync();
        }

        private async void AddSolidWaste_ClickAsync(object sender, EventArgs e)
        {
            var solidWasteOperations = new AddSolidWasteForm(dbContext);
            solidWasteOperations.ShowDialog();
            await ShowDataAsync();
        }

        private async void RemoveSolidWasteRecord_ClickAsync(object sender, EventArgs e)
        {
            var selectedRows = SolidWasteGridView.SelectedRows;
            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Не выбран(ы) параметр(ы)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    var solidWaste = row.DataBoundItem as SolidWasteModel;
                    if (solidWaste != null)
                    {
                        await solidWasteService.RemoveAsync(solidWaste.Id);
                    }
                }
            }

            await ShowDataAsync();
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void SolidWasteReport_Click(object sender, EventArgs e)
        {
            var excelInstance = new Excel.Application();
            var workBook = excelInstance.Workbooks.Add(System.Reflection.Missing.Value);
            var workSheet = (Excel.Worksheet)workBook.Sheets[1];
            excelInstance.Cells[1, 1] = "ТБО";

            for (int i = 0; i < SolidWasteGridView.RowCount; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    excelInstance.Cells[i + 2, j + 1] = SolidWasteGridView[j, i].Value;
                }
            }

            excelInstance.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
