using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    public class SelEventHandler : EventArgs
    {
        public IOrderItem item;
    }
}
