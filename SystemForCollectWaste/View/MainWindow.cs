using System;
using System.Windows.Forms;
using DataAccessLayer;
using SystemForCollectWaste.Service;
using System.Threading.Tasks;
using SystemForCollectWaste.Model;
using System.Drawing;
using System.IO;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;


namespace SystemForCollectWaste
{
    public partial class MainWindow : Form
    {
        private readonly ApplicationDbContext dbContext;
        private readonly MainWindowDataService mainWindowService;
        private readonly SubjectService subjectService;
        private readonly CollectService collectService;
        public MainWindow(ApplicationDbContext context)
        {
            dbContext = context;
            mainWindowService = new MainWindowDataService(dbContext);
            subjectService = new SubjectService(dbContext);
            collectService = new CollectService(dbContext);
            InitializeComponent();
        }

        private async void MainForm_LoadAsync(object sender, EventArgs e)
        {
            await ShowDataAsync();
        }
        public async Task SetSubjectDropDownAsync()
        {
            SubjectDropDown.Items.Clear();
            var ddItems = await subjectService.GetSubjectsDropDownListAsync();
            SubjectDropDown.Items.AddRange(ddItems);
        }


        public async Task ShowDataAsync()
        {
            await SetSubjectDropDownAsync();
            CollectDataGridView.DataSource = await mainWindowService.GetGridDatasAsync();
            label5.Text = $"всего записей - {CollectDataGridView.Rows.Count}";
        }


        private async void AddNewEntry_ClickAsync(object sender, EventArgs e)
        {
            var workDoneForm = new AddWorkDoneForm(dbContext);
            workDoneForm.ShowDialog(this);

            await ShowDataAsync();
        }

        private void FindAndReplace(Word.Application wordApp, object findText, object replaceText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            wordApp.Selection.Find.Execute(ref findText, ref matchCase,
                ref matchWholeWord, ref matchWildCards, ref matchSoundsLike,
                ref matchAllWordForms, ref forward, ref wrap, ref format,
                ref replaceText, ref replace, ref matchKashida,
                ref matchDiacritics, ref matchAlefHamza, ref matchControl);
        }
        private void Agreement_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Filter = "Microsoft Word 2007-2010 (*.docx)|*.docx";
            saveFileDialog1.FilterIndex = 3;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = "Договор";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string currdirect = Application.StartupPath;
                    File.Copy(currdirect + "\\temp.docx", saveFileDialog1.FileName, true);
                    object missing = Missing.Value;
                    Word.Application wordApp = new Word.Application();
                    Word.Document Doc = null;
                    object filename = saveFileDialog1.FileName;

                    if (File.Exists((string)filename))
                    {
                        object readOnly = false;
                        object isVisible = false;
                        wordApp.Visible = false;
                        Doc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly, ref missing,
                                                      ref missing, ref missing, ref missing, ref missing,
                                                      ref missing, ref missing, ref missing, ref isVisible,
                                                      ref missing, ref missing, ref missing, ref missing);
                        Doc.Activate();
                        this.FindAndReplace(wordApp, "<Дата>", Convert.ToString(CollectDataGridView[1, CollectDataGridView.CurrentCell.RowIndex].Value));
                        this.FindAndReplace(wordApp, "<Организация>", Convert.ToString(CollectDataGridView[2, CollectDataGridView.CurrentCell.RowIndex].Value));
                        this.FindAndReplace(wordApp, "<адрес>", Convert.ToString(CollectDataGridView[3, CollectDataGridView.CurrentCell.RowIndex].Value));
                        this.FindAndReplace(wordApp, "<e-mail>", Convert.ToString(CollectDataGridView[4, CollectDataGridView.CurrentCell.RowIndex].Value));
                        this.FindAndReplace(wordApp, "<ТБО>", Convert.ToString(CollectDataGridView[5, CollectDataGridView.CurrentCell.RowIndex].Value));
                        Doc.Save();
                    }
                    else
                    {
                        MessageBox.Show("Файл не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    wordApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void RemoveCollect_ClickAsync(object sender, EventArgs e)
        {
            var selectedRows = CollectDataGridView.SelectedRows;
            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Не выбран(ы) параметр(ы)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    var model = row.DataBoundItem as WorkDoneModel;
                    await collectService.RemoveAsync(model.Id);
                }
            }

            await ShowDataAsync();
        }

        private async void ShowAllButton_Click(object sender, EventArgs e)
        {
            await ShowDataAsync();
        }

        private async void SolidWaste_Click(object sender, EventArgs e)
        {
            new SolidWastesList(dbContext).ShowDialog();
            await ShowDataAsync();
        }

        private async void SubjectsList_Click(object sender, EventArgs e)
        {
            new SubjectsListForm(dbContext).ShowDialog();
            await ShowDataAsync();
        }

        private void SetTimeRange_Click(object sender, EventArgs e)
        {
            if (StartDateTimeRange.Value < EndDateTimeRange.Value)
            {
                MessageBox.Show("Не правильно установлен диапозон времени", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < CollectDataGridView.Rows.Count; i++)
                {
                    var startDate = StartDateTimeRange.Value.AddDays(-1);
                    var collectDate = DateTime.Parse(CollectDataGridView[0, i].Value.ToString());
                    var endDate = EndDateTimeRange.Value;

                    if ((startDate < collectDate) && (endDate > collectDate))
                    {
                        CollectDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void RestoreTimeRange_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CollectDataGridView.Rows.Count; i++)
            {
                CollectDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private async void ShowConcreteCollect_ClickAsync(object sender, EventArgs e)
        {
            var request = SubjectDropDown.SelectedItem.ToString();
            CollectDataGridView.DataSource = await mainWindowService.GetGridDatasByNameAsync(request);
        }
    }
}

