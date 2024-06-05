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
using System.Diagnostics;

namespace Lecture13
{
    //Joshua Saetern
    //Computer Programming II
    //Lecture 13 - Rich Text Box ( Advanced )
    //06.05.2024

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //List to hold font sizes
            List<double> fontSizes = new List<double>
            {
                10, 12, 14, 16, 18, 20, 22, 24
            };

            //Connects the comboBox to our fontSize list
            comboBoxFontSize.ItemsSource = fontSizes;

            //Makes fontSize 12 the default 
            comboBoxFontSize.SelectedItem = fontSizes[1];
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //Resets the richTextBox text and styles
            runFormattedText.Text = "";
            runFormattedText.FontWeight = FontWeights.Normal;
            runFormattedText.FontStyle = FontStyles.Normal;
            runFormattedText.TextDecorations = null;

            //Variables to hold user input
            String title = txtBoxUserTitle.Text;
            String text = txtBoxUserText.Text;

            runFormattedText.Text += title + "\n\n";
            runFormattedText.Text += text;

            runFormattedText.FontSize = (double)comboBoxFontSize.SelectedItem;

            //Find if we need to change the style
            if (radioBtnNormal.IsChecked == true)
            {

            }
            else if (radioBtnBold.IsChecked == true)
            {
                runFormattedText.FontWeight = FontWeights.Bold;
            }
            else if (radioBtnItalic.IsChecked == true)
            {
                runFormattedText.FontStyle = FontStyles.Italic;
            }
            else if (radioBtnUnderline.IsChecked == true)
            {
                runFormattedText.TextDecorations = TextDecorations.Underline;
            }
        }
    }
}