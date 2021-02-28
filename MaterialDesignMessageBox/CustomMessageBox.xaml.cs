using System.Windows;
using System.Windows.Input;

namespace MaterialDesignMessageBox
{

  public partial class CustomMessageBox : Window
  {
    public CustomMessageBox(string Message, MessageType Type, MessageButtons Buttons)
    {
      InitializeComponent();
      txtMessage.Text = Message;
      switch (Type)
      {

        case MessageType.Info:
          {
            txtTitle.Text = "Info";
          }
          break;
        case MessageType.Confirmation:
          {
            txtTitle.Text = "Confirmation";
          }
          break;
        case MessageType.Success:
          {
            txtTitle.Text = "Success";
          }
          break;
        case MessageType.Warning:
          {
            txtTitle.Text = "Warning";
          }
          break;
        case MessageType.Error:
          {
            txtTitle.Text = "Error";
          }
          break;
      }
      switch (Buttons)
      {
        case MessageButtons.OkCancel:
          btnYes.Visibility = Visibility.Collapsed;
          btnNo.Visibility = Visibility.Collapsed;
          break;
        case MessageButtons.YesNo:
          btnOk.Visibility = Visibility.Collapsed;
          btnCancel.Visibility = Visibility.Collapsed;
          break;
        case MessageButtons.Ok:
          btnOk.Visibility = Visibility.Visible;
          btnCancel.Visibility = Visibility.Collapsed;
          btnYes.Visibility = Visibility.Collapsed;
          btnNo.Visibility = Visibility.Collapsed;
          break;
      }
    }

    private void Button_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.Key == Key.Enter)
      {
        DialogResult = true;
        Close();
      }
    }

    private void BtnYes_Click(object sender, RoutedEventArgs e)
    {
      DialogResult = true;
      Close();
    }

    private void BtnCancel_Click(object sender, RoutedEventArgs e)
    {
      DialogResult = false;
      Close();
    }

    private void BtnOk_Click(object sender, RoutedEventArgs e)
    {
      DialogResult = true;
      Close();
    }

    private void BtnNo_Click(object sender, RoutedEventArgs e)
    {
      DialogResult = false;
      Close();
    }

    private void BtnClose_Click(object sender, RoutedEventArgs e)
    {
      DialogResult = false;
      Close();
    }
  }
  public enum MessageType
  {
    Info,
    Confirmation,
    Success,
    Warning,
    Error,
  }
  public enum MessageButtons
  {
    OkCancel,
    YesNo,
    Ok,
  }
}