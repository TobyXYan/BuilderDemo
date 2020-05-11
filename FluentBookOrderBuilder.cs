using System;
using System.Collections.Generic;

namespace BuilderDemo
{
    public class FluentBookOrderBuilder : IPurchaseOrderBuilder
    {
        private string             _type;
        private DateTime           _createdOn = DateTime.Now;
        private string             _companyName;
        private string             _address;
        private DateTime           _requestedBy;
        private Vendor             _vendor;
        private List<PurchaseItem> _items;

        public IPurchaseOrderBuilder AtAddress(string address)
        {
            _address = address;
            return this;
        }

        public PurchaseOrder BuildPurchaseOrder()
        {
            return new PurchaseOrder(_type)
            {
                CompanyName    = _companyName,
                CompanyAddress = _address,
                CreatedOn      = _createdOn,
                RequestedBy    = _requestedBy,
                Vendor         = _vendor,
                Items          = _items
            };
        }

        public IPurchaseOrderBuilder ForCompany(string companyName)
        {
            _companyName = companyName;
            return this;
        }

        public IPurchaseOrderBuilder ForItems(List<PurchaseItem> items)
        {
            _items = items;
            return this;
        }

        public IPurchaseOrderBuilder FromVendor(Vendor vendor)
        {
            _vendor = vendor;
            return this;
        }

        public IPurchaseOrderBuilder RequestedBy(DateTime date)
        {
            _requestedBy = date;
            return this;
        }

        public IPurchaseOrderBuilder WithType(string type)
        {
            _type = type;
            return this;
        }


        //Operator return PurchaseOrder
        public static implicit operator PurchaseOrder(FluentBookOrderBuilder pob)
        {
            return pob.BuildPurchaseOrder();
        }
    }
}