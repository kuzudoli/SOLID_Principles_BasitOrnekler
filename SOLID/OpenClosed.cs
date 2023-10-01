namespace SOLID
{
    public class OpenClosed
    {
    }

    //Mevcut yapı korunarak yeni özelliklerin eklenebilir olmasıdır
    public interface ILogger
    {
        void Log();
    }
    //Projede sadece dosya ile log tutuluyor olabilir
    public class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Loglar dosyaya yazıldı!");
        }
    }
    //Bir süre sonra veritabanına da log atmak istendiğinde
    //dosyaya loglama kodunda bir değişiklik yapmadan sadece veritabanına loglama akışı yazılabilir
    public class DbLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Loglar veritabanına yazıldı!");
        }
    }
}