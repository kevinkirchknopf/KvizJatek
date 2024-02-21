using KvizJatek.Controlls;
using KvizJatek.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KvizJatek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
 
    public partial class MainWindow : Window
    {
        static KvizContext _context;
        public MainWindow()
        {
            _context = new KvizContext();
            _context.Database.EnsureCreated();
            InitializeComponent();



        }

        private void btnKerdesFelvitel_Click(object sender, RoutedEventArgs e)
        {
         
        }
    }
}