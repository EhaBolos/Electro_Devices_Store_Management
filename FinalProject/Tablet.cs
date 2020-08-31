using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
  

    class Tablet : Computer, Camera, Thickness
    {
        private camModels camModel;
        private int camPixels;
        private float zoom;
        private int f;
        private float camPrice;
        private double thic;
        public Tablet(Model model, Manufacture manufacture, Processores cpu, string motherboard, Storage gb, Os os, Color color, int qty, float price, Hardisk tb, camModels camModel, int pixels, float zoom, int f, float camPrice, double thic) :base(model, manufacture, cpu, motherboard, gb, os, color, qty, price, tb)
        {
            SetCamModel(camModel);
            SetPixels(pixels);
            SetZoom(zoom);
            SetF(f);
            SetCamPrice(camPrice);
            SetThic(thic);
        }

        public void SetCamModel(camModels camModel)
        {
            this.camModel = camModel;
        }
        public camModels CamModel
        {
            get { return this.camModel; }

        }
        public void SetPixels(int camPixels)
        {
            if (camPixels > 0)
            {
                this.camPixels = camPixels;
            }
        }
        public int CamPixels
        {
            get { return this.camPixels; }

        }
        public void SetZoom(float zoom)
        {
            if (zoom > 0)
            {
                this.zoom = zoom;
            }
        }
        public float Zoom
        {
            get { return this.zoom; }

        }
        public void SetF(int f)
        {
            if (f > 0)
            {
                this.f = f;
            }

        }
        public int F
        {
            get { return this.f; }
        }
        public void SetCamPrice(float camPrice)
        {
            if (camPrice > 0)
            {
                this.camPrice = camPrice;
            }
        }
        public float CamPrice
        {
            get { return this.camPrice; }

        }
        public void SetThic(double thic)
        {
            if (thic > 0)
            {
                this.thic = thic;
            }
        }
        public double Thic
        {
            get { return this.thic; }
        }
        public string CameraToString()
        {
            string str = "";
            return str += "camera\n--------\nmodel >> " + CamModel + "\npixels >> " + CamPixels + "\nzoom >> " + Zoom + "\nfocus >> " + F + "\nprice >> " + CamPrice + "\n";
        }
        public override string ToString()
        {
            string str = "";
            return str += "Tablet\n--------\nModel >> " + GetModel() + "\nmanufacture name >> " + GetManufacture() + "\nproccessor >> " + GetCpu() + "\nmotherboard >> " + GetMotherboard() + "\nstorage >> " + GetGb() + "\nhard disk >> " + GetTb() + "\nopearation system >> " + GetOs() + "\ncolor >> " + GetColor() + "\nquantity >> " + GetQty() + "\nprice >> " + GetPrice() + "\nthicness >> " + Thic + "\n" + CameraToString();
        }
    }
}
