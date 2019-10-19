using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using HomeGGG.Models;


namespace HomeGGG
{
    class Program
    {
        static void Main(string[] args)
        {
            PurchaseOrder purchase;
            XmlSerializer formatter = new XmlSerializer(typeof(PurchaseOrder));

            using (FileStream fs = new FileStream(@"..\..\PurchaseOrder.xml", FileMode.Open))
            {
                purchase = (PurchaseOrder)formatter.Deserialize(fs);


                foreach (Item item in purchase.Items)
                {
                    Console.WriteLine(item.PartNumber);
                }

                List<Item> itemsExpansive =
                    purchase.Items.Where(u => u.USPrice > 100).OrderBy(p => p.PartNumber).ToList();

                foreach (Item item in itemsExpansive)
                {
                    Console.WriteLine($"{item.PartNumber}, {item.ProductName}");
                }
            }
        }
    }
}
