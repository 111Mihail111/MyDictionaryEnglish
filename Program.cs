using MyDictionaryEnglish.Infrastructure;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace MyDictionaryEnglish
{
    class Program
    {
        private MyDictionary _myDictionary;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        public void Start()
        {
            _myDictionary = InitializeMyDictionary();
            _myDictionary.Initialize();

            string option = string.Empty;
            while (option != "exit")
            {
                Console.WriteLine("Для выхода пропишите 'exit'");
                Console.WriteLine("");
                Console.WriteLine("Выберите один из вариантов:");
                Console.WriteLine("1) С Английского на Русский.");
                Console.WriteLine("2) С Русского на Английский.");

                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Option(1);
                        break;
                    case "2":
                        Option(2);
                        break;
                }

                _myDictionary.Clear();
            }

            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------Вы нажали выход!---------------------------------------------");
            Console.WriteLine("");
        }

        public void Option(int variation)
        {
            Console.WriteLine("Выберите опцию:");
            //Console.WriteLine("1) Взять случайные 100 слов из словаря.");
            Console.WriteLine("1) Взять определенное количество слов из словаря (с начала).");
            Console.WriteLine("2) Взять определенное количество слов из словаря (с конца).");
            Console.WriteLine("3) Взять все слова из словаря.");

            var allWords = _myDictionary.GetDictionary();
            string option = Console.ReadLine().Replace(" ", "");
            int countWords = 0;
            if (option != "3")
            {
                Console.WriteLine($"Введите количество слов, которые необходимо взять. Количество не должно превышать: {allWords.Count}");
                countWords = Convert.ToInt32(Console.ReadLine().Replace(" ", ""));
            }

            if (variation == 1)
            {
                switch (option)
                {
                    case "1":
                        _myDictionary.EnglishOnRussianDictionary(allWords.Take(countWords).ToDictionary(x => x.Key, w => w.Value));
                        break;
                    case "2":
                        _myDictionary.EnglishOnRussianDictionary(allWords.TakeLast(countWords).ToDictionary(x => x.Key, w => w.Value));
                        break;
                    case "3":
                        _myDictionary.EnglishOnRussianDictionary(allWords);
                        break;
                }
            }
            else if (variation == 2)
            {
                switch (option)
                {                   
                    case "1":
                        _myDictionary.RussianOnEnglishDictionary(allWords.Take(countWords).ToDictionary(x => x.Key, w => w.Value));
                        break;
                    case "2":
                        _myDictionary.RussianOnEnglishDictionary(allWords.TakeLast(countWords).ToDictionary(x => x.Key, w => w.Value));
                        break;
                    case "3":
                        _myDictionary.RussianOnEnglishDictionary(allWords);
                        break;
                }
            }

            if (_myDictionary.GetCountDictionaryProblemaWork() == 0)
            {
                return;
            }

            Console.WriteLine("Не желаете повторить слова, в которых ошиблись? (введите: '+' или '-')");
            string wordWithError = Console.ReadLine().Replace(" ", "");
            while (wordWithError != "-")
            {
                _myDictionary.ResetErrorCounter();

                switch (variation)
                {
                    case 1:
                        _myDictionary.EnglishOnRussianDictionary(_myDictionary.GetDictionaryProblemWork(), true);
                        break;
                    case 2:
                        _myDictionary.RussianOnEnglishDictionary(_myDictionary.GetDictionaryProblemWork(), true);
                        break;
                }

                if (_myDictionary.GetCountDictionaryProblemaWork() == 0)
                {
                    return;
                }

                Console.WriteLine("Еще? (введите: '+' или '-')");
                wordWithError = Console.ReadLine().Replace(" ", "");
            }
        }



        /// <summary>
        /// Инициализация MyDictionary
        /// </summary>
        /// <returns>Экземпляр MyDictionary</returns>
        public MyDictionary InitializeMyDictionary()
        {
            return new MyDictionary();
        }

    }
}