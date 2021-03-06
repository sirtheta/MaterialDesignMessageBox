using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace MaterialDesignMessageBoxSirTheta
{
  public class MessageBoxContent : INotifyPropertyChanged
  {
    public MessageBoxContent(string t_message, MessageType t_type, MessageButtons t_buttons)
    {
      Message = t_message;
      MessageType = t_type;
      MessageButtons = t_buttons;
      ShowMessageBox();
    }

    private string _titleText;
    private string _message;
    private MessageType _messageType;
    private MessageButtons _messageButtons;
    private Visibility _btnOk;
    private Visibility _btnCancel;
    private Visibility _btnYes;
    private Visibility _btnNo;
    private bool? _dialogResult;

    public string TitleText
    {
      get => _titleText;
      set
      {
        _titleText = value;
        OnPropertyChanged();
      }
    }

    public string Message
    {
      get => _message;
      set
      {
        _message = value;
        OnPropertyChanged();
      }
    }

    public MessageType MessageType
    {
      get => _messageType;
      set
      {
        _messageType = value;
        OnPropertyChanged();
      }
    }

    public MessageButtons MessageButtons
    {
      get => _messageButtons;
      set
      {
        _messageButtons = value;
        OnPropertyChanged();
      }
    }

    public Visibility BtnOk
    {
      get => _btnOk;
      set
      {
        _btnOk = value;
        OnPropertyChanged();
      }
    }

    public Visibility BtnCancel
    {
      get => _btnCancel;
      set
      {
        _btnCancel = value;
        OnPropertyChanged();
      }
    }

    public Visibility BtnYes
    {
      get => _btnYes;
      set
      {
        _btnYes = value;
        OnPropertyChanged();
      }
    }

    public Visibility BtnNo
    {
      get => _btnNo;
      set
      {
        _btnNo = value;
        OnPropertyChanged();
      }
    }

    public bool? DialogResult
    {
      get => _dialogResult;
      set
      {
        _dialogResult = value;
        OnPropertyChanged();
      }
    }

    #region ICommands
    public ICommand KeyReturnCommand
    {
      get => new RelayCommand<object>(ExecuteDialogResultTrue);
    }

    public ICommand KeyEscCommand
    {
      get => new RelayCommand<object>(ExecuteDialogResultFalse);
    }

    public ICommand BtnOkClickCommandCommand
    {
      get => new RelayCommand<object>(ExecuteDialogResultTrue);
    }

    public ICommand BtnCancelClickCommandCommand
    {
      get => new RelayCommand<object>(ExecuteDialogResultFalse);
    }

    public ICommand BtnYesClickCommandCommand
    {
      get => new RelayCommand<object>(ExecuteDialogResultTrue);
    }

    public ICommand BtnNoClickCommandCommand
    {
      get => new RelayCommand<object>(ExecuteDialogResultFalse);
    }

    private void ExecuteDialogResultTrue(object Parameter) => DialogResult = true;
    private void ExecuteDialogResultFalse(object Parameter) => DialogResult = false;
    #endregion

    private void ShowMessageBox()
    {
      switch (MessageType)
      {
        case MessageType.Info:
          {
            TitleText = "Info";
          }
          break;
        case MessageType.Confirmation:
          {
            TitleText = "Confirmation";
          }
          break;
        case MessageType.Success:
          {
            TitleText = "Success";
          }
          break;
        case MessageType.Warning:
          {
            TitleText = "Warning";
          }
          break;
        case MessageType.Error:
          {
            TitleText = "Error";
          }
          break;
      }
      switch (MessageButtons)
      {
        case MessageButtons.OkCancel:
          BtnYes = Visibility.Collapsed;
          BtnNo = Visibility.Collapsed;
          break;
        case MessageButtons.YesNo:
          BtnOk = Visibility.Collapsed;
          BtnCancel = Visibility.Collapsed;
          break;
        case MessageButtons.Ok:
          BtnOk = Visibility.Visible;
          BtnCancel = Visibility.Collapsed;
          BtnYes = Visibility.Collapsed;
          BtnNo = Visibility.Collapsed;
          break;
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
