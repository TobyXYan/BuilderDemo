using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDemo
{
    public class BookOrderDirector : IDirector
    {
        public PurchaseOrder CreateOrder(IPurchaseOrderBuilder orderBuilder)
        {
            //var order = orderBuilder.WithType("Fairy Tale")
            //    .ForCompany("KLa")
            //    .AtAddress("Lane 887")
            //    .FromVendor(new Vendor())
            //    .RequestedBy(DateTime.Now)
            //    .BuildPurchaseOrder();

            orderBuilder.WithType("Fairy Tale")
                .ForCompany("KLa")
                .AtAddress("Lane 887")
                .FromVendor(new Vendor())
                .RequestedBy(DateTime.Now)
                .BuildPurchaseOrder();
            var order = new PurchaseOrder("");
            if (orderBuilder is FluentBookOrderBuilder bookOrderBuilder)
            {
                order = bookOrderBuilder;
            }
            return order;
        }
    }
}
