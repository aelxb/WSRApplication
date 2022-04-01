using System;
using System.Collections.Generic;
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

namespace WSRApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly UsrContext _context = new UsrContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Auth_Click(object sender, RoutedEventArgs e)
        {
            Usr usr = new Usr();
            usr.Login = "qweasdzx";
            usr.Password = "12312312";
            usr.PostID = 1;
            usr.Role = 1;
            usr.Work = "dfsdf";
            usr.Surname = "sfdfd";
            usr.Secondname = "dssd";
            usr.Name = "ds";
            usr.Expirience = 32;
            usr.DateOfBirth = DateTime.Now;
            usr.Education = "fdsd";
            _context.Add(usr);
            await _context.SaveChangesAsync();
            if (_context.User.ToList().Find(u => u.Login == Login.Text && u.Password == Password.Password&&u.Role==2)!=null){
                UserMenu userMenu = new UserMenu();
                userMenu.Show();
                Hide();
            }
            else if (_context.User.ToList().Find(u => u.Login == Login.Text && u.Password == Password.Password && u.Role == 1) != null)
            {
                AdminWindow aw = new AdminWindow();
                aw.Show();
                Hide();
            }
        }
    }
}
