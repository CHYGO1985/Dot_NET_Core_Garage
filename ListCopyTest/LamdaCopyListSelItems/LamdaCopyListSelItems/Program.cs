// See https://aka.ms/new-console-template for more information
/**
 * 
 * @author jingjiejiang
 * @history Dec 10, 2021
 * 
 */
namespace Application
{
    public class Test1
    {
        public int Num1 { get; set; }

        //public Test1(int num)
        //{
        //    Num1 = num;
        //}
    }

    public class Test2
    {
        public int Num2 { get; set; }

        //public Test2(int num)
        //{
        //    Num2 = num;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<Test1> numsList = new List<Test1>
            {
                new Test1(){ Num1 = 1 },
                new Test1(){ Num1 = 2 },
                new Test1(){ Num1 = 3}
            };

            List<Test2> numsList2 = numsList.Select(num => new Test2()
            {
                Num2 = num.Num1
            }).ToList();

            numsList2.ForEach(num2 => Console.WriteLine("{0}\t", num2.Num2));

            Console.WriteLine("Hello World!");
        }
    }
}