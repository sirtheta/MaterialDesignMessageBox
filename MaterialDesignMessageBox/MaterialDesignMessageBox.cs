using MaterialDesignMessageBoxSirTheta.Definitions;
using MaterialDesignMessageBoxSirTheta.ViewModel;

namespace MaterialDesignMessageBoxSirTheta
{
    public static class MaterialDesignMessageBox
    {
        public static MaterialDesignMessageBoxResult Show(string t_message, MessageType t_type, MessageButtons t_buttons, string t_customTrue = "", string t_customFalse = "")
        {
            MaterialDesignMessageBoxView materialDesignMessageBoxView = new(t_message, t_type, t_buttons, t_customTrue, t_customFalse);
            materialDesignMessageBoxView.ShowDialog();

            var viewModel = materialDesignMessageBoxView.DataContext as MessageBoxViewModel;
            return viewModel?.Result ?? MaterialDesignMessageBoxResult.None;
        }
    }
}
