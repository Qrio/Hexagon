using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hexagon
{
    public class VendorModel : ObservableObject
    {
        #region Fields

        private string _vendorID;
        private string _vendorName;
        private string _addressLine1;
        private string _addressLine2;
        private string _city;
        private string _state;
        private int _postalCode;
        private long _primaryPhone;
        private long _mobilePhone;
        private string _email;
        private string _website;
        private string _remarks;
        private bool _isActive;
        private string _createUserID;
        private DateTime _createTimestamp;
        private string _updateUserID;
        private DateTime _updateTimestamp;

        #endregion // Fields

        #region Properties

        public string VendorID
        {
            get { return _vendorID; }
            set
            {
                if (value != _vendorID)
                {
                    _vendorID = value;
                    OnPropertyChanged("VendorID");
                }
            }
        }

        public string VendorName
        {
            get { return _vendorName; }
            set
            {
                if (value != _vendorName)
                {
                    _vendorName = value;
                    OnPropertyChanged("VendorName");
                }
            }
        }

        public string AddressLine1
        {
            get { return _addressLine1; }
            set
            {
                if (value != _addressLine1)
                {
                    _addressLine1 = value;
                    OnPropertyChanged("AddressLine1");
                }
            }
        }
        public string AddressLine2
        {
            get { return _addressLine2; }
            set
            {
                if (value != _addressLine2)
                {
                    _addressLine2 = value;
                    OnPropertyChanged("AddressLine2");
                }
            }
        }

        public string FullAddress
        {
            get { return string.Concat(_addressLine1,  _addressLine2,  _city,  _state,  _postalCode);
            //return string.Concat(_addressLine1, ", ", _addressLine2, ", ", _city, ", ", _state, " - ", _postalCode);
            }
            set
            {
                // Update this later
                _addressLine1 = value;
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                if (value != _city)
                {
                    _city = value;
                    OnPropertyChanged("City");
                }
            }
        }
        public string State
        {
            get { return _state; }
            set
            {
                if (value != _state)
                {
                    _state = value;
                    OnPropertyChanged("State");
                }
            }
        }
        public int PostalCode
        {
            get { return _postalCode; }
            set
            {
                if (value != _postalCode)
                {
                    _postalCode = value;
                    OnPropertyChanged("PostalCode");
                }
            }
        }
        public long PrimaryPhone
        {
            get { return _primaryPhone; }
            set
            {
                if (value != _primaryPhone)
                {
                    _primaryPhone = value;
                    OnPropertyChanged("PrimaryPhone");
                }
            }
        }
        public long MobilePhone
        {
            get { return _mobilePhone; }
            set
            {
                if (value != _mobilePhone)
                {
                    _mobilePhone = value;
                    OnPropertyChanged("MobilePhone");
                }
            }
        }
        public string EMail
        {
            get { return _email; }
            set
            {
                if (value != _email)
                {
                    _email = value;
                    OnPropertyChanged("EMail");
                }
            }
        }
        public string Website
        {
            get { return _website; }
            set
            {
                if (value != _website)
                {
                    _website = value;
                    OnPropertyChanged("Website");
                }
            }
        }
        public string Remarks
        {
            get { return _remarks; }
            set
            {
                if (value != _remarks)
                {
                    _remarks = value;
                    OnPropertyChanged("Remarks");
                }
            }
        }
        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                if (value != _isActive)
                {
                    _isActive = value;
                    OnPropertyChanged("IsActive");
                }
            }
        }
        #endregion // Properties
    }
}
