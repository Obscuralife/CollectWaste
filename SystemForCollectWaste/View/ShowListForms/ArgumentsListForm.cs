using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using DataAccessLayer;
using SystemForCollectWaste.Service;
using System.Threading.Tasks;
using SystemForCollectWaste.Model;

namespace SystemForCollectWaste
{
    public partial class ArgumentsListForms : Form
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ArgumentService argumentService;
        public ArgumentsListForms(ApplicationDbContext context)
        {
            dbContext = context;
            argumentService = new ArgumentService(dbContext);
            InitializeComponent();
        }

        public async Task ShowDataAsync()
        {
            ArgumentsListGridView.DataSource = await argumentService.GetGridDatasAsync();
        }


        private async void AddArgument_Click(object sender, EventArgs e)
        {
            var attachArgumentForm = new AddArgumentForm(dbContext);
            attachArgumentForm.ShowDialog();
            await ShowDataAsync();

        }

        private async void ArgumentListForm_LoadAsync(object sender, EventArgs e)
        {
            await ShowDataAsync();
        }

        private async void RemoveArgument_Click(object sender, EventArgs e)
        {
            var selectedRows = ArgumentsListGridView.SelectedRows;
            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Не выбран(ы) параметр(ы)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    var argumentModel = row.DataBoundItem as ArgumentModel;
                    if (argumentModel != null)
                    {
                        await argumentService.RemoveAsync(argumentModel.Id);
                    }
                }
            }

            await ShowDataAsync();
        }

        private void AddDocument_Click(object sender, EventArgs e)
        {
            var excelInstance = new Excel.Application();
            var workBook = excelInstance.Workbooks.Add(System.Reflection.Missing.Value);
            var workSheet = workBook.Sheets[1] as Excel.Worksheet;
            excelInstance.Cells[1, 3] = "Параметры объекта:";
            excelInstance.Cells[2, 1] = "Код";
            excelInstance.Cells[2, 2] = "Объект";


            for (int i = 0; i < ArgumentsListGridView.RowCount; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    excelInstance.Cells[i + 3, j + 1] = ArgumentsListGridView[j, i].Value;
                }
            }
            excelInstance.Visible = true;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
