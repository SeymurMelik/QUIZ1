using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 23, 56, 6 };
            int i = 2;
            string u = "2";
            string Element = "Seymurr";
            char SelectedElement = 'r';
            int UcMertebea = 128;
            int Ededkok = 25;
            Rage(ref i);
            CheckInteger(ref u);
            Console.WriteLine(SelectedString(Element,SelectedElement));
            Console.WriteLine(NeqederChar(Element, SelectedElement));
            UceBolunen(3,6,9,12, 11);
            Menfi(-12,-1,-1,23,12);
            Kok(Ededkok);
            ReverseArray(12, 1, 5, 23, 67);
            ArrayUzunluq(a ,23,43,45,17,67);
            UcMertebe(UcMertebea);
            Mertebe(UcMertebea);
            CheckBoyuk();
        }

        public static void Rage(ref int i)
        {
            //1
            switch (i)
            {
                case 2:
                    Console.WriteLine("ragededi");
                    return;
                case 3:
                    Console.WriteLine("ragededi");
                    return;
                case 4:
                    Console.WriteLine("ragededi");
                    return;
                case 5:
                    Console.WriteLine("ragededi");
                    return;
                case 6:
                    Console.WriteLine("ragededi");
                    return;
                case 7:
                    Console.WriteLine("ragededi");
                    return;
                case 8:
                    Console.WriteLine("ragededi");
                    return;
                case 9:
                    Console.WriteLine("ragededi");
                    return;
                default:
                    Console.WriteLine("rangede deyil");
                    return;
            }
        }
        static bool SelectedString(string a,char selectedElement)
        {
            //3
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == selectedElement)
                {
                    return true;
                }
            }
            return false;
        }

        public static void CheckInteger(ref string i)
        {
            //4
            switch (i)
            {
                case "1":
                    Console.WriteLine("number");
                    return;
                case "2":
                    Console.WriteLine("number");
                    return;
                case "3":
                    Console.WriteLine("number");
                    return;
                case "4":
                    Console.WriteLine("number");
                    return;
                case "5":
                    Console.WriteLine("number");
                    return;
                case "6":
                    Console.WriteLine("number");
                    return;
                case "7":
                    Console.WriteLine("number");
                    return;
                case "8":
                    Console.WriteLine("number");
                    return;
                case "9":
                    Console.WriteLine("number");
                    return;
                case "0":
                    Console.WriteLine("number");
                    return;
                default:
                    Console.WriteLine("symbol");
                    return;
            }
        }

        public static int UceBolunen(params int[] a)
        {
            //6
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 3 == 0)
                {
                    sum += a[i];
                }

            }
            Console.WriteLine(sum);
            return sum;
        }

        public static int Menfi(params int[] a)
        {
            //8
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    sum += a[i];
                }

            }
            Console.WriteLine(sum);
            return sum;
        }

        public static int Kok(int a)
        {
            Console.WriteLine(Math.Sqrt(a));
            return a;
        }

        public static void ReverseArray(params int[] a)
        {
            //13
            Array.Sort(a);
            Array.Reverse(a);
            foreach (var item in a)
            {
                Console.Write(item);
            }
            
        }

        public static void VurmaCedveli(params int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {

            }
        }

        public static void ArrayUzunluq(int[] b,params int[] a)
        {
            //int element = 0;
            Array.Resize(ref b,b.Length + 1);
            b[b.Length - 1] = a.Length;
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }
        }

        public static void CheckBoyuk()
        {
            //15
            string a = "Seymur Mustafayev";

            string[] strings = { "Seymur", "Mustafayev" };
            Console.WriteLine(strings[0]);
            Console.WriteLine(strings[1]);
            //16
            string str = string.Join(" ", strings);
            Console.WriteLine(str);
        }

        public static int UcMertebe(int i)
        {
            //11
            int ikinciDeyer = i % 10;
            i = (i / 10) - (i % 10 / 10);
            int ucuncuDeyer = i % 10;
            i = (i / 10) - (i % 10 / 10);
            Console.WriteLine(i + ikinciDeyer + ucuncuDeyer);
            return i;
        }

        public static int Mertebe(int y)
        {
            //10
            int count = 0;
            int a;
            for (int i = 1; i < y; i++)
            {
                if (y < 0)
                {
                    

                }
                else
                {
                    a = y / 10;
                    count++;
                }
                
            }
            Console.WriteLine(count);
            return count;
        }

        static int NeqederChar(string a, char selectedElement)
        {
            //7
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == selectedElement)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
