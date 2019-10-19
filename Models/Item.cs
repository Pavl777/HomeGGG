

using System;
using System.Xml.Serialization;

namespace HomeGGG.Models
{
    [Serializable]
   public class Item
    {
        public Item()
        {

        }
        [XmlAttribute]
        public string PartNumber { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal USPrice { get; set; }
        public string Comment { get; set; }
    }
}
