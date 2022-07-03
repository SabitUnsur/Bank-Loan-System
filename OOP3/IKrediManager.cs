using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager
    {
        //her kredi farklı faiz vs masraf hesaplar, aynı kodu farklı şekilde kullanırlar.
        //Bu tip imzanın yani base'in aynı olduğu ama içerisinin farklı olduğu durumlarda interface tanımlanır
        //Interfaceler , birbirinin alternatifi olan ama kod içerikler farklı olan durumlar için kullanırız.
        
        void Hesapla();
        void BiseyYap();
        
    }
}
