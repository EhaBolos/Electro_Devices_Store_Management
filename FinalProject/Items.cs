using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    [Serializable]
    class Items
    {
        private Model model;
        private Manufacture manufacture;
        private Processores cpu;
        private string motherboard;
        private Storage gb;
        private Os os;
        private Color color;
        public int qty;
        private float price;

        public Items(Model model, Manufacture manufacture, Processores cpu, string motherboard, Storage gb,  Os os, Color color, int qty, float price)
        {
            SetModel(model);
            SetManufactures(manufacture);
            SetCpu(cpu);
            SetMotherboard(motherboard);
            SetGb(gb);
            SetOs(os);
            SetColor(color);
            SetQty(qty);
            SetPrice(price);
        }
        public void SetModel(Model model)
        {
            this.model = model;
        }
        public Model GetModel()
        {
            return this.model;
        }
        public void SetManufactures(Manufacture manufacture)
        {
            this.manufacture = manufacture;
        }
        public  Manufacture GetManufacture()
        {
            return this.manufacture;
        }
        public void SetCpu(Processores cpu)
        {
            this.cpu = cpu;
        }
        public  Processores GetCpu()
        {
            return this.cpu;
        }
        public void SetMotherboard(string motherboard)
        {
            this.motherboard = motherboard;
        }
        public string GetMotherboard()
        {
            return this.motherboard;

        }
        public void SetGb(Storage gb)
        {
            this.gb = gb;
        }
        public Storage GetGb()
        {
            return this.gb;
        }
        public void SetOs(Os os)
        {
            this.os = os;
        }
        public Os GetOs()
        {
            return this.os;
        }
        public void SetColor(Color color)
        {
            if (color == Color.black || color == Color.white || color == Color.gray)
                this.color = color;
        }
        public Color GetColor()
        {
            return this.color;
        }
        public void SetQty(int qty)
        {
            if (qty > 0)
            {
                this.qty = qty;
            }
        }
        public int GetQty()
        {
            return this.qty;
        }
        public void SetPrice(float price)
        {
            if (price > 0)
            {
                this.price = price;
            }
        }
        public float GetPrice()
        {
            return this.price;
        }

        public override string ToString()
        {
            string str = "";
            return str += "Model >> " + GetModel() + "\nmanufacture name >> " + GetManufacture() + "\nproccessor >> " + GetCpu() + "\nmotherboard >> " + GetMotherboard() + "\nstorage >> " + GetGb() + "\nhard disk >> " + "\nopearation system >> " + GetOs() + "\ncolor >> " + GetColor() + "\nquantity >> " + GetQty() + "\nprice >> " + GetPrice() + "\n";
        }

    }
}
