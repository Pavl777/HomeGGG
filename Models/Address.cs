﻿

using System;
using System.Xml.Serialization;

namespace HomeGGG.Models
{
    [Serializable]
  public  class Address
    {

        public string Name { get; set; }

        public string Street { get; set; }
        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Country { get; set; }
        [XmlAttribute]
        public string Type { get; set; }

        public Address()
        {

        }


    }

}
