//using System.Runtime.CompilerServices;


//class Student
//{
//    public string name;
//    public int age;
//    public double rating;

//    public void printName()
//    {
//        Console.WriteLine($"Привет, меня зовут {name} мне {age} и мой рейтинг {rating}");
//    }
//}

//public class Programm
//{
//    public static void Main()
//    {
//        Student student1 = new Student();
//        student1.name = "Андрей";
//        student1.age = 13;
//        student1.rating = -1;
//        student1.printName();

//        student1.name = "Олег";
//        student1.printName();

//        Student student2 = new Student();
//        student2.name = "Валерий";
//        student2.age = 18;
//        student2.rating = -10;
//        student2.printName();

//        int [] numArray;
//        numArray = new int [10];
//        numArray[0] = 1;
//        numArray[1] = 2;

//        int[] numArray2 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine($"{numArray[i]} ");
//        }
//    }
//}



//Random random = new Random();
//Console.WriteLine("Введите количество попыток:");
//string STries = Console.ReadLine();
//int tries = Convert.ToInt32(STries);
//Console.Clear();
//int pcNumber = random.Next(0, 101);
//bool ugadal = false;
//Console.WriteLine($"Загаданное число: { pcNumber}");
//Console.WriteLine($"Осталось попыток: {tries}");
//while (ugadal == false & tries != -1)
//{
//    string playerNumber = Console.ReadLine();
//    int Number = Convert.ToInt32(playerNumber);
//    if (Number == pcNumber & ugadal != true & tries != 0)
//    {
//        Console.WriteLine("Ты угадал");
//        ugadal = true;
//    }
//    else if (Number != pcNumber & ugadal != true & tries != 0)
//    {
//        ugadal = false;
//        tries--;
//        if (Number > pcNumber)
//        {
//            Console.WriteLine("Ты не угадал");
//            Console.WriteLine("Загаданное число меньше твоего");
//            Console.WriteLine($"Осталось попыток: {tries}");
//        }
//        else
//        {
//            Console.WriteLine("Ты не угадал");
//            Console.WriteLine("Загаданное число больше твоего");
//            Console.WriteLine($"Осталось попыток: {tries}");
//        }
//    }
//    if (Number != pcNumber & ugadal != true & tries == 0)
//    {
//        Console.Clear();
//        Console.WriteLine("Попытки закончились");
//        ugadal = true;
//    }
//}








//int[] array = [1, 0, 99, 100, 67, 44, 78, 5, 90, 45];
//int max = array[0];
//int avg = 0;

//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] > max)
//    {
//        max = array[i];
//    }

//    avg += array[i];
//}

//        Console.WriteLine(max);
//Console.WriteLine(avg/array.Length);




//double a = Convert.ToDouble(Console.ReadLine());
//double b = Convert.ToDouble(Console.ReadLine());

//Summary(a, b);
//void Summary(double c, double d)
//{
//    Console.WriteLine(c + d);
//}



//double c = a + b;
//Console.WriteLine(c);


//public class Auto
//{
//    public string model;
//    public int speed;
//    public string color;

//    public int Moving()
//    {
//        return speed * 1;
//    }
//}

//public class Programm
//{
//    public static void Main()
//    {
//        int[] a = { 5, 6, 7 };
//        int[] b = a;
//        a[0] = 10;
//        Console.WriteLine(a[0]);
//        Console.WriteLine(b[0]);

//        Auto Lada = new Auto();
//        Auto Nadezhda = new Auto();
//        Lada.speed = 100;
//        Nadezhda.speed = 200;

//        Console.WriteLine(Lada.Moving());
//        Console.WriteLine(Nadezhda.Moving());
//    }
//}



//using System.Diagnostics.Tracing;
//using System.Text;

//public class Programm
//{
//    public static void Main()
//    {
//        Console.WriteLine("Введите слова: ");
//        string words = Console.ReadLine();
//        int number = words.Length;
//        Console.WriteLine($"Количество символов в строке: {number}");

//        string[] arrayWords = words.Split(" ");

//        string longestWord = arrayWords[0];
//        foreach(string word in arrayWords)
//        {
//            if (longestWord.Length < word.Length)
//            {
//                longestWord = word;
//            }
//            else
//            {
//                longestWord = longestWord;
//            }

//            StringBuilder sb = new StringBuilder();
//            for (int i = 0; i < 100; i++)
//            {
//                sb.Append("Hello");
//            }
//            string new_string = sb.ToString();
//            Console.WriteLine(new_string);
//        }
//        Console.WriteLine($"Самое длинное слово: {longestWord}");
//    }
//}



//using System.Security.Cryptography.X509Certificates;

//public class Programm
//{
//    public static void Main()
//    {
//        MyAction message;
//        message = FirstMessage;

//        message();
//        message += SecondMessage;
//        message();

//        List<string> tasklist = new List<string>();
//        while (true)
//        {
//            Console.WriteLine("--- Спосик дел ---");
//            Console.WriteLine("1. Добавить задачу");
//            Console.WriteLine("2. Просмотреть задачу");
//            Console.WriteLine("3. Удалить задачу");
//            Console.WriteLine("4. Выйти");
//            Console.WriteLine("Выберите команду: ");
//            // C - create R - read U - update D - delete

//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    AddTask();
//                    break;
//                case "2":
//                    ViewTask();
//                    break;
//                case "3":
//                    RemoveTask();
//                    break;
//                case "4":
//                    // Exit();
//                    Console.WriteLine("Выход...");
//                    return;
//                default:
//                    Console.WriteLine("Неверное название команды");
//                    break;
//            }

//            void AddTask()
//            {
//                Console.Clear();
//                Console.WriteLine("Введите задачу: ");
//                string zadacha = Console.ReadLine();
//                tasklist.Add(zadacha);
//                Console.WriteLine($"Задача '{zadacha}' успешно добавлена!");
//            }

//            void ViewTask()
//            {
//                if (tasklist.Count == 0)
//                {
//                    Console.WriteLine("Список пуст");
//                }
//                else
//                {
//                    for (int i = 0; i < tasklist.Count; i++)
//                    {
//                        Console.WriteLine($"{i + 1}. {tasklist[i]}");
//                    }
//                }
//            }

//            void RemoveTask()
//            {
//                Console.Clear();
//                Console.WriteLine("--- Выбор варианта удаления ---");
//                Console.WriteLine("1. Удалить по номеру");
//                Console.WriteLine("2. Удалить по значению");
//                Console.WriteLine("3. Удалить всё");
//                Console.WriteLine("Выберите команду: ");

//                string deleteChoise = Console.ReadLine();
//                switch (deleteChoise)
//                {
//                    case "1":
//                        Console.WriteLine("Напишите номер: ");
//                        string g = Console.ReadLine();
//                        int g1 = int.Parse(g);
//                        tasklist.RemoveAt(g1 - 1);
//                        Console.WriteLine("Задача удалена");
//                        return;
//                    case "2":
//                        Console.WriteLine("Напишите значение: ");
//                        string e = Console.ReadLine();
//                        tasklist.Remove(e);
//                        Console.WriteLine("Задача удалена");
//                        return;
//                    case "3":
//                        tasklist.Clear();
//                        Console.WriteLine("Все задачи удалены");
//                        return;
//                    default:
//                        Console.WriteLine("Неверное название команды");
//                        break;
//                }
//            }
//        }
//    }


//    public delegate void MyAction();
//    public static void FirstMessage()
//    {
//        Console.WriteLine("1");
//    }
//    public static void SecondMessage()
//    {
//        Console.WriteLine("2");
//    }
//}



//public class Programm
//{
//    public static void Main()
//    {
//        List<float> numbers = new List<float> {99, 60, 34, 5, 43, 82, 76, 33, 21, 12};
//        List<float> chet_numbers = new List<float> { };

//        for (int i = 0; i < numbers.Count; i++)
//        {
//            if (numbers[i] % 2 == 0)
//            {
//                chet_numbers.Add(numbers[i]);
//            }
//        }



//        var query = numbers.Where(n => n % 2 == 1);

//        numbers.Add(7);

//        var query_select = numbers.Select(n => n * n);

//        var sort_select = numbers.OrderByDescending(n => n);

//        var long_query = numbers.Where(n => n > 20).Select(n => n * 0.05).OrderBy(n => n).ThenBy(n => n);










//        foreach (float num in long_query)
//        {
//            Console.WriteLine(num + " ");
//        }
//    }
//}



using System.ComponentModel;

public class Programm
{
    public  static  void    Main()
    {
        List<string>    category = new List<string> {"Мебель", "Электроника",  "Бытовая    химия", "Мебель",   "Продукты", "Программы"};
        //var firstElement = category.First(cat => cat.StartsWith(""));
        //var firstElement = category.FirstOrDefault(cat => cat.StartsWith("g"));

        //string word;
        //word = "fghjgjgh";
        //string word2 = null;
        //if (firstElement==null)
        //{
        //    Console.WriteLine("Неудалосьнайтизначение");
        //}
        //else
        //{
        //    word2 = firstElement;
        //}
        //var element = category.Single(cat => cat.StartsWith("Э"));
        //var element = category.Any(cat => cat.StartsWith("Ф"));
        //bool element = category.All(cat => cat.Length>5);

        //var groupCat = category.GroupBy(cat => cat + 1);
        //foreach (var group in groupCat)
        //{
        //    Console.WriteLine($"Категория: {group.Key}");
        //    foreach (var element in group)
        //    {
        //        Console.WriteLine(element);
        //    }
        //}

        //Console.WriteLine(element);

        Dictionary<string, double> productPrice = new Dictionary<string, double>
        {
            {"Хлеб", 35.0}, {"Огурцы", 60}
        };

        productPrice.Add("Масло", 325);

        productPrice["Колбаса"] = 500;
        productPrice.Remove("Огурцы");
        double price = productPrice["Хлеб"];
        foreach (KeyValuePair<string, double> pair in productPrice) {
            Console.WriteLine($"Продукт: {pair.Key} \nСтоимость: {pair.Value}");
        }
        bool g = productPrice.ContainsKey("Майонез");
        bool h = productPrice.ContainsValue(35);

        double perem;

        Console.WriteLine(g);
        Console.WriteLine(h);


        productPrice.TryGetValue("Хлеб", out perem);
        Console.WriteLine(perem);

        string k = productPrice.FirstOrDefault(x => x.Value == 35).Key;
        Console.WriteLine(k);
    }
}