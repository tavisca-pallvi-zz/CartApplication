using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CartApplication.Models
{
    public class Cart
    {
        private Items[]itemAdded=new Items[] { };

        public float totalPrice;
        public void additem(Items item,int count)
        {
         //   checkout(); 

        }
        public void removeitem(Items item, int count)
        {  }
        public void showItems(Items item)
        {

        }

     
           

    }
}