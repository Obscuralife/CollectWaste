using DataAccessLayer;
using System;
using System.Windows.Forms;
using SystemForCollectWaste.Model;
using SystemForCollectWaste.Service;

namespace SystemForCollectWaste
{
    public partial class AddSolidWasteForm : Form
    {
        private readonly ApplicationDbContext dbContext;
        private readonly SolidWasteService solidWasteService;

        public AddSolidWasteForm(ApplicationDbContext context)
        {
            dbContext = context;
            solidWasteService = new SolidWasteService(dbContext);
            InitializeComponent();
        }

        private void AddSolidWasteForm_Load(object sender, EventArgs e)
        {

        }

        private async void AddWaste_ClickAsync(object sender, EventArgs e)
        {
            if (HasEmptyFields())
            {
                MessageBox.Show("пустое значение", "ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var model = new SolidWasteModel { Description = NameBox.Text };
                try
                {
                    await solidWasteService.AddEntryAsync(model);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка добавления данных", "добавление записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }

                MessageBox.Show("данные добавлены", "добавление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private bool HasEmptyFields()
        {
            return NameBox.TextLength == 0;
        }
    }
}
