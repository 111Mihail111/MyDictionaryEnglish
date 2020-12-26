using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDictionaryEnglish.Infrastructure
{
    public class MyDictionary
    {
        /// <summary>
        /// Словарь
        /// </summary>
        private Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        /// <summary>
        /// Слова в которых ошибся пользователь
        /// </summary>
        private Dictionary<string, string> _dictionaryProblemWork = new Dictionary<string, string>();
        /// <summary>
        /// Количество ошибок
        /// </summary>
        private int _errors = 0;

        /// <summary>
        /// Инициализация словаря
        /// </summary>
        public void Initialize()
        {
            #region 281 слов
            _dictionary.Add("on", "на");
            _dictionary.Add("in", "в, во");
            _dictionary.Add("above", "над");
            _dictionary.Add("under", "под");
            _dictionary.Add("over", "сверх, поверху");
            _dictionary.Add("in the center", "в центре");
            _dictionary.Add("in front of", "впереди");
            _dictionary.Add("behind", "сзади");
            _dictionary.Add("round the corner", "за углом");
            _dictionary.Add("opposite", "напротив");
            _dictionary.Add("accross", "через");
            _dictionary.Add("between", "между (двумя)");
            _dictionary.Add("among", "между (многими)");
            _dictionary.Add("at", "в, у, за, на");
            _dictionary.Add("for", "для");
            _dictionary.Add("from", "от");
            _dictionary.Add("from ... into", "с ... на");
            _dictionary.Add("with", "с");
            _dictionary.Add("without", "без");
            _dictionary.Add("to", "в, к (предлог направления); без, до (о времени)");
            _dictionary.Add("of", "кого? чего? аналог родительного падежа");
            _dictionary.Add("by", "кем? чем? аналог творительного падежа");
            _dictionary.Add("close to", "близко к");
            _dictionary.Add("far from", "далеко от");
            _dictionary.Add("till", "до, вплоть до");
            _dictionary.Add("before", "до, перед");
            _dictionary.Add("after", "после");
            _dictionary.Add("past", "после (о времени)");
            _dictionary.Add("into", "в, внутрь");
            _dictionary.Add("near", "рядом, около");
            _dictionary.Add("about", "о, об, около, примерно");
            _dictionary.Add("nearly", "примерно");
            _dictionary.Add("next to", "рядом с");
            _dictionary.Add("in ... the middle of", "в середине");
            _dictionary.Add("through", "сквозь, через");
            _dictionary.Add("art gallery", "картинная галерея");
            _dictionary.Add("avenue", "проспект");
            _dictionary.Add("botanical gardens", "ботанический сад");
            _dictionary.Add("boulevard", "бульвар");
            _dictionary.Add("building", "здание");
            _dictionary.Add("castle", "замок");
            _dictionary.Add("cathedral", "собор");
            _dictionary.Add("cave", "пещера");
            _dictionary.Add("cemetery", "кладбище");
            _dictionary.Add("chapel", "часовня");
            _dictionary.Add("church", "церковь");
            _dictionary.Add("concert hall", "концертный зал");
            _dictionary.Add("convent", "монастырь");
            _dictionary.Add("docks", "пристань");
            _dictionary.Add("downtown", "центр города");
            _dictionary.Add("exhibition", "выставка");
            _dictionary.Add("factory", "завод, фабрика");
            _dictionary.Add("fair", "ярмарка-выставка");
            _dictionary.Add("fortress", "крепость");
            _dictionary.Add("fountain", "фонтан");
            _dictionary.Add("garden", "сад");
            _dictionary.Add("harbor", "гавань, порт");
            _dictionary.Add("lake", "озеро");
            _dictionary.Add("law courts", "суд");
            _dictionary.Add("market", "рынок");
            _dictionary.Add("memorial", "мемориал, памятник");
            _dictionary.Add("monastery", "монастырь 2");
            _dictionary.Add("monument", "памятник");
            _dictionary.Add("museum", "музей");
            _dictionary.Add("observatory", "обсерватория");
            _dictionary.Add("old town", "старая часть города");
            _dictionary.Add("opera house", "оперный театр");
            _dictionary.Add("palace", "дворец");
            _dictionary.Add("planetarium", "планетарий");
            _dictionary.Add("ruins", "развалины");
            _dictionary.Add("stadium", "стадион");
            _dictionary.Add("statue", "статуя");
            _dictionary.Add("temple", "храм");
            _dictionary.Add("tomb", "могила, усыпальница");
            _dictionary.Add("tower", "башня");
            _dictionary.Add("zoo", "зоопарк");
            _dictionary.Add("be", "быть, находиться");
            _dictionary.Add("pet", "любимое дом. животное");
            _dictionary.Add("bed", "кровать, постель");
            _dictionary.Add("ten", "десять");
            _dictionary.Add("pen", "ручка");
            _dictionary.Add("tent", "палатка");
            _dictionary.Add("me", "мне, меня");
            _dictionary.Add("meet", "встречать, знакомиться с");
            _dictionary.Add("mend", "чинить, ремонтировать");
            _dictionary.Add("tell", "сказать, рассказать");
            _dictionary.Add("bell", "колокол, звонок");
            _dictionary.Add("let", "пусть, пускай");
            _dictionary.Add("lend", "давать на время, одалживать");
            _dictionary.Add("beef", "говядина");
            _dictionary.Add("spend", "тратить, проводить (время)");
            _dictionary.Add("bee", "пчела");
            _dictionary.Add("send", "посылать");
            _dictionary.Add("see", "видеть, смотреть, повидаться с");
            _dictionary.Add("sleep", "спать");
            _dictionary.Add("spell", "сказать или прочитать по буквам");
            _dictionary.Add("set", "комплект, набор");
            _dictionary.Add("step", "шаг, ступенька");
            _dictionary.Add("steel", "сталь, стальной");
            _dictionary.Add("test", "испытание, опыт, проверка, проверять");
            _dictionary.Add("best", "самый лучший");
            _dictionary.Add("seven", "семь");
            _dictionary.Add("even", "даже");
            _dictionary.Add("tv", "телевидение");
            _dictionary.Add("tv set", "телевизор");
            _dictionary.Add("felt pen", "фломастер");
            _dictionary.Add("settle", "урегулировать");
            _dictionary.Add("needle", "иголка");
            _dictionary.Add("i", "я");
            _dictionary.Add("five", "пять");
            _dictionary.Add("nine", "девять");
            _dictionary.Add("size", "размер");
            _dictionary.Add("line", "строка, линия");
            _dictionary.Add("file", "файл, папка, скоросшиватель");
            _dictionary.Add("time", "время, раз");
            _dictionary.Add("slide", "слайд");
            _dictionary.Add("tie", "галстук");
            _dictionary.Add("life", "жизнь");
            _dictionary.Add("find", "находить");
            _dictionary.Add("my", "мой, свой");
            _dictionary.Add("eye", "глаз");
            _dictionary.Add("type", "тип, модель, печатать");
            _dictionary.Add("bye-bye", "пока, всего хорошего");
            _dictionary.Add("fine", "ясный, прекрасный");
            _dictionary.Add("it", "он, она, оно, это (к животным и предметам)");
            _dictionary.Add("be in", "быть на месте, быть у себя");
            _dictionary.Add("in time", "вовремя");
            _dictionary.Add("ill", "больной");
            _dictionary.Add("sit", "сидеть");
            _dictionary.Add("empty", "пустой");
            _dictionary.Add("sleepy", "сонный");
            _dictionary.Add("be sleepy", "хотеть спать");
            _dictionary.Add("be ill", "болеть, быть больным");
            _dictionary.Add("slim", "стройный, изящный, худой");
            _dictionary.Add("silly", "глупый");
            _dictionary.Add("film", "фильм, пленка");
            _dictionary.Add("tin", "консервная банка");
            _dictionary.Add("bill", "счет");
            _dictionary.Add("telly", "телевизор, телевидение");
            _dictionary.Add("visit", "визит, посещение, навещать");
            _dictionary.Add("tennis", "теннис");
            _dictionary.Add("list", "список");
            _dictionary.Add("splendid", "великолепный");
            _dictionary.Add("event", "событие, соревнование");
            _dictionary.Add("penny", "пенни");
            _dictionary.Add("little", "маленький");
            _dictionary.Add("idle", "праздный, не занятый делом");
            _dictionary.Add("be idle", "бездельничать, сидеть без дела");
            _dictionary.Add("simple", "простой, несложный");
            _dictionary.Add("listen", "слушать");
            _dictionary.Add("no", "нет");
            _dictionary.Add("so", "так, такой");
            _dictionary.Add("note", "запись, примечание, записка");
            _dictionary.Add("notes", "записки");
            _dictionary.Add("nose", "нос");
            _dictionary.Add("open", "открывать, открытый");
            _dictionary.Add("old", "старый");
            _dictionary.Add("post", "почта, отправлять по почте");
            _dictionary.Add("model", "модель, образец");
            _dictionary.Add("bottle", "бутылка");
            _dictionary.Add("stop", "останавливать, останавливаться, прекращать");
            _dictionary.Add("on my list", "у меня в списке");
            _dictionary.Add("boss", "босс, начальник");
            _dictionary.Add("people", "люди, родня, родственники");
            _dictionary.Add("old people", "старые люди");
            _dictionary.Add("lesson", "урок");
            _dictionary.Add("he", "он");
            _dictionary.Add("him", "его, ему");
            _dictionary.Add("his", "его, свой");
            _dictionary.Add("help", "помощь, помогать");
            _dictionary.Add("hotel lobby", "вестибюль гостиницы");
            _dictionary.Add("hotel", "отель");
            _dictionary.Add("hobby", "хобби, любимое занятие");
            _dictionary.Add("hold", "держать (в руках)");
            _dictionary.Add("hot", "горячий");
            _dictionary.Add("hello", "привет");
            _dictionary.Add("photo", "фотография");
            _dictionary.Add("in his photo", "на его фотографии");
            _dictionary.Add("phone", "телефон, звонить по телефону");
            _dictionary.Add("boy", "мальчик");
            _dictionary.Add("toy", "игрушка");
            _dictionary.Add("boil", "варить, кипятить");
            _dictionary.Add("boiled", "варенный, кипяченый");
            _dictionary.Add("noise", "шум");
            _dictionary.Add("noisy", "шумный");
            _dictionary.Add("she", "она");
            _dictionary.Add("shop", "магазин, цех, мастерская");
            _dictionary.Add("head", "голова");
            _dictionary.Add("face", "лицо");
            _dictionary.Add("hair", "волосы");
            _dictionary.Add("ears", "уши");
            _dictionary.Add("lips", "губы");
            _dictionary.Add("mouth", "рот");
            _dictionary.Add("tooth", "зуб");
            _dictionary.Add("teeth", "зубы");
            _dictionary.Add("forehead", "лоб");
            _dictionary.Add("chin", "подбородок");
            _dictionary.Add("cheek", "щека");
            _dictionary.Add("eyebrow", "бровь");
            _dictionary.Add("eyelash", "ресница");
            _dictionary.Add("beard", "борода");
            _dictionary.Add("moustache", "усы");
            _dictionary.Add("neck", "шея");
            _dictionary.Add("body", "тело");
            _dictionary.Add("chest", "грудь");
            _dictionary.Add("back", "спина");
            _dictionary.Add("shoulder", "плечо");
            _dictionary.Add("hand", "рука (кисть)");
            _dictionary.Add("arm", "рука 2");
            _dictionary.Add("finger", "палец");
            _dictionary.Add("elbow", "локоть");
            _dictionary.Add("leg", "нога 2");
            _dictionary.Add("foot", "нога, ступня");
            _dictionary.Add("feet", "ноги");
            _dictionary.Add("knee", "колено");
            _dictionary.Add("toe", "палец (на ногах)");
            _dictionary.Add("thumb", "большой палец (на руках)");
            _dictionary.Add("skin", "кожа");
            _dictionary.Add("nail", "ноготь");
            _dictionary.Add("dish", "блюдо");
            _dictionary.Add("fish", "рыба");
            _dictionary.Add("finish", "кончать, заканчивать");
            _dictionary.Add("shelf", "полка");
            _dictionary.Add("shelves", "полки");
            _dictionary.Add("ship", "корабль, пароход");
            _dictionary.Add("shy", "скромный, застенчивый");
            _dictionary.Add("tape", "запись, магнитоф. пленка, записывать на пленку");
            _dictionary.Add("name", "имя");
            _dictionary.Add("table", "стол");
            _dictionary.Add("baby", "младенец");
            _dictionary.Add("lady", "дама");
            _dictionary.Add("lazy", "ленивый");
            _dictionary.Add("be lazy", "лениться");
            _dictionary.Add("late", "поздний");
            _dictionary.Add("be late", "опаздывать");
            _dictionary.Add("mail", "почта, корреспонденция");
            _dictionary.Add("say", "сказать (что-либо)");
            _dictionary.Add("pay", "платить, плата");
            _dictionary.Add("day", "день");
            _dictionary.Add("daily", "ежедневно");
            _dictionary.Add("holiday", "праздник, отпуск");
            _dictionary.Add("be on holiday", "быть в отпуске");
            _dictionary.Add("holidays", "каникулы");
            _dictionary.Add("stay", "остаться, остановиться");
            _dictionary.Add("man", "мужчина, человек");
            _dictionary.Add("family", "семья");
            _dictionary.Add("dad", "папа, папочка");
            _dictionary.Add("flat", "квартира");
            _dictionary.Add("lamp", "лампа");
            _dictionary.Add("pad", "блокнот");
            _dictionary.Add("hat", "шляпа");
            _dictionary.Add("ham", "ветчина");
            _dictionary.Add("apple", "яблоко");
            _dictionary.Add("lab", "лаборатория");
            _dictionary.Add("map", "карта (географическая)");
            _dictionary.Add("happy", "счастливый");
            _dictionary.Add("sad", "грустный, печальный");
            _dictionary.Add("bad", "плохой");
            _dictionary.Add("have", "иметь");
            _dictionary.Add("let me have", "дайте мне (что-либо)");
            _dictionary.Add("meat", "мясо");
            _dictionary.Add("meal", "еда, трапеза");
            _dictionary.Add("have meals", "питаться");
            _dictionary.Add("let him have", "пусть он возьмет");
            _dictionary.Add("have fish", "есть рыбу");
            _dictionary.Add("have tea", "пить чай");
            _dictionary.Add("tea", "чай");
            _dictionary.Add("sea", "море");
            _dictionary.Add("by sea", "морем");
            _dictionary.Add("team", "команда, бригада");
            _dictionary.Add("seat", "место, сидение");
            _dictionary.Add("eat", "есть, кушать");
            _dictionary.Add("leave", "уезжать, покидать, оставлять");
            _dictionary.Add("neat", "аккуратный");
            _dictionary.Add("easy", "легкий");
            _dictionary.Add("heavy", "тяжелый, плотный (о еде)");
            _dictionary.Add("soap", "мыло");
            _dictionary.Add("toast", "тост (в честь кого-то), тост (жар. хлеб)");
            _dictionary.Add("boat", "лодка, судно");
            _dictionary.Add("by boat", "лодкой, судном");
            _dictionary.Add("play", "играть");
            #endregion 281 слов
        }
        /// <summary>
        /// Получить словарь
        /// </summary>
        /// <returns>Словарь слов</returns>
        public Dictionary<string, string> GetDictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            foreach (var item in _dictionary)
            {
                dictionary.Add(item.Key, item.Value);
            }

            return dictionary;
        }
        /// <summary>
        /// Получить слова, в которых ошибся пользователь
        /// </summary>
        /// <returns>Словарь слов</returns>
        public Dictionary<string, string> GetDictionaryProblemWork()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            foreach (var item in _dictionaryProblemWork)
            {
                dictionary.Add(item.Key, item.Value);
            }

            return dictionary;
        }
        /// <summary>
        /// Словарь с русского на английский
        /// </summary>
        /// <param name="dictionary">Словарь слов</param>
        public void RussianOnEnglishDictionary(Dictionary<string, string> dictionary, bool isErrorDictionary = false)
        {
            for (int i = dictionary.Count; i != 0; i = dictionary.Count)
            {
                int randomNumber = GetRandomNumber(dictionary.Count, 0);
                string wordKey = dictionary.ElementAt(randomNumber).Value;
                string wordValue = dictionary.ElementAt(randomNumber).Key;

                Console.WriteLine();
                Console.WriteLine($"Введите перевод слова '{wordKey}'");
                Console.WriteLine();

                if (Console.ReadLine().ToLower() == wordValue)
                {
                    Console.WriteLine();
                    Console.WriteLine("Верный ответ!");
                    dictionary.Remove(wordValue);

                    if (isErrorDictionary)
                    {
                        _dictionaryProblemWork.Remove(wordKey);
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Вы ошиблись. Вот верный ответ <<{wordValue}>>");

                    if (isErrorDictionary)
                    {
                        _dictionaryProblemWork.Remove(wordKey);
                    }

                    _errors++;
                    if (!CheckWordInDictionary(wordKey))
                    {
                        AddWordInDictionaryErrors(wordKey, wordValue);
                    }

                    dictionary.Remove(wordValue);
                }

                MessageCountWords(dictionary.Count);
            }

            IncorrectResponse();
        }
        /// <summary>
        /// Словарь с английского на русский
        /// </summary>
        /// <param name="dictionary">Словарь слов</param>
        public void EnglishOnRussianDictionary(Dictionary<string, string> dictionary, bool isErrorDictionary = false)
        {
            for (int i = dictionary.Count; i != 0; i = dictionary.Count)
            {
                MessageCountWords(dictionary.Count);

                int randomNumber = GetRandomNumber(dictionary.Count, 0);
                string wordKey = dictionary.ElementAt(randomNumber).Key;
                string wordValue = dictionary.ElementAt(randomNumber).Value;

                Console.WriteLine();
                Console.WriteLine($"Введите перевод слова '{wordKey}'");
                Console.WriteLine();

                if (Console.ReadLine().ToLower() == wordValue)
                {
                    Console.WriteLine();
                    Console.WriteLine("Верный ответ!");
                    dictionary.Remove(wordKey);

                    if (isErrorDictionary)
                    {
                        _dictionaryProblemWork.Remove(wordKey);
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Вы ошиблись. Вот верный ответ <<{wordValue}>>");

                    if (isErrorDictionary)
                    {
                        _dictionaryProblemWork.Remove(wordKey);
                    }

                    _errors++;
                    if (!CheckWordInDictionary(wordKey))
                    {
                        AddWordInDictionaryErrors(wordKey, wordValue);
                    }
                    
                    dictionary.Remove(wordKey);
                }
            }

            IncorrectResponse();
        }
        /// <summary>
        /// Очистить значения
        /// </summary>
        public void Clear()
        {
            _dictionaryProblemWork.Clear();
            _errors = 0;
        }
        /// <summary>
        /// Обнуление счетчика ошибок
        /// </summary>
        public void ResetErrorCounter()
        {
            _errors = 0;
        }
        /// <summary>
        /// Получить количество проблемныйх слов в словаре
        /// </summary>
        /// <returns>Количество ошибок</returns>
        public int GetCountDictionaryProblemaWork()
        {
            return _dictionaryProblemWork.Count;
        }



        /// <summary>
        /// Получить случайное значение
        /// </summary>
        /// <param name="maxNumber">Предельное число, до которого работает рандом</param>
        /// <returns>Случайное число в рамках предела</returns>
        protected int GetRandomNumber(int maxNumber, int minNumber)
        {
            Random random = new Random();
            return random.Next(minNumber, maxNumber);
        }
        /// <summary>
        /// Добавление слов в словарь ошибок
        /// </summary>
        /// <param name="key">Ключ словаря</param>
        /// <param name="value">Значение словаря</param>
        protected void AddWordInDictionaryErrors(string key, string value)
        {
            _dictionaryProblemWork.Add(key, value);
        }
        /// <summary>
        /// Сообщение о количестве слов
        /// </summary>
        /// <param name="count">Количество</param>
        protected void MessageCountWords(int count)
        {
            Console.WriteLine("");
            Console.WriteLine($"Осталось слов: {count}");
            Console.WriteLine("------------------------------------------------------------------------------");
        }        
        /// <summary>
        /// Неправильные ответы
        /// </summary>
        protected void IncorrectResponse()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------Слова в словаре закончились!---------------------------------------");

            if (_errors != 0)
            {
                Console.WriteLine($"Количество ошибок: {_errors}");
                Console.WriteLine("Вам стоит повторить следующие слова:");

                foreach (var item in _dictionaryProblemWork)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Ни одной ошибки. Вот это колдовство!!!");
            }

            Console.WriteLine("");
        }
        /// <summary>
        /// Проверка ключа в словаре
        /// </summary>
        /// <param name="key">ключ-значение</param>
        /// <returns>True если элемент с таким ключом уже есть, иначе - false</returns>
        protected bool CheckWordInDictionary(string key)
        {
            return _dictionaryProblemWork.ContainsKey(key);
        }
    }
}
