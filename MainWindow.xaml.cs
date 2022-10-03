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

namespace Tema2_TamanyoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GrRadioButton.Tag = 72;
            MdRadioButton.Tag = 48;
            SmRadioButton.Tag = 36;
            SmRadioButton.IsChecked = true;

        }

        private void TamanyoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            mainTextTextBlock.FontSize = (int)rd.Tag;
        }
    }
}
