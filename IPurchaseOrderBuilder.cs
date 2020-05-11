using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDemo
{
    public interface IPurchaseOrderBuilder
    {
        IPurchaseOrderBuilder WithType(string type);
        IPurchaseOrderBuilder ForCompany(string companyName);
        IPurchaseOrderBuilder AtAddress(string address);
        IPurchaseOrderBuilder RequestedBy(DateTime date);
        IPurchaseOrderBuilder FromVendor(Vendor vendor);
        IPurchaseOrderBuilder ForItems(List<PurchaseItem> items);

        PurchaseOrder BuildPurchaseOrder();
    }
}
