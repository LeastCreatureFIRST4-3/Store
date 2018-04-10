using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Data;
using System;
using System.Windows.Media;
using System.Windows.Controls;
using System.Net;
using System.IO;

namespace WpfApplication6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Table _table1;
        private Table _table2;
        public Table Table1 { get { return _table1; } set { this._table1 = value; OnPropertyChanged("Table1"); } }
        public Table Table2 { get { return _table2; } set { this._table2 = value; OnPropertyChanged("Table2"); } }

        public DataTable dataTable;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Table1 = new Table();
            Table2 = new Table();
        }

        private void Rand_Click(object sender, RoutedEventArgs e)
        {
            Table table = null;

            Button s = (Button)sender;
            String buttonName = s.Name;
            
            if (buttonName == "button4") {
                table = Table1;
            }
            else if (buttonName == "button6")
            {
                table = Table2;
            }
            int nums = table.ColumnSize * table.RowsSize;
            String url = @"https://www.random.org/integers/?num=" + nums +"&min=1&max=20&col=" +table.ColumnSize +"&base=10&format=plain&rnd=new";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            String html = string.Empty;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            string[] lines = html.Split(
                new[] { "\n" },
                StringSplitOptions.None
            );
            double[,] c = new double[table.ColumnSize, table.RowsSize];

            for (int i = 0; i < lines.Length; i++) {
                String[] numbers = lines[i].Split( new[] { "\t" },
                StringSplitOptions.None);
                if (numbers[0].Length == 0)
                {
                    break;
                }

                for (int j = 0; j < numbers.Length; j++) {
                   
                    int n = Int32.Parse(numbers[j]);

                    c[i, j] = n;
                     
                }
            }

            table.fromMatrix(c);
        }

        private void Build_Click(object sender, RoutedEventArgs e)
        {
            Button s = (Button)sender;
            String buttonName = s.Name;
            Table table = null;
            TextBox t1 = null;
            TextBox t2 = null;
            if (buttonName == "button8") {
                table = Table1;
                t1 = textBox1;
                t2 = textBox2;
            }
            else if (buttonName == "button9") {
                table = Table2;
                t1 = textBox3;
                t2 = textBox4;
            }
            table.Columns.Clear();
            int a = Int32.Parse(t1.Text);
            int b = Int32.Parse(t2.Text);
            for (int i = 0; i < a; i++) {
                Columns column = new Columns();
                for (int j = 0; j < b; j++)
                {
                    column.Cells.Add(new Cell(""));
                }
                table.Columns.Add(column);
            }

        }

        private void Mult_Click(object sender, RoutedEventArgs e)
        {
            double[,] a = Table1.toMatrix();
            double[,] b = Table2.toMatrix();
            double[,] c = new double[Table1.ColumnSize,Table2.RowsSize];
            int n = Table1.ColumnSize;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[j, i] = 0;
                    for (int k = 0; k < n; k++)
                        c[j, i] = c[j, i] + a[k, i] * b[j, k];
                }
            }
            ShowMatrix(c);
        }

        private void ShowMatrix(double[,] m)
        {
            String message = "";
            for (int i = 0; i < m.GetLength(0); i++) {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    message += m[i,j] + "  ";
                }
                message += Environment.NewLine;
            }

            MessageBox.Show(message);
            string path = @"D:\1.txt";
            File.AppendAllText(path, Environment.NewLine);
            File.AppendAllText(path, message);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            double[,] a = Table1.toMatrix();
            double[,] b = Table2.toMatrix();
            double[,] c = new double[Table1.ColumnSize, Table2.RowsSize];
            int n = Table1.ColumnSize;
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                        c[j, i] = a[j, i] + b[j, i];
                }
            }
            ShowMatrix(c);
        }
        
        private void Det_Click(object sender, RoutedEventArgs e)
        {
            double res = DeterminantGaussElimination(Table1.toMatrix());
            MessageBox.Show(res.ToString());
            
        }

        static double DeterminantGaussElimination(double[,] matrix)
        {
            int n = int.Parse(System.Math.Sqrt(matrix.Length).ToString());
            int nm1 = n - 1;
            int kp1;
            double p;
            double det = 1;
            for (int k = 0; k < nm1; k++)
            {
                kp1 = k + 1;
                for (int i = kp1; i < n; i++)
                {
                    p = matrix[i, k] / matrix[k, k];
                    for (int j = kp1; j < n; j++)
                        matrix[i, j] = matrix[i, j] - p * matrix[k, j];
                }
            }
            for (int i = 0; i < n; i++)
                det = det * matrix[i, i];
            return det;

        }
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
