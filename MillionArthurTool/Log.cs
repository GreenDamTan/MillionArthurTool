namespace MillionArthurTool
{
    using System;
    using System.ComponentModel;
    using System.IO;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Threading;

    internal sealed class Log : INotifyPropertyChanged
    {
        private string _Text = string.Empty;
        public static readonly Log instance = new Log();
        private StreamWriter log = new StreamWriter("action_log.txt", true);
        private const string LogPath = "action_log.txt";
        private PropertyChangedEventHandler _PropertyChanged;

        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                PropertyChangedEventHandler handler2;
                PropertyChangedEventHandler propertyChanged = this._PropertyChanged;
                do
                {
                    handler2 = propertyChanged;
                    PropertyChangedEventHandler handler3 = (PropertyChangedEventHandler) Delegate.Combine(handler2, value);
                    propertyChanged = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this._PropertyChanged, handler3, handler2);
                }
                while (propertyChanged != handler2);
            }
            remove
            {
                PropertyChangedEventHandler handler2;
                PropertyChangedEventHandler propertyChanged = this._PropertyChanged;
                do
                {
                    handler2 = propertyChanged;
                    PropertyChangedEventHandler handler3 = (PropertyChangedEventHandler) Delegate.Remove(handler2, value);
                    propertyChanged = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this._PropertyChanged, handler3, handler2);
                }
                while (propertyChanged != handler2);
            }
        }

        private Log()
        {
        }

        public void NotifyPropertyChanged<T>(Expression<Func<T>> property)
        {
            if (this._PropertyChanged != null)
            {
                MemberExpression body = property.Body as MemberExpression;
                if (body != null)
                {
                    this._PropertyChanged(this, new PropertyChangedEventArgs(body.Member.Name));
                }
            }
        }

        public void WriteInfo(string message)
        {
            this.WriteInfo("{0}", new object[] { message });
        }

        public void WriteInfo(string format, params object[] obj)
        {
            try
            {
                this.log.WriteLine(string.Format("[{0}] {1}", DateTime.Now, string.Format(format, obj)));
                this.log.Flush();
            }
            catch
            {
            }
        }

        public string Text
        {
            get
            {
                return this._Text;
            }
            set
            {
                if (!(string.IsNullOrEmpty(value) && !(value != this._Text)))
                {
                    this._Text = value;
                    Type objType = typeof(Log);
                    MethodInfo getTextInfo = objType.GetMethod("get_Text");
                    this.NotifyPropertyChanged<string>(Expression.Lambda<Func<string>>
                        (Expression.Property(Expression.Constant(this, typeof(Log)),
                        getTextInfo), new ParameterExpression[0]));
                }
            }
        }
        public static MethodInfo methodof(Expression<Action> expression)
        {
            MethodCallExpression body = (MethodCallExpression)expression.Body;
            return body.Method;
        }
    }
}

