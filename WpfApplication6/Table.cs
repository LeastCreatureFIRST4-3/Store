using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace WpfApplication6
{
    public class Table
    {
        public ObservableCollection<Columns> Columns { get; set; }

        public int ColumnSize
        {
            get
            {
                return Columns.Count;   
            }
        }
        public int RowsSize {
            get {
                return Columns[0].Cells.Count;
            }
        }
        public Table()
        {
            Columns = new ObservableCollection<Columns>();
        }

        public double[,] toMatrix()
        {
            double[,] result = new double[Columns.Count, Columns.Count];
            int i = 0; int j = 0;
            foreach (var c in Columns)
            {
                j = 0;
                foreach (var cell in c.Cells) {
                    result[i, j] = Double.Parse(cell.Value);
                    j++;
                }
                
                i++;
            }
            return result;
        }

        public void fromMatrix(double[,] m)
        {
            this.Columns.Clear();
            for (int i = 0; i < m.GetLength(0); i++) {
                Columns c = new Columns();
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    c.Cells.Add(new Cell(m[i,j].ToString()));
                }
                this.Columns.Add(c);
            }
        }
    }
}
