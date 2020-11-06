using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using TestTap.Shared.Data;

namespace TestTap.Shared.ViewModel
{
    public class TestViewModel : BindingModel
    {
        private ObservableCollection<TestModel> _TestList= new ObservableCollection<TestModel>();
       
        public ObservableCollection<TestModel> TestList
        {
            get { return _TestList; }
            set
            {
                _TestList = value;
                EvRaisePropertyChanged("TestList");
            }
        }
        private int _TestValue;
        public int TestValue
        {
            get
            {
                return _TestValue;
            }
            set
            {
                _TestValue = value;
                EvRaisePropertyChanged("TestValue");
            }

        }
        public TestViewModel()
        {
            for (int i = 0; i < 100; i++)
            {
                TestList.Add(new TestModel 
                { Id = i ,
                    UpdateCommand = new DelegateCommand<TestModel>(OnUpdateTarea),
                    DeleteCommand = new DelegateCommand<TestModel>(OnDeleteTarea)


                });
            }
           
        }

        private void OnUpdateTarea(TestModel obj)
        {
            TestValue = TestValue + 1;
        }
        private void OnDeleteTarea(TestModel obj)
        {
            TestValue = TestValue -1;
        }
    }
}
