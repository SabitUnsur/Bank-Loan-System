using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //Sabit Ünsür

           GercekMusteri musteri1= new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Sabit";
            musteri1.Soyadi = "Ünsür";
            musteri1.TcNo = "451215748";

                
                 //Kodlama İO

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo="453453";
            musteri2.SirketAdi = "Kodlama.İO";
            musteri2.VergiNo = "1234567890";



            //Gerçek Müsteri - Tüzel Müsteri
            //SOLID


            Musteri musteri3=new GercekMusteri();
            Musteri musteri4=new TuzelMusteri();

            CustomerManager customerManager=new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);



        }
    }
}
