using System;

namespace LabWork
{
    // Даний проект є шаблоном для виконання лабораторних робіт
    // з курсу "Об'єктно-орієнтоване програмування та патерни проектування"
    // Необхідно змінювати і дописувати код лише в цьому проекті
    // Відео-інструкції щодо роботи з github можна переглянути 
    // за посиланням https://www.youtube.com/@ViktorZhukovskyy/videos 
    class Program
    {
        static void Main(string[] args)
        {
            // Демонстрація адаптера: перетворення колісного трактора на гусеничний
            IWheeledTractor wheeled = new WheeledTractor(wheelCount: 4, horsePower: 120);

            Console.WriteLine("-- Перед адаптацією --");
            wheeled.Drive();
            // Зверніть увагу: внутрішній стан (wheelCount, horsePower) інкапсульований
            // і доступний тільки через властивості або методи, а не напряму.

            // Створюємо адаптер, який представляє колісний трактор як гусеничний
            ITrackedTractor tracked = new TrackedAdapter(wheeled, trackLength: 300);

            Console.WriteLine("-- Після адаптації --");
            tracked.Move();

            Console.WriteLine();
            Console.WriteLine("Перевірка інкапсуляції:");
            Console.WriteLine("- Поля класу WheeledTractor є приватними і недоступні зовні.");
            Console.WriteLine("- Доступ до стану здійснюється через властивості WheelCount та HorsePower.");
        }
    }
}
