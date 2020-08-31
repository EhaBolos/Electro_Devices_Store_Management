using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class TheStore
    {
        private List<Items> products;

        public TheStore()
        {
            products = new List<Items>();
        }
        
        public void AddProd(Object prod)
        {
            Items I;
            if (prod is Items)
            {
                I = (Items)prod;
                products.Add(I);//AddIntoList
            }
            
        }

        public string NumProd()
        {
            int iF = 0, tF = 0, lF = 0, i = 0;
            for (i = 0; i < products.Count; i++)
            {
                if (products[i] is Computer)
                {
                    Computer c = (Computer)products[i];
                    if (c is Tablet)
                    {
                        tF++;
                    }
                    else
                        lF++;
                }
                else if (products[i] is CellPhone) iF++;
            }
            string str = "";

            return str += "Number of computers is >> " + lF + "\nNumber of tablets is >> " + tF + "\nNumber of phones is >> " + iF;
        }
        public override string ToString()
        {
            
            string str = "!Items in store!\n================\n\n", s = "\n///////////////////////////////////////\n///////////////////////////////////////\n\n";
            for (int i = 0; i < products.Count; i++)
            {
                str += products[i].ToString() + s;
            }
            return str;
        }
        public string Find(Model model)
        {
          

            string str = "!our models that fits your request!\n====================================\n\n";
            bool flag = false;
            string s = "\n///////////////////////////////////////\n///////////////////////////////////////\n\n";
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].GetModel() == model)
                {
                    str += products[i].ToString() + s;
                    flag = true;
                }
            
            }
            if (flag == false)
            {
                str += "No such item with this model\n\n\n";
            }
            return str;
        }
        public string Thickness(double num)
        {
            Tablet t;
            CellPhone p;
            string str = "!Items with less thickness!\n===========================\n\n", s = "\n///////////////////////////////////////\n///////////////////////////////////////\n\n";
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i] is Tablet)
                {
                    t = (Tablet)products[i];
                    if (t.Thic < num)
                    {
                        str += t.ToString() + s + "\n";
                    }
                }
                else if (products[i] is CellPhone)
                {
                    p = (CellPhone)products[i];
                    if (p.Thic < num)
                    {
                        str += p.ToString() + s + "\n";
                    }
                }
            }
            return str;


        }
        public string GooDeal(float price)
        {
            bool flag = false;
            string s = "Items that fits this price:\n==============================\n\n", str = "", s1 = "\n///////////////////////////////////////\n///////////////////////////////////////\n\n";
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].GetPrice()<=price)
                {
                    str += products[i].ToString() + s1;
                    flag = true;

                }                
            }
            if (flag == false)
                str = "No such items that fits this price :(";
            return s += str;
        }


        public float Sale(Model model, int amout)
        {
           
            int flag = 0;
            float itemsPrice = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].GetModel()==model)
                {
                    if (products[i].GetQty() >= amout)
                    {
                        products[i].qty = products[i].qty - amout;
                        itemsPrice = products[i].GetPrice() *((float)amout);
                        flag++;
                    }
             
                }
            }
            if (flag == 0)
            {
                throw new Exception();
            }
            return itemsPrice;

        }
    }
}

