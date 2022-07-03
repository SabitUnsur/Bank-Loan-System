using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interface, onu implemente eden classın referansını tutabilir.

            IKrediManager IhtiyackrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();


            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService FileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(IhtiyackrediManager,new List<ILoggerService> {dataBaseLoggerService,FileLoggerService}); 

            //ALTERNATİF//

            //IList<ILoggerService> loggers = new List<ILoggerService> {new DataBaseLoggerService(), new FileLoggerService()};
            //basvuruManager.BasvuruYap(konutKrediManager,loggers);



            List<IKrediManager> krediler=new List<IKrediManager>() {IhtiyackrediManager,tasitKrediManager};

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
