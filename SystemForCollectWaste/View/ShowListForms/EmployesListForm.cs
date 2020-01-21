using System;
using System.Windows.Forms;
using DataAccessLayer;
using SystemForCollectWaste.Service;
using System.Threading.Tasks;
using SystemForCollectWaste.Model;

namespace SystemForCollectWaste
{
    public partial class EmployesFormList : Form
    {
        private readonly ApplicationDbContext dbContext;
        private readonly EmployeService employeService;
        public EmployesFormList(ApplicationDbContext context)
        {
            dbContext = context;
            employeService = new EmployeService(dbContext);
            InitializeComponent();
        }
        public async Task ShowDataAsync()
        {
            EmployeGridView.DataSource = await employeService.GetGridDatasAsync();
        }
        private async void Employe_LoadAsync(object sender, EventArgs e)
        {
            await ShowDataAsync();
        }

        private async void RemoveEmploye_ClickAsync(object sender, EventArgs e)
        {
            var selectedRows = EmployeGridView.SelectedRows;
            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Не выбран(ы) параметр(ы)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    var employeModel = row.DataBoundItem as EmployeModel;
                    if (employeModel != null)
                    {
                        await employeService.RemoveAsync(employeModel.Id);
                    }
                }
            }
            await ShowDataAsync();
        }

        private async void AddEmploye_ClickAsync(object sender, EventArgs e)
        {
            var employeForm = new AddEmployeForm(dbContext);
            employeForm.ShowDialog();
            await ShowDataAsync();
        }
    }
}
