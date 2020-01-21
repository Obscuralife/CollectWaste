using System;
using System.Windows.Forms;
using SystemForCollectWaste.Model;
using DataAccessLayer;
using SystemForCollectWaste.Service;

namespace SystemForCollectWaste
{
    public partial class AddEmployeForm : Form
    {
        private readonly ApplicationDbContext dbContext;
        private readonly EmployeService employeService;
        public AddEmployeForm(ApplicationDbContext context)
        {
            dbContext = context;
            employeService = new EmployeService(dbContext);
            InitializeComponent();
        }

        private async void AddEmploye_ClickAsync(object sender, EventArgs e)
        {
            if (HasEmptyFields())
            {
                MessageBox.Show("пустое значение", "ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var model = new EmployeModel
                {
                    Address = AddressBox.Text,
                    Login = LoginBox.Text,
                    Password = PasswordBox.Text,
                    Name = NameBox.Text,
                    PhoneNumber = PhoneNumberBox.Text,
                    Position = PositionBox.Text
                };

                try
                {
                    await employeService.AddEntryAsync(model);
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
            return LoginBox.TextLength == 0 || NameBox.TextLength == 0
                || AddressBox.TextLength == 0 || PasswordBox.TextLength == 0
                || PositionBox.TextLength == 0 || PhoneNumberBox.TextLength == 0;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
