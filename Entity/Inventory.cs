using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationView
{
    class Inventory 
    {
         string productName;
         int quantity;
        double price;
            int productId;
        public Inventory(int productID,string productName,int quantity,double price) {

            this.productId = productId;
            this.productName = productName;
            this.quantity = quantity;
            this.price = price;
        }

        public void setProductName(string name) {
            productName = name;
        }

        public void setPrice(int p)
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

        public int getProductID()
        {
            return productId ;
        }

        public void setProductID(int p)
        {
            productId = p;


        }

    }
}
