using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hexagon
{
    class NewVendorViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get { return "New Vendor"; }
        }
    }
}
