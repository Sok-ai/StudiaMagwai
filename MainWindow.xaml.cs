using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudiaProgramm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {

            using (ApplicationContext db = new ApplicationContext())
            {
                var currentUser = db.user.FirstOrDefault(p => p.Login == TB_Login.Text && p.Password == password.Password);

                var x = db.role.Where(p => p.id == User.CurrentUser.role_id);

                if (currentUser != null)
                {
                    User.CurrentUser = currentUser;
                    var StartForm = new Start();
                    StartForm.Show();
                    this.Hide();

                    foreach (Role name in x)
                    {
                        MessageBox.Show($"Вы авторизовались как {name.Name}");
                    }
                }
                else
                {
                    MessageBox.Show("Логин или пароль введён неверно");
                }
            }
        }
    }
}
