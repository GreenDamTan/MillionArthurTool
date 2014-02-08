namespace MillionArthurTool
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    internal sealed class BingdingText : Control
    {
        private string _str;

        [Bindable(true), Localizable(true)]
        public string str
        {
            get
            {
                return this._str;
            }
            set
            {
                if (!(string.IsNullOrEmpty(value) && !(value != this._str)))
                {
                    this._str = value;
                }
            }
        }
    }
}

