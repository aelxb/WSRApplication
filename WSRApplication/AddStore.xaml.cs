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
    /// Логика взаимодействия для AddStore.xaml
    /// </summary>
    public partial class AddStore : Window
    {
        private readonly UsrContext _context = new UsrContext();

        public AddStore()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Store store = new Store();
            store.Category = Category.SelectedItem.ToString();
            store.Storename = storename.Text;
            store.Name = name.Text;
            store.Price = int.Parse(price.Text);
            store.Count = int.Parse(count.Text);
            _context.Store.Add(store);
            await _context.SaveChangesAsync();
        }
    }
}
