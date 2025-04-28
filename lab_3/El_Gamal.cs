using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace lab_3
{
    public static class El_Gamal
    {
        public static List<int> byteInputValues;
        public static List<int> byteOutputValues;
        public static int p;
        public static int x;
        public static int k;
        public static int y;
        public static int g;
        public static List<int> gVals;
        public static List<KeyValuePair<int, int>> encryptedBytes;

        //алгоритм первообразных
        static El_Gamal()
        {
            byteInputValues = new List<int>();
            byteOutputValues = new List<int>();
            gVals = new List<int>();
            encryptedBytes = new List<KeyValuePair<int, int>>();

            // Инициализируем числовые переменные
            p = 0;
            x = 0;
            k = 0;
            y = 0;
            g = 0;
        }
        public static List<KeyValuePair<int, int>> Encrypt(int p, int k, int y, int g)
        {
            El_Gamal.encryptedBytes = new List<KeyValuePair<int, int>>();
            foreach (int m in byteInputValues)
            {
                int a = ModularExponentiation(g, k, p);
                int b = ComputeB(y, k, m, p);
                AddPair(a, b);
            }
            return encryptedBytes;
        }
        static void AddPair(int key, int value)
        {
            encryptedBytes.Add(new KeyValuePair<int, int>(key, value));
        }
        public static List<int> GetPervoobr(int p)
        {
            bool IsPervoobr = true;
            List<int> g = new List<int>();
            List<int> q = new List<int>();
            q = GetPrimesFactors(p - 1);

            for (int i = 2; i < p; i++)
            {
                IsPervoobr = true;
                for (int j = 0;  j < q.Count; j++)
                {
                    //модульная арифметика
                    if (ModularExponentiation(i, (p - 1) / q[j], p) == 1)
                    {
                        IsPervoobr = false;
                        break;
                    }
                }
                if (IsPervoobr)
                {
                    g.Add(i);
                }
            }
            return g;
        }

        public static int ModularExponentiation(int val, int exp, int mod)
        {
            int result = 1;
            while (exp > 0)
            {
                if (exp % 2 != 0)
                {
                    result = (result * val) % mod;
                    exp -= 1;
                }
                else
                {
                    exp /= 2;
                    val = (val * val) % mod;
                }
                
            }
            return result;
        }
        public static long ModularExponentiation(long val, int exp, int mod)
        {
            long result = 1;
            while (exp > 0)
            {
                if (exp % 2 != 0)
                {
                    result = (result * val) % mod;
                    exp -= 1;
                }
                else
                {
                    exp /= 2;
                    val = (val * val) % mod;
                }

            }
            return result;
        }
        public static int Exponentiation(int val, int exp)
        {
            int result = 1;
            while (exp > 0)
            {
                if (exp % 2 != 0)
                {
                    result = (result * val) ;
                    exp -= 1;
                }
                else
                {
                    exp /= 2;
                    val = (val * val);
                }

            }
            return result;
        }

        public static long Exponentiation(long val, long exp)
        {
            long result = 1;
            while (exp > 0)
            {
                if (exp % 2 != 0)
                {
                    result *= val;
                    exp -= 1;
                }
                else
                {
                    exp /= 2;
                    val *= val;
                }
            }
            return result;
        }



        static int ComputeB(int y, int k, int m, int p)
        {
            int yPowK = ModularExponentiation(y, k, p); // Вычисляем y^k mod p
            return (yPowK * m) % p; // Умножаем на m и берем mod p
        }

        static long ComputeB(long y, int k, long m, int p)
        {
            long yPowK = ModularExponentiation(y, k, p); // Вычисляем y^k mod p
            return (yPowK * m) % p; // Умножаем на m и берем mod p
        }

        public static List<int> GetPrimesFactors(int num)
        {
            List<int> factors = new List<int>();
            int sqrt = (int)Math.Sqrt(num);
            for (int i = 2; i <= sqrt; i++)
            {
                if (num % i == 0)
                {
                    factors.Add(i);
                }
                while (num % i == 0)
                {
                    num /= i;
                }
            }
            if (num > 1)
            {
                factors.Add(num);
            }
            return factors;
        }
        //дешифрование
        public static List<int> Decipher(int x, int p)
        {
            byteOutputValues.Clear();
            byte[] byteArray = byteInputValues.Select(b => (byte)b).ToArray(); // 
            for (int i = 0; i < byteInputValues.Count; i += 8)
            {
                int a = BitConverter.ToInt32(byteArray, i);
                int b = BitConverter.ToInt32(byteArray, i + 4);
                //  a = Exponentiation(a, x);
                int m = ComputeB(a, p - 1 - x, b, p);
                byteOutputValues.Add(m); 
            }
            return new List<int>(byteOutputValues);
        }
        public static int modInverse(int a, int p)
        {
            return ModularExponentiation(a, p - 2, p); // a^(-1) mod p
        }
        public static int ComputeM(int a, int b, int x, int p)
        {
            int inverseA = modInverse(a, p);  // a^(-1) mod p
            int powerInverseA = ModularExponentiation(inverseA, x, p); // (a^(-1))^x mod p
            return (b * powerInverseA) % p;  // Итоговый результат
        }

        //вычисление у
        public static void ClearData()
        {
            byteInputValues.Clear();
            byteOutputValues.Clear();
            gVals.Clear();
            encryptedBytes.Clear();

            p = 0;
            x = 0;
            k = 0;
            y = 0;
            g = 0;
        }
    }
}
