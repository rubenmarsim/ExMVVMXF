using exMVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace exMVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        //private int _counter;
        //private DelegateCommand _myCommand;

        //void counterCommandExecute()
        //{
        //    _counter++;
        //    RaisePropertyChanged("MyMessage");
        //}
        public MainModel mainModel { get; set; }

        public MainViewModel()
        {
            mainModel = new MainModel
            {
                Title = "Titulo de prueba",
                Duration = 3,
                State = "EU",
            };

            //_counter = 0;
        }

        //public string MyMessage
        //{
        //    get { return string.Format("{0} times", _counter); }
        //}
        //public ICommand MyCommand
        //{
        //    get { return _myCommand = _myCommand ?? new DelegateCommand(counterCommandExecute); }
        //}
    }
}
