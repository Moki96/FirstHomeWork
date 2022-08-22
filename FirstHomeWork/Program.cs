using System; // Подключенное пространство имен

namespace FirstHomeWork.ConsoleApp // Объявление пространства имен для данного кода
{
	class Program // Объявление класса Program
	{
		static void Main(string[] args) // Объявление метода Main
		{
            #region сбор данных
            Console.WriteLine("Введите Ваше Ф. И. О.");
			string fuelName = Console.ReadLine();

			Console.Clear();                                        // Чистим консоль для лучшего чтения

			Console.WriteLine("Спасибо.\nВведите Ваш возвраст");   // Явное преобразование переменной через метод Parse
			byte age = Byte.Parse(Console.ReadLine());

			Console.Clear();                                        // Чистим консоль для лучшего чтения

			Console.WriteLine("Отлично! \nУкажите Ваш Email");
			string mail = Console.ReadLine();

			Console.Clear();                                        // Чистим консоль для лучшего чтения

			Console.WriteLine("Теперь укажите Ваш балл по: \nПрограммированию");
			double scoreProgram = Convert.ToDouble(Console.ReadLine());

			Console.Clear();                                        // Чистим консоль для лучшего чтения

			Console.WriteLine("Математике");
			double scoreMathematics = Convert.ToDouble(Console.ReadLine());           //Явное преобразование переменной через класс Convert

			Console.Clear();                                        // Чистим консоль для лучшего чтения

			Console.WriteLine("Физике");
			double scorePhysics = Convert.ToDouble(Console.ReadLine());

			#endregion

			#region Вычесления
			double scoreSum = scoreMathematics + scorePhysics + scoreProgram;    // создаем переменную и Высчитываем сумму баллов
			double averageScore = scoreSum / 3;                                  // создаем переменную и Высчитываем средний балл

			#endregion

			#region Вывод на экран
			Console.Clear();                                        // Чистим консоль для лучшего чтения
			Console.WriteLine($"{fuelName} \nСумма твоих баллов {scoreSum} \nСредний балл {averageScore} \nВполне не плохо для {age} лет. \nРезультат отправим на твой емайл {mail}");
            #endregion
        }
    }
}
