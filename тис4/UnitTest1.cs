using ConsoleApp2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace тис4
{
    [TestClass]
    public class UnitTest1
    {
        int num = 0;
        [TestMethod]
        public void Test1()
        {
            Console.WriteLine($"Номер теста : {num}");
            Console.WriteLine($"Дата и время : {DateTime.Now}");
        }


        [TestMethod]
        [Ignore]
        public void Test2()
        {
            Console.WriteLine("Sum");
            int x = 0;
            int y = 0;
            int expResult = 0;
            int result = CustomMath.sum(x, y);

            Assert.AreEqual(expResult, result);
            num++;
        }



        [TestMethod]
        public void Test3()
        {
            Console.WriteLine("division");
            int x = 2;
            int y = 1;
            int expResult = 2;
            try
            {
                int result = CustomMath.division(x, y);
                Assert.AreEqual(expResult, result);
                if (y == 0)
                    Console.WriteLine("Деление на ноль не создает исключительной ситуации");
            }
            catch (DivideByZeroException e)
            {
                if (y != 0)
                    Console.WriteLine("Генерация исключения при ненулевом элементе");
            }
            num++;
        }

        [TestMethod]
        public void Test4()
        {
            Console.WriteLine("main");

            int x = 0;
            int y = 0;
            bool expResult = false;
            bool result = CustomMath.main(x, y);

            Assert.IsFalse(result);
            num++;
        }


        [TestMethod]
        public void Test5()
        {
            Console.WriteLine("main");

            int x = 0;
            int y = 0;
            bool expResult = false;
            bool result = CustomMath.main(x, y);

            Assert.IsFalse(result);
            num++;
        }
        public static bool main(int x, int y)
        {
            bool result = true;
            if (y == 0)
                result = false;
            return result;
        }

    }
}

