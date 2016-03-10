using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChangeView.Content
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : UserControl
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UniformGrid ct =   UIHelper.FindChild<UniformGrid>(Application.Current.MainWindow, "bodyContainer");

            if(ct != null)
            {
                ct.Children.Clear();
                ct.Children.Add(GetPage1());
            }

        }

        private UIElement GetPage1()
        {
            return new Page1() { Margin=new Thickness(5) };
        }
    }
}
