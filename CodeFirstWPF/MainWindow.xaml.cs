using CodeFirstWPF.DataModel;
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

namespace CodeFirstWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ContextDB db = new ContextDB();
        public List<Employees> Employees { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            dgEmp.ItemsSource = db.Employees.ToList();
            comboBind();
            //using (ContextDB context = new ContextDB())
            //{
            //    Posts post = new Posts();
            //    post.Name = "SECURITY";
            //    post.Salary = 1000.99m;
            //    post.Duty = "To secure";
            //    context.Posts.Add(post);
            //    context.SaveChanges();
            //}

        }
        private void comboBind()    // Установка DataContext для всего окна
        {
            var item = db.Employees.ToList();
            Employees = item.OrderBy(x => x.PostId).GroupBy(x => x.PostId).Select(g => g.First()).ToList();
            DataContext = Employees;
        }
        private void cbSort_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var post = Convert.ToInt32(cbSort.SelectedValue) ;
            dgEmp.ItemsSource = db.Employees.Where(x => x.PostId == post).ToList();
        }
        private void btnSort_Cancel_Click(object sender, RoutedEventArgs e)    // Отмена сортировки и сброс состояния полей
        {
            cbSort.SelectedItem = null;
            dgEmp.ItemsSource = db.Employees.ToList();
        }
    }
}
