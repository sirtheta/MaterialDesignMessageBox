using MaterialDesignMessageBoxSirTheta.Definitions;
using System.Windows;

namespace MaterialDesignMessageBoxSirTheta
{
    public static class DialogCloser
    {
        public static readonly DependencyProperty DialogResultProperty =
            DependencyProperty.RegisterAttached(
                "DialogResult",
                typeof(MaterialDesignMessageBoxResult),
                typeof(DialogCloser),
                new PropertyMetadata(DialogResultChanged));

        private static void DialogResultChanged(
            DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            if (d is Window window)
            {
                if (e.NewValue is MaterialDesignMessageBoxResult result)
                {
                    SetDialogResult(window, result);
                }
            }
        }

        public static void SetDialogResult(Window target, MaterialDesignMessageBoxResult value)
        {
            target.SetValue(DialogResultProperty, value);
            target.Close();
        }
    }
}
