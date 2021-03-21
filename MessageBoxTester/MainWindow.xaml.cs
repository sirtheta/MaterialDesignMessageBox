using System.Windows;
using MaterialDesignMessageBoxSirTheta;

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

    public static bool ShowMessageBox(string messageStr, MessageType type, MessageButtons buttons)
    {
      return (bool)new MaterialDesignMessageBox(messageStr, type, buttons).ShowDialog();
    }

    private void ButtonOk_Click(object sender, RoutedEventArgs e)
    {
      if (ShowMessageBox("Button ok clicked", MessageType.Info, MessageButtons.Ok))
      {
        txtBox.Text = "true";
      }
    }

    private void ButtonOkCancel_Click(object sender, RoutedEventArgs e)
    {
      if (ShowMessageBox("Button Yes/No clicked", MessageType.Confirmation, MessageButtons.YesNo))
      {
        txtBox.Text = "true";
      }
      else
      {
        txtBox.Text = "false";
      }
    }

    private void ButtonYesNo_Click(object sender, RoutedEventArgs e)
    {
      if(ShowMessageBox("Button ok/cancel clicked", MessageType.Warning, MessageButtons.OkCancel))
      {
        txtBox.Text = "true";
      }
      else
      {
        txtBox.Text = "false";
      }
    }

    private void ButtonSuccess_Click(object sender, RoutedEventArgs e)
    {
      if (ShowMessageBox("Button Success clicked", MessageType.Success, MessageButtons.Ok))
      {
        txtBox.Text = "true";
      }
      else
      {
        txtBox.Text = "false";
      }
    }
    private void ButtonError_Click(object sender, RoutedEventArgs e)
    {
      if (ShowMessageBox("Button Error clicked", MessageType.Error, MessageButtons.Ok))
      {
        txtBox.Text = "true";
      }
      else
      {
        txtBox.Text = "false";
      }
    }
  }
}
