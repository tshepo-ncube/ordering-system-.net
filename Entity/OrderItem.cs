using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationView
{
    class OrderItem 
    {
         string productName;
         int quantity;
        double price;

        public void setProductName(string name) {
            productName = name;
        }

        public void setPrice(double p)
        {
            price = p;

            
        }

        public void setQuantity(int q)
        {
            quantity = q;
        }


        public string getProductName()
        {
            return productName;
        }

        public double getPrice()
        {
            return price;
        }

        public int getQuantity ()
        {
            return quantity;
        }

    }
}
