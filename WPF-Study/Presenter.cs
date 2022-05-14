using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Study
{
    class Presenter
    {
        private Abstractions.IModel model;
        private Abstractions.IView view;


        public Presenter(Abstractions.IModel model, Abstractions.IView view)
        {
            this.model = model;
            this.view = view;

            this.view.OnTextChanged += Show;
            this.view.DataSave += Save;
        }
        void Save(object sender, EventArgs e)
        {
            if (model.Check(view.TextBox_Name, view.TextBox_Email))
            {
                model.SaveIn(view.TextBox_Name, view.TextBox_Email);
                view.Success();
            }
            else
                view.Error();
            Show(sender, e);
        }
        void Show(object sender, EventArgs e)
        {
            model.ShowIn(view.TextBox_Error);
        }
    }
}
