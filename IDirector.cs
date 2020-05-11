using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDemo
{
    public interface IDirector
    {
        PurchaseOrder CreateOrder(IPurchaseOrderBuilder orderBuilder);
    }
}
