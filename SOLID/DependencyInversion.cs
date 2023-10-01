using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class DependencyInversion
    {
    }
    //İnsan sınıfının pizza kesmesi için bir alet kullanması gerek
    //Bu aletin ne olduğuyla ilgilenilmemesi bağımlılığın ters çevrilmesidir
    public class Person
    {
        private readonly ITool _tool;
        public Person(ITool tool)
        {
            _tool = tool;
        }

        public void CutPizza()
        {
            _tool.CutPizza();
        }
    }

    //Pizza kesmek için kullanılabilecek her türlü alet bu arayüzü impleme etmek zorunda
    //Çünkü insan sınıfı bu arayüz aracılığıyla pizza kesebileceğini garanti etmektedir.
    public interface ITool
    {
        public void CutPizza();
    }

    public class Knife : ITool
    {
        public void CutPizza()
        {
            Console.WriteLine("Pizza bıçakla yavaşça dilimlendi!");
        }
    }

    public class Cutter : ITool
    {
        public void CutPizza()
        {
            Console.WriteLine("Pizza, dilimleyici ile hızlıca dilimlendi!");
        }
    }
}
