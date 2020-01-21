using System;
using System.Windows.Forms;
using DataAccessLayer;
using SystemForCollectWaste.Service;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace SystemForCollectWaste
{
    public partial class AddWorkDoneForm : Form
    {
        private readonly ApplicationDbContext dbContext;
        private readonly SubjectService subjectService;
        private readonly SolidWasteService solidWasteService;
        private readonly ArgumentService argumentService;
        private readonly CollectService collectService;
        private readonly EmployeService employeService;
        public AddWorkDoneForm(ApplicationDbContext context)
        {
            dbContext = context;
            subjectService = new SubjectService(dbContext);
            solidWasteService = new SolidWasteService(dbContext);
            argumentService = new ArgumentService(dbContext);
            collectService = new CollectService(dbContext);
            employeService = new EmployeService(dbContext);
            InitializeComponent();
        }

        private async void WorkDone_LoadAsync(object sender, EventArgs e)
        {
            await SetArgumentDropDownListAsync();
            await SetWasteDropDownList();
            await SetSubjectDropDownListAsync();
            await SetEmployeDropDownListAsync();
        }

        private async Task SetEmployeDropDownListAsync()
        {
            EmployeDropDownList.Items.Clear();
            var ddItems = await employeService.GetEmployesDropDownListAsync();
            EmployeDropDownList.Items.AddRange(ddItems);
        }

        private async Task SetSubjectDropDownListAsync()
        {
            SubjectDropDown.Items.Clear();
            var ddItems = await subjectService.GetSubjectsDropDownListAsync();
            SubjectDropDown.Items.AddRange(ddItems);
        }

        private async Task SetWasteDropDownList()
        {
            WasteDropDownList.Items.Clear();
            var ddItems = await solidWasteService.GetWasteDropDownListAsync();
            WasteDropDownList.Items.AddRange(ddItems);
        }

        public async Task SetArgumentDropDownListAsync()
        {
            ArgumentDropDown.Items.Clear();
            var ddItems = await argumentService.GetArgumentsDropDownList();
            ArgumentDropDown.Items.AddRange(ddItems);
        }

        private async void Submit_ClickAsync(object sender, EventArgs e)
        {
            if (HasEmptyFields())
            {
                MessageBox.Show("пустое значение", "ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    await collectService.AddCollectAsync(await SetCollectEntityAsync());
                    MessageBox.Show("Успешно добавленно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

                Close();
            }
        }

        private async Task<Collect> SetCollectEntityAsync()
        {
            var argument = await argumentService.GetRecordAsync(ArgumentDropDown.SelectedItem.ToString());
            var solidWaste = await solidWasteService.GetRecordAsync(WasteDropDownList.SelectedItem.ToString());
            var subject = await subjectService.GetRecordAsync(SubjectDropDown.SelectedItem.ToString());
            var employ = await employeService.GetRecordAsync(EmployeDropDownList.SelectedItem.ToString());
            return new Collect
            {
                ArgumentId = argument.Id,
                SolidWasteId = solidWaste.Id,
                SubjectId = subject.Id,
                EmployeId = employ.Id,
                DateTime = WorkDoneDateTime.Value
            };
        }

        private bool HasEmptyFields()
        {
            return SubjectDropDown.SelectedIndex < 0 ||
                 WasteDropDownList.SelectedIndex < 0 ||
                  ArgumentDropDown.SelectedIndex < 0 ||
                EmployeDropDownList.SelectedIndex < 0;

        }

        private async void AddSolidWaste_ClickAsync(object sender, EventArgs e)
        {
            new AddSolidWasteForm(dbContext).ShowDialog();
            await SetWasteDropDownList();
        }

        private async void AddSubject_ClickAsync(object sender, EventArgs e)
        {
            new AddSubjectForm(dbContext).ShowDialog();
            await SetSubjectDropDownListAsync();
        }

        private async void AddArgument_ClickAsync(object sender, EventArgs e)
        {
            new AddArgumentForm(dbContext).ShowDialog();
            await SetWasteDropDownList();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void ShowEmloyes_Click(object sender, EventArgs e)
        {
            new EmployesFormList(dbContext).ShowDialog();
            await SetWasteDropDownList();
        }
    }
}
