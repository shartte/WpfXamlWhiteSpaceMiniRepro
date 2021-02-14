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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SpacePreserveProblem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var compiledTextBlock = Content as TextBlock;

            var dynamicSelfClosing = (TextBlock) XamlReader.Parse("<TextBlock xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xml:space='preserve'> <Run/> </TextBlock>");
            var dynamicCosing = (TextBlock) XamlReader.Parse("<TextBlock xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xml:space='preserve'> <Run></Run> </TextBlock>");

            MessageBox.Show(
                $"Compiled: {compiledTextBlock.Inlines.Count}\n" +
                $"Dynamic Self-Closing: {dynamicSelfClosing.Inlines.Count}\n" +
                $"Dynamic Normally Closing:{dynamicCosing.Inlines.Count}");
            Close();
        }
    }
}