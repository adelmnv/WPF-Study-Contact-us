using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Study.Abstractions
{
    interface IModel
    {
        void SaveIn(string message1, string message2 );
        void ShowIn(string message);
        bool Check(string message1, string message2);
    }
}
