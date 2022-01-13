using System;

namespace probleme_fp
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1_I();
            //P2_I();
            //P3_I();
            //P4_I();
            //P5_I();
            //P6_I();
            //P7_I();
            //P8_I();
            //P9_I();
            //P10_I();
            //P11_I();
            //P12_I();
            //P13_I();
            //P14_I();
            //P15_I();
            //P16_I();
            //P17_I();
            //P18_I();
            //P19_I();
            //P20_I();
            //P21_I();
            //P1_II();
            //P2_II();
            //P3_II();
            //P4_II();
            //P5_II();
            //P6_II();
            //P7_II();
            //P8_II();
            //P9_II();
            //P10_II();
            //P11_II();
            //P12_II();
            //P13_II();
            //P14_II();
            //P15_II();
            //P16_II();
            //P1_III();
            //P2_III();
            //P3_III();
            //P4_III();
            //P5_III();
            //P6_III();
            //P7_III();
            //P8_III();
            //P9_III();
            //P10_III();
            //P11_III();
            //P12_III();
            //P13_III();
            //P14_III();
            //P15_III();
            //P16_III();
        }
        //SETUL 1
        private static void P1_I()
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int x;
            x = -b / a;
            Console.WriteLine(x);
        }
        private static void P2_I()
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            int delta, x1, x2;

            delta = b ^ 2 - 4 * a * c;
            x1 = (-b + delta) / (2 * a);
            x2 = (-b - delta) / (2 * a);

            Console.WriteLine(x1);
            Console.WriteLine(x2);

        }
        private static void P3_I()
        {
            int n, k;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            if (n % k == 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

        }
        private static void P4_I()
        {
            int y;
            y = int.Parse(Console.ReadLine());
            if (y % 4 == 0 && y % 100 != 0)
                Console.WriteLine("este an bisect");
            else
                if (y % 400 == 0)
                Console.WriteLine("este an bisect");
            else
                Console.WriteLine("nu este an bisect");
        }
        private static void P5_I()
        {
            int numar, k;
            numar = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            int n = 0;
            while (k != 0)
            {
                n = numar % 10;
                numar = numar / 10;
                k--;
            }
            Console.WriteLine(n);

        }
        private static void P6_I()
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine("formeaza un triunghi");
            else
                Console.WriteLine("nu formeaza un triunghi");

        }
        private static void P7_I()
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int aux;
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
        private static void P8_I()
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        private static void P9_I()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int divizor;
            for (divizor = 2; divizor <= n / 2; divizor++)
            {
                if (n % divizor == 0)
                    Console.WriteLine($"{divizor} ");
            }

        }
        private static void P10_I()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int i, ok = 1;
            for (i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    ok = 0;
                    break;
                }
            }
            if (ok == 0)
                Console.WriteLine($"{n} nu este prim");
            else
                Console.WriteLine($"{n} este prim");

        }
        private static void P11_I()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                Console.Write(n % 10);
                n = n / 10;
            }
        }
        private static void P12_I()
        {
            int a, b, n;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            int nr = 0, i;
            for (i = a; i <= b; i++)
            {
                if (i % n == 0)
                    nr++;
            }
            Console.WriteLine(nr);

        }
        private static void P13_I()
        {
            int y1, y2;
            y1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            int i, nr = 0;
            for (i = y1; i <= y2; i++)
            {
                if (i % 4 == 0 && i % 100 != 0)
                    nr++;
                else
                if (i % 400 == 0)
                    nr++;
            }
            Console.WriteLine(nr);

        }
        private static void P14_I()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int ogl = 0, x = 0;
            x = n;
            while (n != 0)
            {
                ogl = ogl * 10 + n % 10;
                n = n / 10;
            }
            if (x == ogl)
                Console.WriteLine($"{x} este palindrom");
            else
                Console.WriteLine($"{x} nu este palindrom");

        }
        private static void P15_I()
        {
            int nr1, nr2, nr3;
            nr1 = int.Parse(Console.ReadLine());
            nr2 = int.Parse(Console.ReadLine());
            nr3 = int.Parse(Console.ReadLine());
            int aux = 0;
            if (nr1 > nr2)
            {
                aux = nr1;
                nr1 = nr2;
                nr2 = aux;
            }
            else
            {
                if (nr2 > nr3)
                {
                    aux = nr2;
                    nr2 = nr3;
                    nr3 = aux;
                    if (nr2 > nr1)
                    {
                        aux = nr2;
                        nr2 = nr1;
                        nr1 = aux;
                    }
                }
                Console.WriteLine($"{nr1} {nr2} {nr3}");

            }
        }
        private static void P16_I()
        {

        }
        private static void P17_I()
        {
            ///cmmdc
            int n, m;
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            while (n != m)
            {
                if (n > m)
                    n = n - m;
                else
                    m = m - n;
            }
            Console.WriteLine($"cmmdc e {n}");
            ///cmmmc
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            n = a;
            m = b;
            while (n != m)
            {
                if (n < m)
                    n = n + a;
                else
                    m = m + b;
            }
            Console.WriteLine($"cmmmc e {n}");

        }
        private static void P18_I()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int d = 2, p;
            while (n > 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    p++;
                    n = n / d;
                }
                if (p > 0)
                    Console.Write($"{d}^{p} x ");
                d++;
            }
        }
        private static void P19_I()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int a, b = -1, k;
            k = n;
            a = n % 10;
            n = n / 10;
            while (b == -1)
            {
                if (n % 10 != a)
                    b = n % 10;
                n = n / 10;
            }
            Console.WriteLine($"{a}, {b}");
            int ok = 0;
            while (n != 0)
            {
                if (n % 10 != a)
                {
                    if (n % 10 != b)
                        ok = 1;
                }
                n = n / 10;
            }
            if (ok == 0)
                Console.WriteLine("da!");
            if (ok == 1)
                Console.WriteLine("nu!");

        }
        private static void P20_I()
        {

        }
        private static void P21_I()
        {
            Random rd = new Random();
            int nr = rd.Next(1, 1024);
            int a = int.Parse(Console.ReadLine());

            if (a == nr)
                Console.WriteLine("ati ghicit!");

            while (a != nr)
            {
                a = int.Parse(Console.ReadLine());
                if (a < nr)
                    Console.WriteLine("numarul este prea mic!");
                if (a > nr)
                    Console.WriteLine("numarul este prea mare!");
                if (a == nr)
                    Console.WriteLine("ati ghicit!");

            }
        }
        //SETUL 2
        private static void P1_II()
        {
            int n, nr = 0, x;
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                    nr++;
                n--;
            }
            Console.WriteLine(nr);
        }
        private static void P2_II()
        {
            int n, nrpoz = 0, nrneg = 0, nr0 = 0, x;
            Console.WriteLine("introduceti n");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                x = int.Parse(Console.ReadLine());
                if (x > 0)
                    nrpoz++;
                if (x < 0)
                    nrneg++;
                if (x == 0)
                    nr0++;
                n--;
            }
            Console.WriteLine($"numere pozitive: {nrpoz}");
            Console.WriteLine($"numere negative: {nrneg}");
            Console.WriteLine($"numere egale cu 0: {nr0}");
        }
        private static void P3_II()
        {
            int n, suma = 0, produs = 1;
            Console.WriteLine("introduceti n");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                suma = suma + n;
                produs = produs * n;
                n--;
            }
            Console.WriteLine($"suma este {suma}");
            Console.WriteLine($"produsul este {produs}");
        }
        private static void P4_II()
        {
            int n, x, poz = 0, a, nr = 0;
            Console.WriteLine("introduceti n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti a");
            a = int.Parse(Console.ReadLine());
            int ok = 0;
            while (n != 0)
            {
                x = int.Parse(Console.ReadLine());
                if (x == a)
                {
                    nr = poz;
                    ok = 1;
                }
                poz++;
                n--;
            }
            if (ok == 1)
                Console.WriteLine(nr);
            else
                Console.WriteLine(-1);
        }
        private static void P5_II()
        {
            int n, x, poz = 0, nr = 0;
            Console.WriteLine("introduceti n");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                x = int.Parse(Console.ReadLine());
                if (x == poz)
                {
                    nr++;
                }
                poz++;
                n--;
            }
            Console.WriteLine(nr);
        }
        private static void P6_II()
        {
            int n, x, v;
            Console.WriteLine("introduceti n");
            n = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            int ok = 1;
            while (n - 1 != 0)
            {
                v = x;
                x = int.Parse(Console.ReadLine());
                if (v > x)
                {
                    ok = 0;
                }
                n--;
            }
            if (ok == 1)
                Console.WriteLine("sirul e ordonat");
            else
                Console.WriteLine("sirul nu e ordonat");
        }
        private static void P7_II()
        {
            int n, x, min = int.MaxValue, max = int.MinValue;
            Console.WriteLine("introduceti n");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                x = int.Parse(Console.ReadLine());
                if (x < min)
                    min = x;
                if (x > max)
                    max = x;
                n--;
            }
            Console.WriteLine($"minimul e {min}");
            Console.WriteLine($"maximul e {max}");
        }
        private static void P8_II()
        {
            int n, a, b, c = 0, i;
            n = int.Parse(Console.ReadLine());
            if (n == 1)
                Console.Write(1);
            if (n == 2)
                Console.Write($"1 1");
            if (n >= 3)
            {
                a = 1;
                b = 1;
                Console.Write($"{a} {b} ");
                for (i = 3; i <= n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    Console.Write($"{c} ");
                }
            }
        }
        private static void P9_II()
        {
            int n, x, v;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti sirul:");
            x = int.Parse(Console.ReadLine());
            int ok = 1;
            while (n - 1 != 0)
            {
                v = x;
                x = int.Parse(Console.ReadLine());
                if (v > x)
                {
                    ok = 0;
                }
                n--;
            }
            if (ok == 1)
                Console.WriteLine("sirul e monoton crescator");
            else
                Console.WriteLine("sirul nu e monoton crescator");
            Console.WriteLine("introduceti sirul:");
            x = int.Parse(Console.ReadLine());
            int k = 1;
            while (n - 1 != 0)
            {
                v = x;
                x = int.Parse(Console.ReadLine());
                if (v < x)
                {
                    k = 0;
                }
                n--;
            }
            if (k == 1)
                Console.WriteLine("sirul e monoton descrescator");
            else
                Console.WriteLine("sirul nu e monoton descrescator");
        }
        private static void P10_II()
        {
            int n, x, v, nr = 0, max = int.MinValue;
            Console.WriteLine("introduceti n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti sirul");
            x = int.Parse(Console.ReadLine());
            while (n - 1 != 0)
            {
                v = x;
                x = int.Parse(Console.ReadLine());
                if (v == x)
                    nr = 0;
                while (v == x)
                {
                    nr++;
                    x = int.Parse(Console.ReadLine());
                    n--;
                }
                if (nr > max)
                    max = nr;
                x = int.Parse(Console.ReadLine());
                n--;
            }
            Console.WriteLine(nr);
        }
        private static void P11_II()
        {
            int n, x, suma = 0, invers = 0, p;
            Console.WriteLine("introduceti n");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                x = int.Parse(Console.ReadLine());
                p = 1;
                while (x != 0)
                {
                    invers = invers * p + x % 10;
                    x = x / 10;
                }
                suma = suma + invers;
                n--;
            }
            Console.WriteLine(suma);
        }
        private static void P12_II()
        {
            int n, x1, nrgrup = 0;
            Console.WriteLine("introduceti n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti sirul");
            x1 = int.Parse(Console.ReadLine());
            if (x1 != 0)
            {
                nrgrup = 1;
            }
            for (int i = 0; i <= n; i++)
            {
                int x2 = int.Parse(Console.ReadLine());
                if (x2 != 0 && x1 == 0)
                {
                    nrgrup++;
                }
                x1 = x2;
            }
        }
        private static void P13_II()
        {
            int n, creste = 0, scade = 0, first, last = 0, x1, x2;
            n = int.Parse(Console.ReadLine());
            first = int.Parse(Console.ReadLine());
            x1 = first;
            for (int i = 2; i <= n; i++)
            {
                x2 = int.Parse(Console.ReadLine());
                if (i == n)
                {
                    last = x2;
                }
                if (x1 <= x2)
                {
                    creste++;
                }
                else
                {
                    scade++;
                }
                x1 = x2;
            }
            if (first >= last)
            {
                creste++;
            }
            else
            {
                scade++;
            }
            Console.WriteLine("secventa" + (creste >= 1 && scade <= 1 ? "" : "nu "));
        }
        private static void P14_II()
        {

        }
        private static void P15_II()
        {
            int n, x1, x2;
            n = int.Parse(Console.ReadLine());

        }
        private static void P16_II()
        {
            int n, first, last = 0, monotonie = 0, schimbare = 0;
            n = int.Parse(Console.ReadLine());
            first = int.Parse(Console.ReadLine());
            int x1 = first, x2;
            for (int i = 2; i <= n; i++)
            {
                x2 = int.Parse(Console.ReadLine());
                if (i == n)
                {
                    last = x2;
                }
                if (x1 < x2)
                {
                    if (monotonie != 1)
                        schimbare++;
                    monotonie = 1;
                }
                else if (x1 > x2)
                {
                    if (monotonie != -1)
                        schimbare++;
                    monotonie = -1;
                }
                x1 = x2;
            }
            if (first > last)
            {
                if (monotonie != 1)
                    schimbare++;
                monotonie = 1;
            }
            else if (first < last)
            {
                if (monotonie != -1)
                    schimbare++;
                monotonie = -1;
            }

        }
        private static void P1_III()
        {
            int n, i, suma = 0;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
                suma = suma + v[i];

            Console.Write(suma);
        }
        private static void P2_III()
        {
            int n, i, k;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti k:");
            k = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            int ok = 0;
            for (i = 0; i < n; i++)
            {
                if (v[i] == k)
                {
                    Console.WriteLine(i);
                    break;
                    ok = 1;
                }
            }
            if (ok == 0)
                Console.WriteLine("-1");
        }
        private static void P3_III()
        {
            int n, i, maxim = int.MinValue, minim = int.MaxValue, pozmin = 0, pozmax = 0;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                if (v[i] > maxim)
                {
                    pozmax = i;
                    maxim = v[i];
                }
                if (v[i] < minim)
                {
                    pozmin = i;
                    minim = v[i];
                }
            }
            Console.WriteLine($"pozitia minimului e {pozmin}");
            Console.WriteLine($"pozitia maximului e {pozmax}");
        }
        private static void P4_III()
        {
            int n, i, maxim = int.MinValue, minim = int.MaxValue, nrmin = 0, nrmax = 0;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                if (v[i] > maxim)
                    maxim = v[i];
                if (v[i] < minim)
                    minim = v[i];
            }
            for (i = 0; i < n; i++)
            {
                if (v[i] == maxim)
                    nrmax++;
                if (v[i] == minim)
                    nrmin++;
            }
            Console.WriteLine($"minimul este {minim} si apare de {nrmin} ori");
            Console.WriteLine($"maximul este {maxim} si apare de {nrmax} ori");
        }
        private static void P5_III()
        {
            int n, i, k, e;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];

            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti k:");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti e:");
            e = int.Parse(Console.ReadLine());

            for (i = n; i > k; i--)
            {
                v[i] = v[i - 1];
            }
            v[k] = e;
            for (i = 0; i < n + 1; i++)
            {
                Console.Write($"{v[i]} ");
            }
        }
        private static void P6_III()
        {
            int n, i, k, nr = 0;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            k = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                if (v[i] == k)
                {
                    nr++;
                    for (int j = i; j < n - nr; j++)
                    {
                        v[j] = v[j + 1];
                    }
                }
            }
            for (i = 0; i < n - nr; i++)
                Console.Write($"{v[i]} ");
        }
        private static void P7_III()
        {
            int n, i;
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write($"{v[i]} ");
            }
        }
        private static void P8_III()
        {
            int n, i, k;
            Console.WriteLine("scrieti n");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("introduceti valorile vectorului");
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            k = v[0];
            for (i = 0; i < n - 1; i++)
            {
                v[i] = v[i + 1];
            }
            v[n - 1] = k;
            for (i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }
        private static void P9_III()
        {
            int n, i, k;
            Console.WriteLine("scrieti n");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int[] a = new int[n];
            Console.WriteLine("scrieti k");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti valorile vectorului");
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                a[i] = v[i];
            }
            for (i = 0; i < n; i++)
            {
                int x = (i + k) % n;
                if (x == 0)
                    x = n;
                v[i] = a[x];
            }
            for (i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }
        private static void P10_III()
        {
            int n, i, k;
            Console.WriteLine("scrieti n");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("scrieti k");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti valorile vectorului");
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int ok = 0;
            for (i = 0; i < n; i++)
            {
                if (v[i] == k)
                {
                    Console.WriteLine($"{i} ");
                    ok = 1;
                }
            }
            if (ok == 0)
                Console.WriteLine("-1");
        }
        private static void P11_III()
        {
            int n, numar, ok, i;

            n = int.Parse(Console.ReadLine());

            for (numar = 2; numar <= n; numar++)
            {
                ok = 1;
                for (i = 2; i <= numar / 2; i++)
                {
                    if (numar % i == 0)
                        ok = 0;
                }
                if (ok == 1)
                {
                    Console.WriteLine($"{numar} ");
                }
            }
        }
        private static void P12_III()
        {
            int n, i, j;
            Console.WriteLine("scrieti n");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("introduceti valorile vectorului");
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n - 1; i++)
            {
                int minim = i;
                for (j = i + 1; j < n; j++)
                    if (v[j] < v[minim])
                        minim = j;
                int k = v[minim];
                v[minim] = v[i];
                v[i] = k;
            }
            for (i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }
        private static void P13_III()
        {
            int n, i, j;
            Console.WriteLine("scrieti n");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("introduceti valorile vectorului");
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (i = 1; i < n; ++i)
            {
                int k = v[i];
                j = i - 1;
                while (j >= 0 && v[j] > k)
                {
                    v[j + 1] = v[j];
                    j = j - 1;
                }
                v[j + 1] = k;
            }
            for (i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }
        private static void P14_III()
        {
            int n, i, j;
            Console.WriteLine("scrieti n");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("introduceti valorile vectorului");
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for(i=0; i<n; i++)
            {
                if (v[i] == 0)
                {
                    for (j = i; j < n - 1; j++)
                    {
                        int k = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = k;
                    }
                }
            }
            for (i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }
        private static void P15_III()
        {
            int n, i, j;
            Console.WriteLine("scrieti n");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("introduceti valorile vectorului");
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n-1; i++)
                for (j = i + 1; j < n; j++)
                    if (v[i] == v[j])
                    {
                        for (int y = j; y < n; y++)
                            v[y] = v[y + 1];
                    }
            for (i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }
        private static void P16_III()
        {
            int n, i, j;
            Console.WriteLine("scrieti n");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("introduceti valorile vectorului");
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int cmmdc = v[0];
            for (i = 1; i < n; i++)
            {

                int copie = v[i];
                while (copie != cmmdc)
                {

                    if (copie > cmmdc)
                        copie = copie - cmmdc;
                    else if (copie < cmmdc)
                        cmmdc = cmmdc - copie;
                }
            }
            Console.WriteLine(cmmdc);
        }
    }
}
