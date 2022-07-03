using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //Bu parametre bütün kredilerin referansını tuttuğu için artık istenen kredi bu şekilde hesaplanabilri.
        //Method Injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            krediManager.Hesapla();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
           
        }

        //Seçilip hesaplanması istenen krediler kaç tane olacağı belirli olmadığı için list yapısı kullanıldı.
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }


    }
}
