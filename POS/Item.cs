using System;
using System.Collections.Generic;
using System.Text;

namespace POS
{
    public class Item: IHasId<int>
    {
       
        public int Id  { get; set; }
        public string BarCode { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"Item:[Id= {Id,-5}, BarCode = {BarCode,-10}, Desc = {Description,-15}, Price = {Price,-6:F2}, Qty = {Quantity,-5}]";
        }

    }   
}
