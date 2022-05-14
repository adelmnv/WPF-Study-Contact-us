using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Study
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, Abstractions.IView
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public string TextBox_Name { get => TBname.Text; set => TBname.Text = value; }
        public string TextBox_Email { get => TBemail.Text; set => TBemail.Text = value; }

        public string TextBox_Error { get => TBerror.Text; set => TBerror.Text = value; }

        public event EventHandler OnTextChanged;


        public event EventHandler DataSave;

        public void Error()
        {
            TBerror.Text = "Error";
            TBerror.Foreground = Brushes.Red;
        }

        public void Success()
        {
            TBerror.Text = "Success";
            TBerror.Foreground = Brushes.Green;
            ClearText();
        }
        public void ClearText()
        {
            TBname.Text = "";
            TBemail.Text = "";
        }

        private void tbxValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (OnTextChanged != null)
            {
                OnTextChanged.Invoke(this, e);
            }
        }

        private void bSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (DataSave != null)
            {
               DataSave.Invoke(this, e);
            }
        }
    }
}
