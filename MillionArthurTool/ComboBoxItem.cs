﻿namespace MillionArthurTool
{
    using System;

    public class ComboBoxItem
    {
        private string _text;
        private object _value;

        public override string ToString()
        {
            return this._text;
        }

        public string Text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }

        public object Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}

