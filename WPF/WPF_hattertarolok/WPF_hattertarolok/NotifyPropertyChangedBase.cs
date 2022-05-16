using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace WPF_hattertarolok
{
    public class NotifyPropertyChangedBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void onPropertyChanged(string tulajdonsagnev)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(tulajdonsagnev));
        }
    }
}
