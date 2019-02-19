using System;
using System.Text;

namespace Oẳn_tù_tì
{
    internal class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            MenuAuto();
            GameBegin();
            Console.Write("Bạn có muốn tiếp tục không?(Y/N): ");
            string awr = Console.ReadLine();
            if (awr == "Y" || awr == "y")
            {
                Console.Clear();
                Main();
            }
            //Console.ReadLine();
        }
        /// <summary>
        /// /
        /// </summary>
        private static void GameBegin()
        {
            int yourNumber;
        CON:
            yourNumber = int.Parse(Console.ReadLine());
            if (yourNumber < 1 || yourNumber > 3)
            {
                Console.WriteLine("Mời nhập đúng giá trị");
                goto CON;
            }
            Random rand = new Random();
            int botNumber = rand.Next(1, 4);
            switch (botNumber)
            {
                case 1:
                    if (yourNumber == 1)
                    {
                        Console.WriteLine("Hoà");
                    }
                    else if (yourNumber == 2)
                    {
                        Console.WriteLine("Bạn thua");
                    }
                    else if (yourNumber == 3)
                    {
                        Console.WriteLine("Bạn thắng");
                    }

                    Console.WriteLine("Bạn : {0} - Máy : {1}", yourNumber, botNumber);
                    break;

                case 2:
                    if (yourNumber == 1)
                    {
                        Console.WriteLine("Bạn thắng");
                    }
                    else if (yourNumber == 2)
                    {
                        Console.WriteLine("Hoà");
                    }
                    else if (yourNumber == 3)
                    {
                        Console.WriteLine("Bạn thua");
                    }
                    Console.WriteLine("Bạn : {0} - Máy : {1}", yourNumber, botNumber);
                    break;

                case 3:
                    if (yourNumber == 1)
                    {
                        Console.WriteLine("Bạn thắng");
                    }
                    else if (yourNumber == 2)
                    {
                        Console.WriteLine("Bạn thua");
                    }
                    else if (yourNumber == 3)
                    {
                        Console.WriteLine("Hoà");
                    }
                    Console.WriteLine("Bạn : {0} - Máy : {1}", yourNumber, botNumber);
                    break;
            }
        }

        private static void MenuAuto()
        {
            Console.WriteLine("Welcome game oẳn tù tì");
            Console.WriteLine("----------------------");
            Console.WriteLine("Luật chơi");
            Console.WriteLine("Người dùng nhập từ bàn phím số 1;2;3 tương ứng");
            Console.WriteLine("1: Búa");
            Console.WriteLine("2. Kéo");
            Console.WriteLine("3. Bao");
            Console.WriteLine("Búa thắng kéo, thua bao;\nKéo thắng bao, thua búa;\nBao thắng búa, thua kéo");
        }
    }
}