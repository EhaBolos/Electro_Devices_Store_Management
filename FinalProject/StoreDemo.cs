using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalProject
{
    class StoreDemo
    {
        static void Main(string[] args)
        {
            Computer c = new Computer(Model.AppleMacBook, Manufacture.Apple, Processores.AMDa10, "X3OL", Storage.GB256, Os.MACoS, Color.gray, 20, 8000, Hardisk.PATA);
            Computer c1 = new Computer(Model.AsusVivoBook, Manufacture.Asus, Processores.INTELi7, "X302LA", Storage.GB256, Os.WINDOWS, Color.black, 15, 5300, Hardisk.SSD);
            Computer c2 = new Computer(Model.AppleMacBookPro, Manufacture.Apple, Processores.AMDa8, "J304LA", Storage.GB128, Os.MACoS, Color.white, 8, 8500,Hardisk.SCSI);
            Computer c3 = new Computer(Model.HPproBook, Manufacture.Hp, Processores.INTELi5, "MX330", Storage.GB500, Os.WINDOWS, Color.black, 9, 3700,Hardisk.SATA);


            Tablet t = new Tablet(Model.iPadPro, Manufacture.Apple, Processores.A9, "Ts34", Storage.GB16, Os.IOS, Color.black, 55, 4500, Hardisk.PATA, camModels.tUltraWideCam, 4, 3, 3, 1200, 6.33);
            Tablet t1 = new Tablet(Model.sGalaxyTapS2, Manufacture.Samsung, Processores.AMDa6, "TabA8.0", Storage.GB32, Os.ANDROID, Color.lightBlue, 35, 3200,Hardisk.HDD, camModels.tUltraWideCam, 4, 3, 3, 800, 5.55);
            Tablet t2 = new Tablet(Model.LenovoTabM8, Manufacture.Lenovo, Processores.AMDa4, "LsA8.55", Storage.GB64, Os.ANDROID, Color.white, 45, 3000,Hardisk.EIDE, camModels.tWideCam, 3, 2, 2, 790, 5.32);
            Tablet t3 = new Tablet(Model.iPadPro, Manufacture.Apple, Processores.NVIDIA, "MacPr863.1", Storage.GB256, Os.MACoS, Color.black, 12, 4000,Hardisk.PATA, camModels.tUltraWideCam, 5, 5, 4, 1200, 6.22);

            CellPhone p = new CellPhone(Model.iphoneXr, Manufacture.Apple, Processores.A8, "Ip309", Storage.GB500, Os.IOS, Color.red, 60, 3700, camModels.DualWideTelephotoCam, 6, 5, 4, 1600, 4.20);
            CellPhone p1 = new CellPhone(Model.SGnote10Plus, Manufacture.Samsung, Processores.NVIDIA, "AM4MICRO-ATS", Storage.GB128, Os.ANDROID, Color.black, 36, 4300, camModels.TripleCam, 6, 5, 4, 1300, 4.22);
            CellPhone p2 = new CellPhone(Model.iphoneXsMax, Manufacture.Apple, Processores.A9, "Ios-A98.2", Storage.GB500, Os.IOS, Color.roseGold, 20, 5600, camModels.TripleCam, 7, 5, 5, 2000, 4.17);
            CellPhone p3 = new CellPhone(Model.XiaomiNote4x, Manufacture.Xiaomi, Processores.AMDa6, "AM4MACXI98", Storage.GB256, Os.ANDROID, Color.white, 30, 3400, camModels.SingleWideCam, 3, 3, 2, 900, 4.11);

            TheStore s = new TheStore();
            s.AddProd(c);
            s.AddProd(c1);
            s.AddProd(c2);
            s.AddProd(c3);

            s.AddProd(t);
            s.AddProd(t1);
            s.AddProd(t2);
            s.AddProd(t3);

            s.AddProd(p);
            s.AddProd(p1);
            s.AddProd(p2);
            s.AddProd(p3);

            System.IO.FileStream fs = new FileStream("ourItems.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine(s.ToString());
            writer.Close();
            fs.Close();

            BinaryFormatter formatter = new BinaryFormatter();
            string fileName = "Items.bin";
            using (FileStream fs1 = new FileStream(fileName,
                   FileMode.Create))
            {
                Console.WriteLine(s.ToString());
                formatter.Serialize(fs1, t.ToString());
                fs1.Close();
            }


            Console.WriteLine("!Number of the items!\n====================\n" + s.NumProd() + "\n\n\n");
            Console.WriteLine(s.Find(Model.iphoneXsMax));
            Console.WriteLine(s.Thickness(5));
            Console.WriteLine(s.GooDeal(4200));
            try
            {
                Console.WriteLine(s.Sale(Model.AppleMacBook, 5));
                Console.WriteLine("The new Quantity for this product " + c.GetModel() + " >>> " + c.GetQty());
            }
            catch (Exception)
            {
                Console.WriteLine("Cant offer this amount of this item");
            }
        }
    }
}
