using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Study.Abstractions
{
    interface IView
    {
        string TextBox_Name { get; set; }
        string TextBox_Email { get; set; }

        string TextBox_Error { get; set; }
        void ClearText();
        void Error();
        void Success();

        event EventHandler OnTextChanged;
        event EventHandler DataSave;

    }
}
