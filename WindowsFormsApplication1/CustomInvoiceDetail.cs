using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop
{
    class CustomInvoiceDetail
    {
        public float? ProductPrice { get; set; }
        public string ProductName { get; set; }

        public CustomInvoiceDetail(float? productprice, product product)
        {
            ProductPrice = productprice;
            ProductName = product.productName;
        }
    }
}
