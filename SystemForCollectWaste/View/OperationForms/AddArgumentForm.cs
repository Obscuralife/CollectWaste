using DataAccessLayer;
using System;
using System.Windows.Forms;
using SystemForCollectWaste.Model;
using SystemForCollectWaste.Service;

namespace SystemForCollectWaste
{
    public partial class AddArgumentForm : Form
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ArgumentService argumentService;

        public AddArgumentForm(ApplicationDbContext context)
        {
            dbContext = context;
            argumentService = new ArgumentService(dbContext);
            InitializeComponent();
        }

        private void CloseArgumentForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void AddArgument_ClickAsync(object sender, EventArgs e)
        {
            if (HasEmptyFields())
            {
                MessageBox.Show("пустое значение", "ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var model = new ArgumentModel { Description = ArgumentsBox.Text };

                try
                {
                    await argumentService.AddEntryAsync(model);
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
            return ArgumentsBox.TextLength == 0;
        }

        private void ArgumentForm_Load(object sender, EventArgs e)
        {

        }

    }
}
