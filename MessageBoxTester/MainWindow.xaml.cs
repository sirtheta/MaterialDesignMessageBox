using System.Windows;
using MaterialDesignMessageBoxSirTheta;
using MaterialDesignMessageBoxSirTheta.Definitions;

namespace MessageBoxTester
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

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = MaterialDesignMessageBox.Show("Button ok clicked", MessageType.Info, MessageButtons.Ok).ToString();
        }

        private void ButtonOkCancel_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = MaterialDesignMessageBox.Show("Button Yes/No clicked", MessageType.Confirmation, MessageButtons.YesNo).ToString();
        }

        private void ButtonYesNo_Click(object sender, RoutedEventArgs e)
        {

            txtBox.Text = MaterialDesignMessageBox.Show("Button ok/cancel clicked", MessageType.Warning, MessageButtons.OkCancel).ToString();
        }

        private void ButtonSuccess_Click(object sender, RoutedEventArgs e)
        {

            txtBox.Text = MaterialDesignMessageBox.Show("Button Success clicked", MessageType.Success, MessageButtons.Ok).ToString();

        }
        private void ButtonError_Click(object sender, RoutedEventArgs e)
        {

            txtBox.Text = MaterialDesignMessageBox.Show("Button Error clicked", MessageType.Error, MessageButtons.Ok).ToString();

        }

        private void ButtonCustom_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = MaterialDesignMessageBox.Show("Button custom clicked", MessageType.Question, MessageButtons.Custom, "do that little thing inside your head and spin around", "do this little thing inside your head and spin around").ToString();
        }
    }
}
