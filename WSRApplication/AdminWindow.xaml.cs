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
using System.Windows.Shapes;

namespace WSRApplication
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private readonly UsrContext _context = new UsrContext();
        public AdminWindow()
        {
            InitializeComponent();
            users.DataContext = _context;
            users.ItemsSource = _context.User;
        }

        private async void deleteuser_Click(object sender, RoutedEventArgs e)
        {
            Usr u = _context.User.ToList().Find(u => u.ID == int.Parse(users.SelectedValue.ToString()));
            _context.Remove(u);
            await _context.SaveChangesAsync();
        }

        private void adduser_Click(object sender, RoutedEventArgs e)
        {
            adduserwindow adduserwindow = new adduserwindow();
            adduserwindow.Show();
            Close();
        }
    }
}
