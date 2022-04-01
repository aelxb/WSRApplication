using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSRApplication
{
    class Post
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public virtual ICollection<Usr>
            Users
        { get; private set; } =
            new ObservableCollection<Usr>();
    }
}
