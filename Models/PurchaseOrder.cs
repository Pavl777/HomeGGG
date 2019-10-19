

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace HomeGGG.Models
{
    [Serializable]
  public  class PurchaseOrder
    {
        [XmlAttribute]
        public int PurchaseOrderNumber { get; set; }
        [XmlAttribute]
        public DateTime OrderDate { get; set; }

        public List<Address> Addresses { get; set; }
        public List<Item> Items { get; set; }
        public string DeliveryNotes { get; set; }

        public PurchaseOrder()
        {

        }
    }
}
