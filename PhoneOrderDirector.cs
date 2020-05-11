using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDemo
{
    public class PhoneOrderDirector : IDirector
    {
        public PurchaseOrder CreateOrder(IPurchaseOrderBuilder orderBuilder)
        {
            var order = orderBuilder.WithType("Huawei")
                .ForCompany("KLa")
                .AtAddress("Hongyuan Ba Cun")
                .FromVendor(new Vendor())
                .RequestedBy(DateTime.Now)
                .BuildPurchaseOrder();
            return order;
        }
    }
}
