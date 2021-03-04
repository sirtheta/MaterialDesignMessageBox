using System.Windows;

namespace MaterialDesignMessageBoxSirTheta
{

  public partial class MaterialDesignMessageBox : Window
  {
    public MaterialDesignMessageBox(string message, MessageType type, MessageButtons buttons)
    {
      InitializeComponent();
      DataContext = new MessageBoxContent(message, type, buttons);
    }
  }
}