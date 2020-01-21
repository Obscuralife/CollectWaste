using System;
using System.Windows.Forms;
using DataAccessLayer;
using SystemForCollectWaste.Service;
using SystemForCollectWaste.Model;

namespace SystemForCollectWaste
{
    public partial class AddSubjectForm : Form
    {
        private readonly ApplicationDbContext dbContext;
        private readonly SubjectService subjectService;
        public AddSubjectForm(ApplicationDbContext context)
        {
            dbContext = context;
            subjectService = new SubjectService(dbContext);
            InitializeComponent();
        }

        private async void AddSubject_ClickAsync(object sender, EventArgs e)
        {
            if (HasEmptyFields())
            {
                MessageBox.Show("пустое значение", "ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var model = new SubjectModel
                {
                    Address = AddressBox.Text,
                    Email = EmailBox.Text,
                    Name = NameBox.Text,
                    PhoneNumber = MobilePhoneBox.Text
                };
                try
                {
                    await subjectService.AddEntryAsync(model);
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
            return NameBox.TextLength == 0 || MobilePhoneBox.TextLength == 0
               || EmailBox.TextLength == 0 || AddressBox.TextLength == 0;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddSubjectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
