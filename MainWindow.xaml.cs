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

namespace laba_3_270925
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Пример текста")
            {
                textBox.Text = ""; // Очищаем текст, чтобы он исчез
            }
            else
            {
                textBox.Text = "Пример текста";
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var zd_4 = new Window1();
            zd_4.Show();
            this.Close();
        }
    }
}