namespace SOLID
{
    public class InterfaceSegregation
    {
    }

    public interface IArac
    {
        public void Calistir();
        public void Durdur();
    }

    //Klima özelliği tüm araçlarda bulunmadığı için bu özellik farklı bir interface üzerinden verilmektedir.
    //Arac interface'inden kalıtım alarak base özellikleri de almasını sağlar
    //LiskovsSubstitution prensibine benzemektedir
    public interface IKlimaliArac : IArac
    {
        public void KlimaAc();
    }

    public class BMW : IKlimaliArac
    {
        public void Calistir()
        {
            Console.WriteLine("BMW çalıştırıldı!");
        }

        public void Durdur()
        {
            Console.WriteLine("BMW durduruldu!");
        }

        public void KlimaAc()
        {
            Console.WriteLine("Klima açıldı!");
        }
    }

    public class Tofas : IArac
    {
        public void Calistir()
        {
            Console.WriteLine("Tofaş çalıştırıldı!");
        }

        public void Durdur()
        {
            Console.WriteLine("Tofaş durduruldu!");
        }
    }
}
