using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1
{
    internal class Program
    {
    #pragma warning disable CS8604 // Possible null reference argument.
        /// <summary>
        /// Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?"
        /// </summary>
        private static void Problema21()
        {
            Console.WriteLine("Ghiciti un numar intre 1 si 1024 prin intrebari de forma numarul este mai mare sau egal decat x ? ");
            int ls = 0;
            int ld = 1025;
            int mid = (ls + ld) / 2; 
            while(ls < ld)
            {
                Console.WriteLine($"Este numarul mai mare sau egal decat {mid}");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string statement = Console.ReadLine();
                if (statement == "da" || statement == "Da" || statement == "DA")
                {
                    ls = mid;
                    mid = (ls + ld) / 2;
                }
                else if (statement == "nu" || statement == "Nu" || statement == "NU")
                {
                    ld = mid;
                    mid = (ls + ld) / 2;
                }
                if (mid % 2 != 0)
                    break;
            }
            Console.WriteLine($"Numarul tau este {mid}");
        }
        /// <summary>
        /// Afisati fractia m/n in format zecimal, cu perioada intre paranteze
        /// </summary>
        private static void Problema20()
        {
            Console.WriteLine("Afisati fractia m / n in format zecimal, cu perioada intre paranteze");
            Console.Write("Introduceti o valoare pentru m = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru n = ");
            int n = int.Parse(Console.ReadLine());
            int parteInt, parteFract;
            parteInt = m / n;
            parteFract = m % n; 
            Console.Write($"{parteInt},");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }
        /// <summary>
        /// Determinati daca un numar e format doar cu 2 cifre care se pot repeta.
        /// </summary>
        private static void Problema19()
        {
            Console.WriteLine("Determinati daca un numar e format doar cu 2 cifre care se pot repeta.");
            Console.Write("Introduceti o valoare pentru n = ");
            int n = int.Parse(Console.ReadLine());
            int[] vect = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            while(n > 0)
            {
                vect[n % 10]++;
                n /= 10;
            }
            int counter = 0;
            for (int i = 0; i < vect.Length; i++)
            {
                if(vect[i] != 0)
                    counter++;
            }
            if (counter == 2)
                Console.WriteLine("Numarul este format doar din 2 cifre");
            else
                Console.WriteLine("Numarul nu este format doar din 2 cifre");
        }
        /// <summary>
        /// Afisati descompunerea in factori primi ai unui numar n.
        /// </summary>
        private static void Problema18()
        {
            Console.WriteLine("Afisati descompunerea in factori primi ai unui numar n.");
            Console.Write("Introduceti o valoare pentru n = ");
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            while(n%2==0)
            {
                counter++;
                n /= 2;
            }
            if (counter != 0)
                Console.WriteLine($"2 ^ {counter}");
            for (int i = 3; i < n / 2; i += 2)
            {
                counter = 0;
                while (n % i == 0)
                {
                    counter++;
                    n /= i;
                }
                if(counter != 0)
                    Console.WriteLine($" x {i} ^ {counter}");
            }
        }
        /// <summary>
        /// Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere.
        /// </summary>
        private static void Problema17()
        {
            Console.WriteLine("Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere.");
            Console.Write("Introduceti o valoare pentru a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru b = ");
            int b = int.Parse(Console.ReadLine());
            int n = a, m = b;
            while (n != 0 && m != 0)
            {
                if (n > m)
                    n -= m;
                else
                    m -= n;
            }
            Console.WriteLine($"C.M.M.D.C. = {Math.Max(n, m)}");
            Console.WriteLine($"C.M.M.M.C. = {(a*b)/ Math.Max(n, m)}");
        }
        /// <summary>
        /// Se dau 5 numere. Sa se afiseze in ordine crescatoare.
        /// </summary>
        private static void Problema16()
        {
            Console.WriteLine("Se dau 5 numere. Sa se afiseze in ordine crescatoare.");
            Console.Write("Introduceti o valoare pentru a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru c = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru d = ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru e = ");
            int e = int.Parse(Console.ReadLine());

            while( !(a < b && b < c && c < d && d < e))
            {
                if (a > b)
                {
                    a = a ^ b;
                    b = b ^ a;
                    a = a ^ b;

                    if (b > c)
                    {
                        b = b ^ c;
                        c = c ^ b;
                        b = b ^ c;

                        if (c > d)
                        {
                            c = c ^ d;
                            d = d ^ c;
                            c = c ^ d;

                            if (d > e)
                            {
                                d = d ^ e;
                                e = e ^ d;
                                d = d ^ e;
                            }
                        }
                    }
                }
                if (b > c)
                {
                    b = b ^ c;
                    c = c ^ b;
                    b = b ^ c;

                    if (c > d)
                    {
                        c = c ^ d;
                        d = d ^ c;
                        c = c ^ d;

                        if (d > e)
                        {
                            d = d ^ e;
                            e = e ^ d;
                            d = d ^ e;
                        }
                    }
                }
                if (c > d)
                {
                    c = c ^ d;
                    d = d ^ c;
                    c = c ^ d;

                    if (d > e)
                    {
                        d = d ^ e;
                        e = e ^ d;
                        d = d ^ e;
                    }
                }
                if (d > e)
                {
                    d = d ^ e;
                    e = e ^ d;
                    d = d ^ e;
                }
            }
            Console.WriteLine($"{a}, {b}, {c}, {d}, {e}");
        }
        /// <summary>
        /// Se dau 3 numere. Sa se afiseze in ordine crescatoare.
        /// </summary>
        private static void Problema15()
        {
            Console.WriteLine("Se dau 3 numere. Sa se afiseze in ordine crescatoare.");
            Console.Write("Introduceti o valoare pentru a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru c = ");
            int c = int.Parse(Console.ReadLine());
            if(a > b)
            {
                a = a ^ b;
                b = b ^ a;
                a = a ^ b;
            }
            if(c > b)
                Console.WriteLine($"{a}, {b}, {c}");
            else if (c < b && c > a)
                Console.WriteLine($"{a}, {c}, {b}");
            else
                Console.WriteLine($"{c}, {a}, {b}");



        }
        /// <summary>
        /// Determianti daca un numar n este palindrom.
        /// </summary>
        private static void Problema14()
        {
            Console.WriteLine("Determianti daca un numar n este palindrom.");
            Console.Write("Introduceti o valoare pentru n = ");
            int n = int.Parse(Console.ReadLine());
            int palin = 0;
            int verif = n;
            while (n > 0)
            {
                palin = palin * 10 + n % 10 ; 
                n /= 10;
            }
            if (palin == verif)
                Console.WriteLine("Este palindrom");
            else
                Console.WriteLine("Nu este palindrom");
        }
        /// <summary>
        /// Determianti cati ani bisecti sunt intre anii y1 si y2.
        /// </summary>
        private static void Problema13()
        {
            Console.WriteLine("Determianti cati ani bisecti sunt intre anii y1 si y2.");
            Console.Write("Introduceti o valoare pentru y1 = ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru y2 = ");
            int y2 = int.Parse(Console.ReadLine());
            for (int i = y1; i <= y2; i++)
            {
                if (i % 10 == 0 && i % 100 != 0 || i % 400 == 0)
                    Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]
        /// </summary>
        private static void Problema12()
        {
            Console.WriteLine("Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]");
            Console.Write("Introduceti o valoare pentru n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru b = ");
            int b = int.Parse(Console.ReadLine());
            if(a > n / 2 && b < n)
            {
                Console.WriteLine("n nu are divizori in intervalul [a,b]");
                return;
            }
            
            for (int i = a; i < n / 2 && i <= b; i++)
            {
                if (n % i == 0)
                    Console.WriteLine(i);
            }

            if (a > n / 2 && b == n)
            {
                Console.WriteLine(b);
            }

        }
        /// <summary>
        /// Afisati in ordine inversa cifrele unui numar n.
        /// </summary>
        private static void Problema11()
        {
            Console.WriteLine("Afisati in ordine inversa cifrele unui numar n.");
            Console.Write("Introduceti o valoare pentru n = ");
            int n = int.Parse(Console.ReadLine());
            while(n > 0)
            {
                Console.Write(n % 10);
                n /= 10;
            }
        }
        /// <summary>
        /// Test de primalitate: determinati daca un numar n este prim.
        /// </summary>
        private static void Problema10()
        {
            Console.WriteLine("Test de primalitate: determinati daca un numar n este prim.");
            Console.Write("Introduceti o valoare pentru n = ");
            int n = int.Parse(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine("Nu este prim");
                return;
            }
            if (n == 2)
            {
                Console.WriteLine("Este prim");
                return;
            }    
                
            if (n % 2 == 0)
            {
                Console.WriteLine("Nu este prim");
                return;
            }
            for(int i = 3; i*i < n; i+=2)
            {
                if(n % i == 0)
                {
                    Console.WriteLine("Nu este prim");
                    return;
                }
            }
            Console.WriteLine("Este prim");

        }
        /// <summary>
        /// Afisati toti divizorii numarului n.
        /// </summary>
        private static void Problema9()
        {
            Console.WriteLine("Afisati toti divizorii numarului n.");
            Console.Write("Introduceti o valoare pentru n = ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i < n / 2; i++)
            {
                if (n % i == 0)
                    Console.WriteLine(i);
            }
            Console.WriteLine(n);

        }
        /// <summary>
        /// Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.
        /// </summary>
        private static void Problema8()
        {
            Console.WriteLine("Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.");
            Console.Write("Introduceti o valoare pentru a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru b = ");
            int b = int.Parse(Console.ReadLine());
            a = a ^ b;
            b = b ^ a;
            a = a ^ b;
            Console.WriteLine($"Valoarea lui a este: {a}");
            Console.WriteLine($"Valoarea lui b este: {b}");
        }
        /// <summary>
        /// Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.
        /// </summary>
        private static void Problema7()
        {
            Console.WriteLine("Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.");
            Console.Write("Introduceti o valoare pentru a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru b = ");
            int b = int.Parse(Console.ReadLine());
            int c = b;
            b = a;
            a = c;
            Console.WriteLine($"Valoarea lui a este: {a}");
            Console.WriteLine($"Valoarea lui b este: {b}");
        }
        /// <summary>
        /// Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.
        /// </summary>
        private static void Problema6()
        {
            Console.WriteLine("Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.");
            Console.Write("Introduceti o valoare pentru a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru c = ");
            double c = double.Parse(Console.ReadLine());
            if (a < b + c && b < c + a && c < b + a)
                Console.WriteLine("Laturile a, b si c pot forma un triunghi");
            else
                Console.WriteLine("Laturile a, b si c nu pot forma un triunghi");


        }
        /// <summary>
        /// Extrageti si afisati a k-a cifra de la sfarsitul unui numar.
        /// </summary>
        private static void Problema5()
        {
            Console.WriteLine("Extrageti si afisati a k-a cifra de la sfarsitul unui numar.");
            Console.Write("Introduceti o valoare pentru n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru k = ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k - 1; i++)
            {
                n /= 10;
            }
            Console.WriteLine($"A k-a cifra a lui n este: {n % 10}");
            
        }
        /// <summary>
        /// Detreminati daca un an y este an bisect.
        /// </summary>
        private static void Problema4()
        {
            Console.WriteLine("Detreminati daca un an y este an bisect.");
            Console.Write("Introduceti un an: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 10 == 0 && n % 100 != 0 || n % 400 == 0)
                Console.WriteLine($"{n} este an bisect");
            else
                Console.WriteLine($"{n} nu este an bisect");
        }
        /// <summary>
        /// Determinati daca n se divide cu k, unde n si k sunt date de intrare.
        /// </summary>
        private static void Problema3()
        {
            Console.WriteLine("Determinati daca n se divide cu k, unde n si k sunt date de intrare.");
            Console.Write("Introduceti o valoare pentru n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru k = ");
            int k = int.Parse(Console.ReadLine());
            if(n % k == 0)
                Console.WriteLine("n este divizibil cu k");
            else
                Console.WriteLine("n nu este divizibil cu k");

        }
        /// <summary>
        /// Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.
        /// </summary>
        private static void Problema2()
        {
            Console.WriteLine("Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.");
            Console.Write("Introduceti o valoare pentru a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru c = ");
            double c = double.Parse(Console.ReadLine());
            double x1, x2, delta;
            delta = b * b - 4 * (a * c);
            switch (delta)
            {
                case > 0:
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Valorile lui x sunt:");
                    Console.WriteLine($"x1 = {x1}");
                    Console.WriteLine($"x2 = {x2}");
                    break;
                case 0:
                    x1 = -b / (2 * a);
                    Console.WriteLine($"Valoarea lui x este: {x1}");
                    break;
                case < 0:
                    delta = (-1) * delta;
                    x1 = ((-b) / (2 * a));
                    x2 = ((-b) / (2 * a));
                    Console.WriteLine("Valorile lui x sunt:");
                    Console.WriteLine($"x1 = {x1} + ({(Math.Sqrt(delta))}*i)/{(2 * a)}");
                    Console.WriteLine($"x2 = {x2} - ({(Math.Sqrt(delta))}*i)/{(2 * a)}");
                    break;
            }

        }
        /// <summary>
        /// Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.
        /// </summary>
        private static void Problema1()
        {
            Console.WriteLine("Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.");
            Console.Write("Introduceti o valoare pentru a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru b = ");
            double b = double.Parse(Console.ReadLine());
            double x;
            x = (-b) / a;
            Console.Write($"Valoarea lui x este:{x}");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Alegeti problema pe care doriti sa o rezolvati:");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Problema1();
                    break;

                case 2:
                    Problema2();
                    break;

                case 3:
                    Problema3();
                    break;

                case 4:
                    Problema4();
                    break;

                case 5:
                    Problema5();
                    break;

                case 6:
                    Problema6();
                    break;

                case 7:
                    Problema7();
                    break;

                case 8:
                    Problema8();
                    break;

                case 9:
                    Problema9();
                    break;

                case 10:
                    Problema10();
                    break;

                case 11:
                    Problema11();
                    break;

                case 12:
                    Problema12();
                    break;

                case 13:
                    Problema13();
                    break;

                case 14:
                    Problema14();
                    break;

                case 15:
                    Problema15();
                    break;

                case 16:
                    Problema16();
                    break;

                case 17:
                    Problema17();
                    break;

                case 18:
                    Problema18();
                    break;

                case 19:
                    Problema19();
                    break;

                case 20:
                    Problema20();
                    break;

                case 21:
                    Problema21();
                    break;


            }
        }
    }
}
