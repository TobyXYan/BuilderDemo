using System;
using System.Collections.Generic;

namespace BuilderDemo
{
    public  class PurchaseOrder
    {

		private string _companyName;

		public string CompanyName
		{
			get { return _companyName; }
			set { _companyName = value; }
		}

		private string _companyAddress;

		public string CompanyAddress
		{
			get { return _companyAddress; }
			set { _companyAddress = value; }
		}

		private DateTime _createdOn;

		public DateTime CreatedOn
		{
			get { return _createdOn; }
			set { _createdOn = value; }
		}

		private DateTime _rquestedBy;

		public DateTime RequestedBy
		{
			get { return _rquestedBy; }
			set { _rquestedBy = value; }
		}

		private Vendor _vendor;

		public Vendor Vendor
		{
			get { return _vendor; }
			set { _vendor = value; }
		}

		private List<PurchaseItem> _items;

		public List<PurchaseItem> Items
		{
			get { return _items; }
			set { _items = value; }
		}

		private string _pType;

		public string PType
		{
			get { return _pType; }
			set { _pType = value; }
		}


		public PurchaseOrder(string type)
		{
			PType = type;
		}


	}
}