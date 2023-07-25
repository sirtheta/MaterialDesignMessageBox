using MaterialDesignMessageBoxSirTheta.Definitions;
using MaterialDesignMessageBoxSirTheta.ViewModel;
using System.Windows;
using System.Windows.Input;

namespace MaterialDesignMessageBoxSirTheta
{

    public partial class MaterialDesignMessageBoxView : Window
    {
        public MaterialDesignMessageBoxView(string t_message, MessageType t_type, MessageButtons t_buttons, string t_customTrue, string t_customFalse)
        {
            InitializeComponent();
            DataContext = new MessageBoxViewModel(t_message, t_type, t_buttons, t_customTrue, t_customFalse);
        }

        // handling for the esc key command, if esc key is pressed, the MaterialDesignMessageBoxResult will be None
        private void CloseCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }
    }
}