using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;

namespace Hexagon
{
    public class VendorsViewModel:ObservableObject, IPageViewModel
    {
        #region Fields

        private string _vendorID;
        private VendorModel _currentVendor;
        private ICommand _getVendorCommand;
        private ICommand _saveVendorCommand;

        #endregion

        #region Public Properties/Commands

        public string Name
        {
            get { return "Vendors"; }
        }

        public VendorModel CurrentVendor
        {
            get { return _currentVendor; }
            set
            {
                if (value != _currentVendor)
                {
                    _currentVendor = value;
                    OnPropertyChanged("CurrentVendor");
                }
            }
        }
        public ICommand SaveVendorCommand
        {
            get
            {
                if (_saveVendorCommand == null)
                {
                    _saveVendorCommand = new RelayCommand(
                        param => SaveVendor(),
                        param => (CurrentVendor != null));
                }
                return _saveVendorCommand;
            }
        }

        public ICommand GetVendorCommand
        {
            get
            {
                if(_getVendorCommand == null)
                {
                    _getVendorCommand = new RelayCommand(
                        param => GetVendor(),
                        param => VendorID != null);
                }
                return _getVendorCommand;
            }
        }

        public string VendorID
        {
            get
            {
                return _vendorID;
            }
            set
            {
                if (value != _vendorID)
                {
                    _vendorID = value;
                    OnPropertyChanged("VendorID");
                }
            }
        }
        #endregion // Public Properties/Commands

        #region Private Helpers

        private void GetVendor()
        {
            // You should get the product from the database
            // but for now we'll just return a new object
            VendorModel v = new VendorModel();
            v.VendorID = VendorID;
            v.VendorName = "Rony Electronics";
            v.AddressLine1 = "MG Road";
            v.AddressLine2 = "";
            v.City = "Ernakulam";
            v.State = "KL";
            v.PostalCode = 34532;
            v.PrimaryPhone = 0484212121;

            CurrentVendor = v;
        }

        private void SaveVendor()
        {
            // You would implement your Product save here
            MessageBox.Show (CurrentVendor.VendorName);
        }

        #endregion
    }
}
