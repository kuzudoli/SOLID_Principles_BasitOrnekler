using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class LiskovsSubstitution
    {
    }

    public interface ISolidKullanabilir
    {
        //Bu metot bir interface'e taşıyarak sadece Senior sınıfının kullanabileceği hale getirildi
        //Abstract Developer sınıfında tanımlamış olsaydık Junior'ın da bunu kullanmasını zorunlu kılmış olurduk
        public void SolidKullan();
    }

    public abstract class Developer
    {
        public abstract void KodYaz();
    }

    public class SeniorDeveloper : Developer, ISolidKullanabilir
    {
        public override void KodYaz()
        {
            Console.WriteLine("Senior kod yazdı!");
        }

        public void SolidKullan()
        {
            Console.WriteLine("Senior SOLID kullandı!");
        }
    }

    public class JuniorDeveloper : Developer
    {
        public override void KodYaz()
        {
            Console.WriteLine("Junior kod yazdı, kaçın!");
        }
    }
}
