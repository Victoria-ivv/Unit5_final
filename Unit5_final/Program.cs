using System;

namespace Unit5_final
{
    class Program
    {
        static void Main(string[] args)

        {
            ReadUserData();
        }


        static ( //возвращаем кортеж метода
            string FirstName,
            string LastName,
            int Age,
            bool IsPet,
            int PetCount,
            string[] PetsNames,
            int ColorCount,
            string[] Colors) ReadUserData()
        {
            Console.Write("Введите ваше имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            string lastName = Console.ReadLine();
            string strAge="";
            while (!CheckNum(strAge))//проверяем что цифры в возрасте
            {
                Console.Write("Введите ваш возраст цифрами: ");
                strAge = Console.ReadLine();
            }
            int age = int.Parse(strAge);
            
            Console.Write("У Вас есть питомец? (да/нет): ");
            string strIsPet = Console.ReadLine();
            bool isPet = false;
            string[] petsNames = { };
            int petsCount = 0;
            if (strIsPet == "да")
            {
                isPet = true;
                string strPetsCount = "";
                while (!CheckNum(strPetsCount))//проверяем что число питомцев
                {
                    Console.Write("Введите количество питомцев цифрами: ");
                    strPetsCount = Console.ReadLine();
                }
                petsCount = int.Parse(strPetsCount);
                petsNames = ReadPetsNames(petsCount);
            }

            string strColorCount = "";
            while (!CheckNum(strColorCount))//проверяем что число питомцев
            {
                Console.Write("Введите количество любимых цветов цифрами: ");
                strColorCount = Console.ReadLine();
            }
            int colorCount = int.Parse(strColorCount);
            string[] colors = ReadColors(colorCount);
            return (firstName,
            lastName,
            age,
            isPet,
            petsCount,
            petsNames,
            colorCount,
            colors);

        }
        /// <summary>
        /// метод, принимающий на вход количество питомцев и возвращающий массив их кличек
        /// </summary>
        /// <param name="PetsCount">количество питомцев</param>
        /// <returns>массив кличек питомцев</returns>
        static string[] ReadPetsNames(int PetsCount)
        {
            var petsNames = new string[PetsCount];
            for (var i = 0; i < PetsCount; i++)
            {
                Console.Write($"Введите кличку питомца {i}: ");
                petsNames[i] = Console.ReadLine();
            }
            return petsNames;
        }
        /// <summary>
        /// ввёл ли пользователь корректные числа: возраст, количество питомцев, количество цветов в отдельном методе;
        /// </summary>
        /// <param name="strNum">строка с числом</param>
        /// <returns>true если число иначе false</returns>
        static bool CheckNum(string strNum)
        {
            int num=0;
            if (int.TryParse(strNum, out num) && num > 0)
            {
                return true;
            }
            else
            { 
                return false; 
            }
           }
        /// <summary>
        /// ввод любимых цветов
        /// </summary>
        /// <param name="ColorCount">количество цветов</param>
        /// <returns>массив цветов</returns>
        static string[] ReadColors(int ColorCount)
        {
            var сolors = new string[ColorCount];
            for (var i = 0; i < ColorCount; i++)
            {
                Console.Write($"Введите Ваш любимый цвет{i}: ");
                сolors[i] = Console.ReadLine();
            }
            return сolors;
        }
    }

}
