using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace TestTap.Shared.Data
{
    public class TestModel: BindingModel
    {
        private int _id;
        public DelegateCommand<TestModel> UpdateCommand { get; set; }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                EvRaisePropertyChanged("Id");
            }
        }
    }
}
