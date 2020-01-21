using System;
using System.Windows.Forms;
using DataAccessLayer;
using SystemForCollectWaste.Service;
using System.Threading.Tasks;
using SystemForCollectWaste.Model;

namespace SystemForCollectWaste
{
    public partial class SubjectsListForm : Form
    {
        private readonly ApplicationDbContext dbContext;
        private readonly SubjectService subjectService;
        public SubjectsListForm(ApplicationDbContext context)
        {
            dbContext = context;
            subjectService = new SubjectService(dbContext);
            InitializeComponent();
        }

        public async Task ShowDataAsync()
        {
            SubjectsDataGridView.DataSource = await subjectService.GetGridDatasAsync();
        }


        private async void SubjectsListForm_Load(object sender, EventArgs e)
        {
            await ShowDataAsync();
        }

        private async void AddSubject_Click(object sender, EventArgs e)
        {
            new AddSubjectForm(dbContext).ShowDialog();
            await ShowDataAsync();
        }

        private async void RemoveSubjects_Click(object sender, EventArgs e)
        {
            var selectedRows = SubjectsDataGridView.SelectedRows;
            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Не выбран(ы) параметр(ы)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    var subjectModel = row.DataBoundItem as SubjectModel;
                    if (subjectModel != null)
                    {
                        await subjectService.RemoveAsync(subjectModel.Id);
                    }

                }
            }

            await ShowDataAsync();
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ObjExcel;
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
            ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            ObjWorkBook = ObjExcel.Workbooks.Add(System.Reflection.Missing.Value);
            ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];
            ObjExcel.Cells[1, 3] = "Список объектов:";
            ObjExcel.Cells[2, 1] = "Код ";
            ObjExcel.Cells[2, 2] = "Название";
            ObjExcel.Cells[2, 4] = "Телефон";
            ObjExcel.Cells[2, 3] = "E-mail";
            ObjExcel.Cells[2, 5] = "Адрес";
            for (int i = 0; i < SubjectsDataGridView.RowCount; i++)
                for (int j = 0; j < 5; j++)
                    ObjExcel.Cells[i + 3, j + 1] = SubjectsDataGridView[j, i].Value;

            ObjExcel.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }





    }
}
