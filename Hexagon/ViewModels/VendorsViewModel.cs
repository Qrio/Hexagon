using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;
using System.Collections.ObjectModel;

namespace Hexagon
{
    public class VendorsViewModel:ObservableObject, IPageViewModel
    {
        #region Fields

        private string _vendorID;
        private VendorModel _currentVendor;
        private ObservableCollection<VendorModel> _allVendors;
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

        public ObservableCollection<VendorModel> AllVendors
        {
            get
            {
                _allVendors = new ObservableCollection<VendorModel>();
                _allVendors.Add(new VendorModel() { VendorID = "1", VendorName = "Rony Electronics", AddressLine1 = "MG Road", City = "Ernakulam", PostalCode = 667458, EMail = "rony@gmail.com", State="KL", IsActive=true });
                _allVendors.Add(new VendorModel() { VendorID = "2", VendorName = "ABC Electronics", AddressLine1 = "Kazhakoottam", City = "Thiruvananthapuram", PostalCode = 619078, EMail = "abc_electronics@gmail.com", State = "KL", IsActive = true });
                _allVendors.Add(new VendorModel() { VendorID = "3", VendorName = "Thiru Electronics", AddressLine1 = "Cathedral Road", City = "Chennai", PostalCode = 600021, EMail = "thiru@thiruelectronics.com", State = "TN", IsActive = true, PrimaryPhone=914423456787 });
                _allVendors.Add(new VendorModel() { VendorID = "4", VendorName = "Kundan Electricals", AddressLine1 = "Old Mahabalipuram Road", AddressLine2="#456", City = "Chennai", PostalCode = 600043, EMail = "kundan@yahoo.com", State = "TN", PrimaryPhone=9144567893456, IsActive = false });
                if (_allVendors != null && _allVendors.Count > 0)
                {
                    return _allVendors;
                }
                else
                    return null;
            }
            set { }
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
