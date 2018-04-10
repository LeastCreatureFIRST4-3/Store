using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace WpfApplication6
{   
    public class Columns
    {
        public ObservableCollection<Cell> Cells { get; set; }

        public Columns()
        {
            Cells = new ObservableCollection<Cell>();
        }

    }
}
