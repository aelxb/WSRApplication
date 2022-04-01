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
    /// Логика взаимодействия для Storewindow.xaml
    /// </summary>
    public partial class Storewindow : Window
    {
        private readonly UsrContext _context = new UsrContext();
        public Storewindow()
        {
            InitializeComponent();
            stores.DataContext = _context;
            stores.ItemsSource = _context.User;
        }

        private async void delete_Click(object sender, RoutedEventArgs e)
        {
            Store u = _context.Store.ToList().Find(u => u.ID == int.Parse(stores.SelectedValue.ToString()));
            _context.Remove(u);
            await _context.SaveChangesAsync();
        }


        private void add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
