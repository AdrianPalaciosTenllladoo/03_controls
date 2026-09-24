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

namespace _03controls
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid elMeuGrid = new Grid();
            this.Content = elMeuGrid;

            Button btn = new Button();

            btn.Width = 150;
            btn.Height = 50;
            btn.FontSize = 15;
            
            WrapPanel elMeuWrap = new WrapPanel();

            TextBlock txt1 = new TextBlock();
            txt1.Text = "Hola";
            txt1.Foreground = Brushes.Purple;
            elMeuWrap.Children.Add(txt1);

            TextBlock txt2 = new TextBlock();
            txt2.Text = "Adeu";
            txt2.Foreground = Brushes.Yellow;
            elMeuWrap.Children.Add(txt2);

            TextBlock txt3 = new TextBlock();
            txt3.Text = "Andreu";
            txt3.Foreground = Brushes.Green;
            elMeuWrap.Children.Add(txt3);


            btn.Content = elMeuWrap;
            elMeuGrid.Children.Add(btn);
            


        }
        
    }
}
