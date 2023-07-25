using MaterialDesignMessageBoxSirTheta.Definitions;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace MaterialDesignMessageBoxSirTheta.ViewModel
{
    public class MessageBoxViewModel : INotifyPropertyChanged
    {
        internal MessageBoxViewModel(string t_message, MessageType t_type, MessageButtons t_buttons, string t_customTrue, string t_customFalse)
        {
            Message = t_message;
            MessageType = t_type;
            MessageButtons = t_buttons;
            BtnCustomTextTrue = t_customTrue;
            BtnCustomTextFalse = t_customFalse;
            SetMessageType();
            SetButtonVisibility();
        }

        private string _titleText;
        private string _message;
        private string _btnCustomTextTrue;
        private string _btnCustomTextFalse;
        private MessageType _messageType;
        private MessageButtons _messageButtons;
        private Visibility _btnOk = Visibility.Collapsed;
        private Visibility _btnCancel = Visibility.Collapsed;
        private Visibility _btnYes = Visibility.Collapsed;
        private Visibility _btnNo = Visibility.Collapsed;
        private Visibility _btnCustomTrue = Visibility.Collapsed;
        private Visibility _btnCustomFalse = Visibility.Collapsed;
        private MaterialDesignMessageBoxResult _result;

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
        public string BtnCustomTextTrue
        {
            get => _btnCustomTextTrue;
            set
            {
                _btnCustomTextTrue = value;
                OnPropertyChanged();
            }
        }
        public string BtnCustomTextFalse
        {
            get => _btnCustomTextFalse;
            set
            {
                _btnCustomTextFalse = value;
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

        public Visibility BtnCustomTrue
        {
            get => _btnCustomTrue;
            set
            {
                _btnCustomTrue = value;
                OnPropertyChanged();
            }
        }

        public Visibility BtnCustomFalse
        {
            get => _btnCustomFalse;
            set
            {
                _btnCustomFalse = value;
                OnPropertyChanged();
            }
        }
        public MaterialDesignMessageBoxResult Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }

        #region ICommands
        public ICommand KeyReturnCommand
        {
            get
            {
                if (BtnOk == Visibility.Visible)
                {
                    return new RelayCommand<object>(ExecuteResultOk);
                }
                else if (BtnYes == Visibility.Visible || BtnCustomTrue == Visibility.Visible)
                {
                    return new RelayCommand<object>(ExecuteResultYes);
                }
                return null;   
            }
        }

        public ICommand BtnOkClickCommandCommand
        {
            get => new RelayCommand<object>(ExecuteResultOk);
        }

        public ICommand BtnCancelClickCommandCommand
        {
            get => new RelayCommand<object>(ExecuteResultCancel);
        }

        public ICommand BtnYesClickCommandCommand
        {
            get => new RelayCommand<object>(ExecuteResultYes);
        }

        public ICommand BtnNoClickCommandCommand
        {
            get => new RelayCommand<object>(ExecuteResultNo);
        }

        private void ExecuteResultOk(object obj) => Result = MaterialDesignMessageBoxResult.OK;
        private void ExecuteResultCancel(object obj) => Result = MaterialDesignMessageBoxResult.Cancel;
        private void ExecuteResultYes(object obj) => Result = MaterialDesignMessageBoxResult.Yes;
        private void ExecuteResultNo(object obj) => Result = MaterialDesignMessageBoxResult.No;
        #endregion

        private void SetMessageType()
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
                case MessageType.Question:
                    {
                        TitleText = "Question";
                    }
                    break;
            }
        }

        private void SetButtonVisibility()
        {
            switch (MessageButtons)
            {
                case MessageButtons.OkCancel:
                    {
                        BtnOk = Visibility.Visible;
                        BtnCancel = Visibility.Visible;
                    }
                    break;
                case MessageButtons.YesNo:
                    {
                        BtnYes = Visibility.Visible;
                        BtnNo = Visibility.Visible;
                    }
                    break;
                case MessageButtons.Ok:
                    {
                        BtnOk = Visibility.Visible;
                    }
                    break;
                case MessageButtons.Custom:
                    {
                        BtnCustomTrue = Visibility.Visible;
                        BtnCustomFalse = Visibility.Visible;
                    }
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
