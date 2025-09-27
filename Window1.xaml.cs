using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Ink;

namespace laba_3_270925
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click_close(object sender, RoutedEventArgs e)
        {
            var zd_2_3 = new MainWindow();
            zd_2_3.Show();
            this.Close();
        }
        private void ClearCanvas_Click(object sender, RoutedEventArgs e)
        {
            drawingCanvas.Strokes.Clear();
        }
    }

    public class EditingModeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is InkCanvasEditingMode mode)
            {
                switch (mode)
                {
                    case InkCanvasEditingMode.Ink: return "Рисование";
                    case InkCanvasEditingMode.EraseByPoint: return "Редактирование";
                    default: return mode.ToString();
                }
            }
            return value?.ToString() ?? string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
