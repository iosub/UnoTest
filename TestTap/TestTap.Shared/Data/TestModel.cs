using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace TestTap.Shared.Data
{
    public enum EditModeEnum : ushort
    {
        None = 0,
        Edit = 1,
        Add = 2,
        Delete = 3,
        View = 4,
        StartSesion = 5,
        StopSesion = 6

    }
    public class TestModel: BindingModel
    {
        private int _id;
        public DelegateCommand<TestModel> UpdateCommand { get; set; }
        public DelegateCommand<TestModel> DeleteCommand { get; set; }
        private EditModeEnum _editMode = EditModeEnum.None;
        public EditModeEnum EvEditMode
        {
            get
            {
                //if (this != null && Core.EvNavigationHelper.EvSelectedSession != null)
                //    {
                //    if (this.IdSesion == Core.EvNavigationHelper.EvSelectedSession.IdSesion)
                //        {
                //        return true;
                //        }
                //    else
                //        return false;
                //    }
                //else
                //    return false;
                return _editMode;

            }
            set
            {
                _editMode = value;
                this.EvRaisePropertyChanged("EvEditMode");
            }
        }
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
