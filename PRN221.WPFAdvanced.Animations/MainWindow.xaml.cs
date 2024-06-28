using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PRN221.WPFAdvanced.Animations
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(WidthTextBox.Text, out double newWidth))
            {
                // Get the storyboard from resources
                Storyboard? storyboard = this.Resources["WidthAnimationStoryboard"] as Storyboard;
                if (storyboard != null)
                {
                    // Stop the current storyboard
                    storyboard.Stop(this);

                    // Update the DoubleAnimation To value
                    DoubleAnimation? animation = storyboard.Children[0] as DoubleAnimation;
                    if (animation != null)
                    {
                        animation.To = newWidth;
                    }

                    // Start the storyboard
                    storyboard.Begin(this, true);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}