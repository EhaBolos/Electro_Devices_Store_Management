using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Computer : Items
    {
        private Hardisk tb;
        
        public Computer(Model model, Manufacture manufacture, Processores cpu, string motherboard, Storage gb, Os os, Color color, int qty, float price, Hardisk tb) : base(model, manufacture, cpu, motherboard, gb, os, color, qty, price)
        {
            SetTb(tb);     
        }

        public virtual void SetTb(Hardisk tb)
        {
            this.tb=tb;
        }
        public virtual Hardisk GetTb()
        {
            return this.tb;
        }
        public override string ToString()
        {
            string str = "";
            return str += "Laptop\n--------\nModel >> " + GetModel() + "\nmanufacture name >> " + GetManufacture() + "\nproccessor >> " + GetCpu() + "\nmotherboard >> " + GetMotherboard() + "\nstorage >> " + GetGb() + "\nhard disk >> " + GetTb() + "\nopearation system >> " + GetOs() + "\ncolor >> " + GetColor() + "\nquantity >> " + GetQty() + "\nprice >> " + GetPrice() + "\n";
        }
    }
}
