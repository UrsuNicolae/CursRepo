using Bazele.Exceptions;
using Bazele.HW;
using System.Runtime.Serialization;
using System.Text.Json;

namespace Bazele
{
    struct Angajat
    {
        public string Name { get; set; }
        public double Sallary { get; set; }
    }
    static class Exercises
    {

        #region Exercices lesson till 9
        private static Dictionary<string, string> dict = new Dictionary<string, string>() { { "nicolae", "pwd1231" } };
        public static void LeapYear()
        {
            var an = int.Parse(Console.ReadLine());
            if (an % 4 == 0 && an % 100 != 0 || an % 400 == 0)
            {
                Console.WriteLine("Anul este bisect");
            }
            else
            {
                Console.WriteLine("Anul nu este bisect");
            }
        }

        public static void Triangle()
        {
            var laturaUnu = int.Parse(Console.ReadLine());
            var laturaDoi = int.Parse(Console.ReadLine());
            var laturaTrei = int.Parse(Console.ReadLine());

            if (laturaUnu == laturaDoi && laturaDoi == laturaTrei)
            {
                Console.WriteLine("Triunghiul este echilateral");
            }
            else if (laturaUnu == laturaDoi || laturaDoi == laturaTrei || laturaUnu == laturaTrei)
            {
                Console.WriteLine("Triunghiul este isoscel");
            }
            else
            {
                Console.WriteLine("Triunghiul este scalen");
            }
        }

        public static void Calculator()
        {
            Console.WriteLine("Introduceti primul numar:");
            int.TryParse(Console.ReadLine(), out int primulNumar);
            Console.WriteLine("Introduceti al doilea numar:");
            int.TryParse(Console.ReadLine(), out int alDoileaNumar);
            Console.WriteLine("Introduceti operatia:");
            var operatie = Console.ReadLine();
            switch (operatie)
            {
                case "+":
                    Console.WriteLine(primulNumar + alDoileaNumar);
                    break;
                case "-":
                    Console.WriteLine(primulNumar - alDoileaNumar);
                    break;
                case "*":
                    Console.WriteLine(primulNumar * alDoileaNumar);
                    break;
                case "/":
                    if (alDoileaNumar == 0)
                    {
                        Console.WriteLine("Nu se poate imparti la 0");
                        break;
                    }
                    Console.WriteLine(primulNumar / alDoileaNumar);
                    break;
                case "%":
                    Console.WriteLine(primulNumar % alDoileaNumar);
                    break;
                default:
                    Console.WriteLine("Operatie invalida");
                    break;
            }
        }

        public static void CautareSezon()
        {
            int.TryParse(Console.ReadLine(), out int luna);
            switch (luna)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Iarna");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Primavara");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Vara");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Toamna");
                    break;
                default:
                    Console.WriteLine("Luna invalida");
                    break;
            }
        }

        public static void TipulObiectului()
        {
            FindObject("sdklfjaskldjf");
            FindObject(121);
            FindObject('c');
            FindObject(123.23);
            FindObject(new { test = 2 });


            void FindObject(object obj)
            {
                bool foundType = true;
                switch (obj)
                {
                    case string str:
                        Console.WriteLine($"Tipul este string cu valoare: {str}");
                        break;
                    case int integer:
                        Console.WriteLine($"Tipul este int cu valoare: {integer}");
                        break;
                    case double dbl:
                        Console.WriteLine($"Tipul este double cu valoare: {dbl}");
                        break;
                    case bool boolean:
                        Console.WriteLine($"Tipul este bool cu valoare: {boolean}");
                        break;
                    default:
                        foundType = false;
                        break;
                }
                if (!foundType)
                {
                    Console.WriteLine($"Tipul necunoscut cu valoarea: {obj}");
                }
            }
        }

        public static void SuprafataAriei()
        {
            var firstArea = ("Circle", 5);
            var secondArea = ("Rectangle", 5d, 6d);
            var thirdArea = ("Square", 5d);
            var forthArea = ("Triangle", 5d, 6d, 6d);

            CalculateArea(firstArea);
            CalculateArea(secondArea);
            CalculateArea(thirdArea);
            CalculateArea(forthArea);
            CalculateArea(("test", 1));

            void CalculateArea(object obj)
            {
                switch (obj)
                {
                    case ("Circle", int radius):
                        Console.WriteLine($"Aria cercului este: {Math.PI * radius * radius}");
                        break;
                    case ("Rectangle", double width, double height):
                        Console.WriteLine($"Aria dreptunghiului este: {width * height}");
                        break;
                    case ("Square", double lat):
                        Console.WriteLine($"Aria patratului este: {lat * lat}");
                        break;
                    case ("Triangle", double lat1, double lat2, double lat3):
                        Console.WriteLine($"Aria triunghiului este: {lat1 * lat2 * lat3}");
                        break;
                    default:
                        Console.WriteLine("Forma necunoscuta");
                        break;
                }
            }
        }

        public static void SalariuCuBonus()
        {
            CalculateArea(new Angajat { Name = "Manager", Sallary = 1000 });
            CalculateArea(new Angajat { Name = "Vanzator", Sallary = 500 });
            CalculateArea(new Angajat { Name = "Dezvoltator", Sallary = 1200 });

            void CalculateArea(Angajat obj)
            {
                switch (obj)
                {
                    case { Name: "Manager" }:
                        Console.WriteLine($"Salariul cu bonus pentru Manager este: {obj.Sallary + 500}");
                        break;
                    case { Name: "Vanzator" }:
                        Console.WriteLine($"Salariul cu bonus pentru Vanzator este: {obj.Sallary + 300}");
                        break;
                    case { Name: "Dezvoltator" }:
                        Console.WriteLine($"Salariul cu bonus pentru Dezvoltator este: {obj.Sallary + 200}");
                        break;
                    default:
                        Console.WriteLine("Forma necunoscuta");
                        break;
                }
            }
        }

        public static void SumArray()
        {
            /*var arr = new int[5];
            double sum = 0;
            Console.WriteLine($"Citite {arr.Length} elemente de la tastatura");

            arr[0] = int.Parse( Console.ReadLine() );
            sum += arr[0];
            arr[1] = int.Parse( Console.ReadLine() );
            sum += arr[1];
            arr[2] = int.Parse( Console.ReadLine() );
            sum += arr[2];
            arr[3] = int.Parse( Console.ReadLine() );
            sum += arr[3];
            arr[4] = int.Parse( Console.ReadLine() );
            sum += arr[4];
            Console.WriteLine($"Suma medie este {sum / 5}");*/

            var input = ReadArrayElements();
            double[] arr = Array.ConvertAll(input.Split(' '), double.Parse);
            var med = arr.Sum() / arr.Length;
            Console.WriteLine($"Suma medie este {med}");
        }

        public static void InverArray()
        {
            var input = ReadArrayElements();
            var arr = Array.ConvertAll(input.Split(' ').Reverse().ToArray(), int.Parse);
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

        public static void DistincElements()
        {
            var input = ReadArrayElements();
            var arr = input.Split(' ');
            var distinct = arr.Distinct();
            foreach (var i in distinct)
            {
                Console.WriteLine(i);
            }
        }

        public static void MaxMin()
        {
            var input = ReadArrayElements();
            var arr = input.Split(" ").ToArray(); //Array.ConvertAll(input.Split(" "), int.Parse);
            Console.WriteLine($"Elementul maxim este {arr.Max()}");
            Console.WriteLine($"Elementul min este {arr.Min()}");
        }

        public static void StackImplementation()
        {
            Stack<int> stack = new Stack<int>();
            var input = ReadArrayElements("Scriteti numere array-ului separte prin spatiu");
            var elements = Array.ConvertAll(input.Split(" "), int.Parse);
            foreach (var e in elements)
            {
                stack.Push(e);
            }

            Console.WriteLine($"Elementul de top este {stack.Pop()}");
            Console.WriteLine($"Urmatorul element este {stack.Peek()}");
        }

        public static void QueueImplementation()
        {
            Queue<int> queue = new Queue<int>();
            var input = ReadArrayElements("Scriteti numere array-ului separte prin spatiu");
            var elements = Array.ConvertAll(input.Split(" "), int.Parse);
            foreach (var e in elements)
            {
                queue.Enqueue(e);
            }

            Console.WriteLine($"Elementul de top este {queue.Dequeue()}");
            Console.WriteLine($"Urmatorul element este {queue.Peek()}");
        }

        public static void QueueImplementationWithStack()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
        }


        public static string ReadArrayElements(string text = null)
        {
            var textToDispaly = text ?? "Scriteti elementele array-ului separte prin spatiu";
            Console.WriteLine(textToDispaly);
            string input = Console.ReadLine();
            return input;
        }

        public static void ReadStudentGrades()
        {
            Console.WriteLine("Scrie numarul de note optinute");
            var n = int.Parse(Console.ReadLine());
            var note = new List<int>();
            var nrNoteNegative = 0;
            var nrNotePozitive = 0;
            double media = 0;
            for (int i = 0; i < n; i++)
            {
                var nota = int.Parse(Console.ReadLine());
                note.Add(nota);
                if (nota > 5)
                {
                    nrNotePozitive++;
                }
                else
                {
                    nrNoteNegative++;
                }
                media += nota;
            }

            if (nrNoteNegative != 0)
            {
                Console.WriteLine($"Elevul este corigent deoarce are {nrNoteNegative} note negative");
            }
            else
            {
                Console.WriteLine($"Elevul nu este corigent deoarce are {nrNoteNegative} note negative");
            }
            Console.WriteLine($"Media notelor este {media / n}");
        }

        public static void WriteEventNumbers()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
        }

        public static void CheckPrimeNumbers()
        {
            var nr = -1;
            while (nr != 0)
            {
                Console.WriteLine("Scrieti numarul pentru verificare");
                nr = int.Parse(Console.ReadLine());
                var isPrime = true;
                for (int i = 2; i < Math.Sqrt(nr); i++)
                {
                    if (nr % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {

                    Console.WriteLine("Numarul este prim");
                }
                else
                {
                    Console.WriteLine("Numarul nu este prim");
                }
            }
        }

        public static void CalculateSumOfDigits()
        {
            Console.WriteLine("Scrie un numar");
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine($"Suma digiturilor este {sum}");
        }

        public static void DisplayFibonacci()
        {
            var n = int.Parse(Console.ReadLine());
            var a = 0; var b = 1; var c = 1;
            Console.Write(a + " ");
            for (var i = 2; i < n; i++)
            {
                Console.Write(c + " ");
                c = a + b;
                a = b;
                b = c;//12321
            }
        }

        public static void CheckPalindrom()
        {
            var nr = int.Parse(Console.ReadLine());
            var originalNr = nr;
            var reversNr = 0;

            do
            {
                int digit = nr % 10;
                reversNr = reversNr * 10 + digit;
                nr = nr / 10;
            } while (nr != 0);

            if (originalNr == reversNr)
            {
                Console.WriteLine("Numarul este palindrom");
            }
            else
            {
                Console.WriteLine("Numarul nu este palindrom");
            }
        }

        public static void BubbleSort()
        {
            Console.WriteLine("Scrieti numerele separate prin spatiu");

            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int aux = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = aux;
                    }
                }
            }

            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
        }

        public static void Matrice()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrice = new int[n, n];
            var patratic = true;
            Console.WriteLine("Introdu elementele");
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                {
                    matrice[i, j] = int.Parse(input[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i == j && matrice[i, j] != 1) || (i != j && matrice[i, j] != 0))
                    {
                        patratic = false;
                        break;
                    }
                }
            }

            if (patratic)
            {
                Console.WriteLine("Matrice patratica");
            }
            else
            {
                Console.WriteLine("Matrice non patratica");
            }
        }

        public static void BankAccounts()
        {
            var manager = new BankManager();
            manager.AddBankAcount("test", 10);
            manager.DisplayAccounts();
            manager.DeleteAccounts(3);
            manager.DisplayAccounts();
            manager.DeleteAccounts(1);
            manager.DisplayAccounts();
        }

        public static void ConvertNumber(string number)
        {
            /*bool conversionResult = int.TryParse(number, out int num);
            if (conversionResult)
            {
                Console.WriteLine(num);
            }
            else
            {
                throw new FormatException($"{number} is not a valid number");
            }*/

            try
            {
                var num = int.Parse(number);
                Console.WriteLine(num);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Exceptie!!!!!!!!");
                throw ex;
            }
        }

        public static void AccessArrayIndex(int index)
        {
            try
            {
                var arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
                Console.WriteLine(arr[index]);
            }
            catch (IndexOutOfRangeException ex)
            {
            }
            throw new ArgumentOutOfRangeException($"Index {index} is out of range");
        }

        public static void AddKeyValue(string key, string value)
        {
            if (dict.ContainsKey(key))
            {
                throw new ArgumentException($"Key {key} already exists");
            }
            dict[key] = value;
        }



        #endregion

        public static string SerializeAngajat(Angajat angajat)
        {
            if (angajat.Name.Length < 4)
            {
                throw new InvalidDataException($"Property {nameof(angajat.Name)} has invalid length.");
            }

            if (int.TryParse(angajat.Name, out int result))
            {
                throw new InvalidDataException($"Property {nameof(angajat.Name)} is not a valid name.");
            }

            if (angajat.Name.Length > 20)
            {
                throw new InvalidDataException($"Property {nameof(angajat.Name)} has invalid length.");
            }

            if (angajat.Sallary < 0)
            {
                throw new InvalidDataException($"Property {nameof(angajat.Sallary)} has invalid value.");
            }


            try
            {
                return JsonSerializer.Serialize(angajat);
            }
            catch (Exception ex)
            {
                throw new SerializationException();
            }
        }

        public static void WithDraw()
        {
            try
            {
                var bankAcc = new BankAccount();
                bankAcc.Add(1231);
                bankAcc.WithDraw(1230);
                bankAcc.WithDraw(10);
            }
            catch (InsuficientFoundExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static bool CheckForDuplicates(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new EmptyListException("Lista este goala sau nulla");
            }

            return numbers.Count != numbers.Distinct().Count();
        }

        public static int[] ReverseArray(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new EmptyListException("Array-ul este goal sau null");
            }
            return numbers.Reverse().ToArray();
        }

        #region IO
        public static void WriteTextToFile()
        {
            var path = "C:\\notes.txt";
            /*File.Create(path).Close();
            File.WriteAllLines(path, new string[] { "randul 1", "randul 2", "randul 3" });
            Console.WriteLine(File.ReadAllText(path));*/

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Acesta este primul rand");
                sw.WriteLine("Acesta este al doilea rand");
                sw.WriteLine("Acesta este al treilea rand");
            }


            using (StreamReader sr = new StreamReader(path))
            {
                var content = sr.ReadToEnd();
                Console.WriteLine(content);
            }
        }

        public static void ModifyFileAttributes()
        {
            var path = "C:\\example.txt";
            //File.Create(path).Close();

            FileInfo file = new FileInfo(path);
            if ((file.Attributes & FileAttributes.ReadOnly) != FileAttributes.ReadOnly)
            {
                Console.WriteLine("Fisierul nu este readonly");
            }
            file.Attributes &= ~FileAttributes.ReadOnly;
            if ((file.Attributes & FileAttributes.ReadOnly) != FileAttributes.ReadOnly)
            {
                Console.WriteLine("Fisierul nu este readonly");
            }
        }

        public static void ModifiyFileTime()
        {
            var path = "C:\\timestamp.txt";
            File.Create(path).Close();

            var fileInfo = new FileInfo(path);
            Console.WriteLine("Timpul de access initial:" + fileInfo.LastAccessTime);
            Console.WriteLine("Timpul de modificare initial:" + fileInfo.LastWriteTime);

            var newDate = new DateTime(2020, 1, 1, 12, 0, 0);
            fileInfo.LastWriteTime = newDate;
            fileInfo.LastAccessTime = newDate;
            Console.WriteLine("Timpul de access initial:" + fileInfo.LastAccessTime);
            Console.WriteLine("Timpul de modificare initial:" + fileInfo.LastWriteTime);
        }


        public static void CreateDirectory()
        {
            var path = "C:\\NewDir";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if(!File.Exists(path + "\\test.txt"))
            {
                File.Create(path + "\\test.txt").Close();
            }
           
            File.WriteAllText(path + "\\test.txt", "Test content");
            foreach(var file in Directory.GetFiles(path))
            {
                Console.WriteLine(file);
            }
        }

        #endregion
    }
}
