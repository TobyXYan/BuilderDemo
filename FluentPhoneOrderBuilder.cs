using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDemo
{
    public class FluentPhoneOrderBuilder : IPurchaseOrderBuilder
    {
        private string _type;
        private DateTime _createdOn = DateTime.Now;
        private string _companyName;
        private string _address;
        private DateTime _requestedBy;
        private Vendor _vendor;
        private List<PurchaseItem> _items;

        
        IPurchaseOrderBuilder IPurchaseOrderBuilder.AtAddress(string address)
        {
            _address = address;
            return this;
        }

        public PurchaseOrder BuildPurchaseOrder()
        {
            return new PurchaseOrder(_type)
            {
                CompanyName = _companyName,
                CompanyAddress = _address,
                CreatedOn = _createdOn,
                RequestedBy = _requestedBy,
                Vendor = _vendor,
                Items = _items
            };
        }

        IPurchaseOrderBuilder IPurchaseOrderBuilder.ForCompany(string companyName)
        {
            _companyName = companyName;
            return this;
        }

        IPurchaseOrderBuilder IPurchaseOrderBuilder.ForItems(List<PurchaseItem> items)
        {
            _items = items;
            return this;
        }

        IPurchaseOrderBuilder IPurchaseOrderBuilder.FromVendor(Vendor vendor)
        {
            _vendor = vendor;
            return this;
        }

        IPurchaseOrderBuilder IPurchaseOrderBuilder.RequestedBy(DateTime date)
        {
            _requestedBy = date;
            return this;
        }

        IPurchaseOrderBuilder IPurchaseOrderBuilder.WithType(string type)
        {
            _type = type;
            return this;
        }
    }
}
