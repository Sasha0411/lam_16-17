namespace LAB_16_17
{
    using System;

    public class Team
    {
        // Поля класу
        public string Name { get; set; }
        public int YearFounded { get; set; }
        public string Address { get; set; }
        public int PlayerCount { get; set; }
        public int WinsCount { get; set; }

        // Конструктор для ініціалізації об'єкта команди
        public Team(string name, int yearFounded, string address, int playerCount, int winsCount)
        {
            Name = name;
            YearFounded = yearFounded;
            Address = address;
            PlayerCount = playerCount;
            WinsCount = winsCount;
        }

        // Метод для обчислення середнього арифметичного кількості перемог за рік
        public double CalculateAverageWinsPerYear()
        {
            int currentYear = DateTime.Now.Year;
            int yearsActive = currentYear - YearFounded;

            // Перевіряємо, щоб команда існувала хоча б 1 рік, щоб уникнути ділення на нуль
            if (yearsActive > 0)
            {
                return (double)WinsCount / yearsActive;
            }
            else
            {
                return WinsCount; // Якщо команда нова, повертаємо кількість перемог
            }
        }

        // Виведення інформації про команду
        public void DisplayInfo()
        {
            Console.WriteLine($"Назва команди: {Name}");
            Console.WriteLine($"Рiк заснування: {YearFounded}");
            Console.WriteLine($"Адреса: {Address}");
            Console.WriteLine($"Кiлькість гравцiв: {PlayerCount}");
            Console.WriteLine($"Кількість перемог: {WinsCount}");
            Console.WriteLine($"Середня кількiсть перемог за рiк: {CalculateAverageWinsPerYear():F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо об'єкт команди
            Team team = new Team("Команда А", 2000, "Україна, Київ", 25, 120);

            // Виводимо інформацію про команду та середнє арифметичне перемог за рік
            team.DisplayInfo();
        }
    }
}
