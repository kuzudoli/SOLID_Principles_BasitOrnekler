namespace SOLID
{
    public class SingleResponsibility
    {
    }

    //Sadece okuma işlerini yapar
    public class ReadTextRepository
    {
        private string text = "Hello World";
        public void ReadText()
        {
            Console.WriteLine(text);
        }
    }

    //Sadece yazma işlerini yapar
    public class WriteTextRepository
    {
        private string text = "Hello World";
        public void WriteText()
        {
            text = "Bye World";
            Console.WriteLine("Yazı güncellendi -> " + text);
        }
    }
}
