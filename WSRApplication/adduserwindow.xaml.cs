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
    /// Логика взаимодействия для adduserwindow.xaml
    /// </summary>
    public partial class adduserwindow : Window
    {
        private readonly UsrContext _context = new UsrContext();

        public adduserwindow()
        {
            InitializeComponent();
            post.ItemsSource = _context.Post;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Usr usr = new Usr;
            usr.DateOfBirth = birthday.DisplayDate;
            usr.Education = education.Text;
            usr.Expirience = int.Parse(exp.Text);
            usr.Login = login.Text;
            usr.Password = password.Text;
            usr.PostID = int.Parse(post.SelectedValue.ToString());
            usr.Work = work.Text;
            usr.Surname = surname.Text;
            usr.Role = int.Parse(role.SelectedValue.ToString());
            usr.Secondname = secname.Text;
            usr.Name = name.Text;
            _context.Add(usr);
            await _context.SaveChangesAsync();
        }
    }
}
