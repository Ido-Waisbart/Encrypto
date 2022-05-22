using System;
using System.Net;
using System.Text;
using System.Numerics;
using System.IO;
using System.Linq;

namespace EncryptoLib
{
    public static class Encrypto
    {
        public static string caesar_cipher_encrypt(this string to_encrypt, int key)
        {
            const int TOTAL_LETTER_COUNT = 26;
            string encrypted = "";
            char new_char;
            if (String.IsNullOrWhiteSpace(to_encrypt))
            {
                return "";
            }
            foreach(char ch in to_encrypt)
            {
                if (!('A' <= ch && ch <= 'Z') && !('a' <= ch && ch <= 'z'))
                {
                    // if ch is not a letter
                    encrypted += ch;
                }
                else if('a' <= ch && ch <= 'z')
                {
                    // ch is a lowercase letter
                    new_char = (char)((int)ch + key);
                    while (new_char > 'z')
                    {
                        new_char = (char) (new_char - TOTAL_LETTER_COUNT);
                    }
                    while (new_char < 'a')
                    {
                        new_char = (char)(new_char + TOTAL_LETTER_COUNT);
                    }
                    encrypted += new_char;
                }
                else if ('A' <= ch && ch <= 'Z')
                {
                    // ch is a uppercase letter
                    new_char = (char)((int)ch + key);
                    while (new_char > 'Z')
                    {
                        new_char = (char)(new_char - TOTAL_LETTER_COUNT);
                    }
                    while (new_char < 'A')
                    {
                        new_char = (char)(new_char + TOTAL_LETTER_COUNT);
                    }
                    encrypted += new_char;
                }
            }
            return encrypted;
        }

        public static string caesar_cipher_decrypt(this string to_encrypt, int key)
        {
            return caesar_cipher_encrypt(to_encrypt, -key);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static bool is_prime(int num)
        {
            // https://www.quora.com/Whats-the-best-algorithm-to-check-if-a-number-is-prime
            if(num >= 2 && num <= 3)
            {
                return true;
            }
            else if(num % 6 == 1 || num % 6 == 5)
            {
                for (int i = 5; i < Math.Sqrt(num); i += 2)
                {
                    if(num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int gcd(int num1, int num2)
        {
            // https://www.geeksforgeeks.org/check-two-numbers-co-prime-not/

            if (num1 == 0 || num2 == 0)
            {
                return 0;
            }

            if (num1 == num2)
            {
                return num1;
            }

            if (num1 > num2)
            {
                return gcd(num1 - num2, num2);
            }

            return gcd(num1, num2 - num1);
        }

        public static bool is_coprime(int num1, int num2)
        {
            return gcd(num1, num2) == 1;
        }

        public static Tuple<Tuple<int, int>, Tuple<int, int>> rsa_key_generation()
        {
            Tuple<Tuple<int, int>, Tuple<int, int>> keys = null;
            Random random = new Random();
            int p = random.Next(2, 101);
            int q = random.Next(2, 101);
            int n = 0;
            int totient_n = 0;
            int e = random.Next(2, 101);
            int d = 1;

            while (!is_prime(p))
            {
                //Console.WriteLine(rand1 + " is not prime");
                p = random.Next(2, 101);
            }
            Console.WriteLine(p + " = p");

            while (!is_prime(q))
            {
                //Console.WriteLine(rand1 + " is not prime");
                q = random.Next(2, 101);
            }
            Console.WriteLine(q + " = q");

            n = p * q;
            totient_n = (p - 1) * (q - 1);
            Console.WriteLine(totient_n + " = totient_n");

            while (!is_coprime(e, totient_n))
            {
                //Console.WriteLine(rand1 + " is not prime");
                e = random.Next(2, 101);
            }
            Console.WriteLine(e + " = e");

            while ((d * e) % totient_n != (1 % totient_n))
            {
                d++;
            }
            Console.WriteLine(d + " = d");

            keys = new Tuple<Tuple<int, int>, Tuple<int, int>>(new Tuple<int, int>(n, e), new Tuple<int, int>(n, d));

            return keys;
        }

        public static BigInteger[] rsa_cipher_encrypt(this string to_encrypt, Tuple<int, int> e_key)
        {
            // a (mod n) = b (mod n) example: 12 mod 5 (2) = 30 mod 4 (2)
            
            //Tuple<Tuple<int, int>, Tuple<int, int>> keys = null;

            if (String.IsNullOrWhiteSpace(to_encrypt))
            {
                return null;
            }
            BigInteger[] encrypted = new BigInteger[to_encrypt.Length];

            //keys = rsa_key_generation();
            //Tuple<int, int> public_key = keys.Item1;
            //Tuple<int, int> private_key = keys.Item2;
            //Console.WriteLine("item 1.1, item 1.2, item 2.1, item 2.2");
            //Console.WriteLine("N: " + keys.Item1.Item1); // n
            //Console.WriteLine("E: " + keys.Item1.Item2); // e
            //Console.WriteLine("N: " + keys.Item2.Item1); // n
            //Console.WriteLine("D: " + keys.Item2.Item2); // d

            //Console.WriteLine("item 1.1/n, item 1.2/e");
            //Console.WriteLine(e_key.Item1); // n
            //Console.WriteLine(e_key.Item2); // e

            int i = 0;
            foreach (char ch in to_encrypt)
            {
                //Console.WriteLine("ch = " + ((int)ch).ToString());
                //Console.WriteLine("e_key.Item2 = " + (e_key.Item2).ToString());
                //Console.WriteLine("e_key.Item1 = " + (e_key.Item1).ToString());
                //Console.WriteLine("ch pow e_key.Item2 = " + (Math.Pow(ch, e_key.Item2)).ToString());
                BigInteger number = BigInteger.Pow(ch, e_key.Item2) % e_key.Item1;
                encrypted[i++] = number;
                //encrypted += (number).ToString() + ' ';
                //Console.WriteLine("Encrypting: " + (number).ToString() + " --- in char --> " + (char)(number));
                //Console.WriteLine("ch, e, n, encrypted: " + (int) ch + ", " + e_key.Item2 + ", " + e_key.Item1 + ", " + encrypted);
            }

            return encrypted;
        }

        public static string rsa_cipher_decrypt(this BigInteger[] to_decrypt, Tuple<int, int> d_key)
        {
            // a (mod n) = b (mod n) example: 12 mod 5 (2) = 30 mod 4 (2)
            string decrypted = "";
            //Tuple<Tuple<int, int>, Tuple<int, int>> keys = null;

            if (to_decrypt.Length == 0)
            {
                return "";
            }

            //keys = rsa_key_generation();
            //Tuple<int, int> public_key = keys.Item1;
            //Tuple<int, int> private_key = keys.Item2;
            //Console.WriteLine("item 1.1, item 1.2, item 2.1, item 2.2");
            //Console.WriteLine(keys.Item1.Item1); // n
            //Console.WriteLine(keys.Item1.Item2); // e
            //Console.WriteLine(keys.Item2.Item1); // n
            //Console.WriteLine(keys.Item2.Item2); // d

            //Console.WriteLine("item 2.1/n, item 2.2/d");
            //Console.WriteLine(d_key.Item1); // n
            //Console.WriteLine(d_key.Item2); // e

            foreach (BigInteger ch in to_decrypt)
            {
                if(ch != ' ')
                {
                    //Console.WriteLine("ch = " + ((int)ch).ToString());
                    //Console.WriteLine("Decoding: " + (ch ^ d_key.Item2 % d_key.Item1).ToString() +  " -> " + (char)(ch ^ d_key.Item2 % d_key.Item1));
                    BigInteger number = BigInteger.Pow(ch, d_key.Item2) % d_key.Item1;
                    //Console.WriteLine(((int)ch).ToString() + " => " + ((char)number).ToString());
                    decrypted += ((char) number).ToString() + ' ';
                    //decrypted += ((char) (ch ^ d_key.Item2 % d_key.Item1)).ToString();
                }
                //Console.WriteLine("ch, e, n, encrypted: " + (int)ch + ", " + d_key.Item2 + ", " + d_key.Item1 + ", " + decrypted);
            }

            return decrypted;

            // same as encrypt?
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int letter_to_value(char ch)
        {
            int value = 0;
            if('A' <= (int)ch && (int)ch <= 'Z')
            {
                // ON CAPS
                value = ch - 'A';
            }
            else if('a' <= (int)ch && (int)ch <= 'z')
            {
                value = ch - 'a';
            }
            return value;
        }
        
        public static string vigenere_cipher_encrypt(this string to_encrypt, string key)
        {
            //ATTACKATDOWN
            //LEMONLEMONLE
            //
            //LXFOPVEFRNHR
            const int TOTAL_LETTER_COUNT = 26;
            string encrypted = "";
            string modified_key = key;
            char new_char;
            int i = 0;
            int key_letter_value;
            if (String.IsNullOrWhiteSpace(to_encrypt) || String.IsNullOrWhiteSpace(key))
            {
                return "";
            }
            while(modified_key.Length < to_encrypt.Length)
            {
                modified_key += key[i % key.Length];
                i++;
            }
            i = 0;
            foreach (char ch in to_encrypt)
            {
                if (!('A' <= ch && ch <= 'Z') && !('a' <= ch && ch <= 'z'))
                {
                    // if ch is not a letter
                    encrypted += ch;
                }
                else if ('a' <= ch && ch <= 'z')
                {
                    // ch is a lowercase letter
                    key_letter_value = letter_to_value(modified_key[i]);
                    new_char = (char)(ch + key_letter_value);
                    while (new_char > 'z')
                    {
                        new_char = (char)(new_char - TOTAL_LETTER_COUNT);
                    }
                    while (new_char < 'a')
                    {
                        new_char = (char)(new_char + TOTAL_LETTER_COUNT);
                    }
                    encrypted += new_char;
                }
                else if ('A' <= ch && ch <= 'Z')
                {
                    // ch is a uppercase letter
                    key_letter_value = letter_to_value(modified_key[i]);
                    new_char = (char)(ch + key_letter_value);
                    while (new_char > 'Z')
                    {
                        new_char = (char)(new_char - TOTAL_LETTER_COUNT);
                    }
                    while (new_char < 'A')
                    {
                        new_char = (char)(new_char + TOTAL_LETTER_COUNT);
                    }
                    encrypted += new_char;
                }
                i++;
            }
            return encrypted;
        }

        public static string vigenere_cipher_decrypt(string to_decrypt, string key)
        {
            //ATTACKATDOWN
            //LEMONLEMONLE
            //
            //LXFOPVEFRNHR
            const int TOTAL_LETTER_COUNT = 26;
            string decrypted = "";
            char new_char;
            int i = 0;
            int key_letter_value;
            if (String.IsNullOrWhiteSpace(to_decrypt))
            {
                return "";
            }
            foreach (char ch in to_decrypt)
            {
                if (!('A' <= ch && ch <= 'Z') && !('a' <= ch && ch <= 'z'))
                {
                    // if ch is not a letter
                    decrypted += ch;
                }
                else if ('a' <= ch && ch <= 'z')
                {
                    // ch is a lowercase letter
                    key_letter_value = letter_to_value(key[i % key.Length]);
                    new_char = (char)(ch - key_letter_value);
                    while (new_char > 'z')
                    {
                        new_char = (char)(new_char - TOTAL_LETTER_COUNT);
                    }
                    while (new_char < 'a')
                    {
                        new_char = (char)(new_char + TOTAL_LETTER_COUNT);
                    }
                    decrypted+= new_char;
                }
                else if ('A' <= ch && ch <= 'Z')
                {
                    // ch is a uppercase letter
                    key_letter_value = letter_to_value(key[i]);
                    new_char = (char)(ch - key_letter_value);
                    while (new_char > 'Z')
                    {
                        new_char = (char)(new_char - TOTAL_LETTER_COUNT);
                    }
                    while (new_char < 'A')
                    {
                        new_char = (char)(new_char + TOTAL_LETTER_COUNT);
                    }
                    decrypted += new_char;
                }
                i++;
            }
            return decrypted;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int hexchar_to_int(char c)
        {
            int result = 0;
            if (c >= '0' && c <= '9')
            {
                // 0-9
                result = c - '0';
            }
            else if (c >= 'a' && c <= 'z')
            {
                // a-f
                result = c - 'a' + 10;
            }
            else if (c >= 'A' && c <= 'Z')
            {
                result = c - 'A' + 10;
            }
            return result;
        }
        
        public static byte hexstring_to_byte(string s)
        {
            byte result = 0x00;
            const int BYTE_SIZE = 16;
            int i1 = hexchar_to_int(s[0]);
            int i2 = hexchar_to_int(s[1]);

            byte b1 = BitConverter.GetBytes(i1)[0];
            byte b2 = BitConverter.GetBytes(i2)[0];
            byte BYTE_SIZE_B = BitConverter.GetBytes(BYTE_SIZE)[0];

            //Console.WriteLine("STRING: " + s);
            //Console.WriteLine("INTS: " + i1.ToString() + ", " + i2.ToString());
            //Console.WriteLine("BYTES: " + b1.ToString() + ", " + b2.ToString());

            int result_i = b2 + (b1 * BYTE_SIZE_B);
            result = BitConverter.GetBytes(result_i)[0];

            return result;
        }

        // true = encrypt, false = decrypt
        public static byte aes_byte_sub(byte b, bool encryption)
        {
            byte result = 0x00;
            byte[,] s_box = new byte[16, 16];
            string piece = "";
            string line = "";

            int b_i = b / 0x10;
            int b_j = b % 0x10;

            TextReader temp_tr;
            if (encryption)
            {
                temp_tr = new StreamReader("C:\\Users\\magshimim\\Documents\\Visual Studio 2017\\Projects\\MyLibraryProjects\\Encrypto\\AES_S-box.txt");
            }
            else
            {
                temp_tr = new StreamReader("C:\\Users\\magshimim\\Documents\\Visual Studio 2017\\Projects\\MyLibraryProjects\\Encrypto\\AES_inverse_S-box.txt");
            }
            //TextReader tr = new StreamReader("AES_S-box.txt");
            string[,] file_str = new string[16, 16];
            for(int i = 0; i < 16; i++)
            {
                line = temp_tr.ReadLine();
                //Console.WriteLine("TEST: " + line.Split('\t')[0]);
                for (int j = 0; j < 16; j++)
                {
                    piece = line.Split('\t')[j];
                    file_str[i, j] = piece;
                    s_box[i, j] = hexstring_to_byte(piece);
                }
            }

            result = s_box[b_i, b_j];

            //Console.WriteLine("::: " + piece + " - " + file_str[0, 0] + " - " + s_box[0, 0] + " - " + result);
            //Console.WriteLine(String.Format(":X:X:X: {0,10:X}", result));
            //Console.WriteLine("RESULT - " + result);

            return result;
        }

        // true = encrypt, false = decrypt
        public static byte[,] aes_bytes_sub(byte[,] b, bool encryption)
        {
            byte[,] result = new byte[b.GetLength(0), b.GetLength(1)];

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    result[i, j] = aes_byte_sub(b[i, j], encryption);
                }
            }

            return result;
        }

        // true = encrypt, false = decrypt
        public static byte[,] aes_shift_rows(byte[,] b, bool encryption)
        {
            byte[,] result = new byte[b.GetLength(0), b.GetLength(1)];
            
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    if(encryption)
                    {
                        result[i, (j + i) % 16] = b[i, j];
                    }
                    else
                    {
                        result[i, (j - i + 16) % 16] = b[i, j];
                    }
                }
            }

            return result;
        }

        //https://en.wikipedia.org/wiki/Rijndael_MixColumns#Implementation_example
        // true = encrypt, false = decrypt
        public static byte[,] internet_aes_mix_cols(byte[,] b, bool encryption)
        {
            byte[,] result = new byte[b.GetLength(0), b.GetLength(1)];

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    result[i, j] = 0x00;
                }
            }
            for (int i = 0; i < b.GetLength(1); i++)  // for each column
            {
                for (int j = 0; j < b.GetLength(0) / 4; j++)  // for each group of 4 vertically close array parts
                {
                    if(encryption)
                    {
                        result[j * 4 + 0, i] = (byte)(internet_GMul(0x02, b[j * 4 + 0, i]) ^ internet_GMul(0x03, b[j * 4 + 1, i]) ^ b[j * 4 + 2, i] ^ b[j * 4 + 3, i]);
                        result[j * 4 + 1, i] = (byte)(b[j * 4 + 0, i] ^ internet_GMul(0x02, b[j * 4 + 1, i]) ^ internet_GMul(0x03, b[j * 4 + 2, i]) ^ b[j * 4 + 3, i]);
                        result[j * 4 + 2, i] = (byte)(b[j * 4 + 0, i] ^ b[j * 4 + 1, i] ^ internet_GMul(0x02, b[j * 4 + 2, i]) ^ internet_GMul(0x03, b[j * 4 + 3, i]));
                        result[j * 4 + 3, i] = (byte)(internet_GMul(0x03, b[j * 4 + 0, i]) ^ b[j * 4 + 1, i] ^ b[j * 4 + 2, i] ^ internet_GMul(0x02, b[j * 4 + 3, i]));
                    }
                    else
                    {
                        result[j * 4 + 0, i] = (byte)(internet_GMul(0x0E, b[j * 4 + 0, i]) ^ internet_GMul(0x0B, b[j * 4 + 1, i]) ^ internet_GMul(0x0D, b[j * 4 + 2, i]) ^ internet_GMul(0x09, b[j * 4 + 3, i]));
                        result[j * 4 + 1, i] = (byte)(internet_GMul(0x09, b[j * 4 + 0, i]) ^ internet_GMul(0x0E, b[j * 4 + 1, i]) ^ internet_GMul(0x0B, b[j * 4 + 2, i]) ^ internet_GMul(0x0D, b[j * 4 + 3, i]));
                        result[j * 4 + 2, i] = (byte)(internet_GMul(0x0D, b[j * 4 + 0, i]) ^ internet_GMul(0x09, b[j * 4 + 1, i]) ^ internet_GMul(0x0E, b[j * 4 + 2, i]) ^ internet_GMul(0x0B, b[j * 4 + 3, i]));
                        result[j * 4 + 3, i] = (byte)(internet_GMul(0x0B, b[j * 4 + 0, i]) ^ internet_GMul(0x0D, b[j * 4 + 1, i]) ^ internet_GMul(0x09, b[j * 4 + 2, i]) ^ internet_GMul(0x0E, b[j * 4 + 3, i]));
                    }
                }
            }

            return result;
        }

        //https://en.wikipedia.org/wiki/Rijndael_MixColumns#Implementation_example
        public static byte internet_GMul(byte b1, byte b2)
        { // Galois Field (256) Multiplication of two Bytes
            // b1 * b2 (GF(256))

            byte result = 0;
            const int BYTE_SIZE = 8;

            // 10110110 GMUL 01010011 = 10011100111010, 0xb6 GMUL 0x53 = 0x139d
            


            // TODO: NEEDS A FLOWCHART


            // test case: 0x02 GMUL 0x63, 00000010 GMUL 01100011
            for (int i = 0; i < BYTE_SIZE; i++)
            {
                if ((b2 & 1) != 0)
                {
                    // if b2's 1st bit is turned on (???????1b), then result = result XOR b1
                    result ^= b1;
                }  // test case: result = result XOR 00000010 = 00000010

                bool high_bit_set = (b1 & 0x80) != 0;  // test case: high_bit_set = false
                b1 <<= 1;  // test case: b1 = 00000100
                if (high_bit_set)
                {
                    // if b1's 8th bit is turned on (1???????b), then b1 = b1 XOR 00011011b
                    b1 ^= 0x1B; // x^8 + x^4 + x^3 + x + 1  /  (1) 00011011
                }  // test case: nothing happens
                b2 >>= 1;  // test case: b2 = 00110001
            }

            return result;
        }

        public static byte[,] aes_add_round_key(byte[,] b, byte[] key)  // the key has 16 characters
        {
            byte[,] result = new byte[b.GetLength(0), b.GetLength(1)];

            if(b.GetLength(1) != key.Length)
            {
                return null;
            }

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    //Console.WriteLine("XOR'd {0,10:X} with {1,10:X}, and got {2,10:X}", b[i, j], key[j], (byte)(b[i, j] ^ key[j]));
                    result[i, j] = (byte)(b[i, j] ^ key[j]);
                }
            }

            return result;
        }

        /*// http://www.cs.utsa.edu/~wagner/laws/AESkeys.html
        public static byte[] internet_KeyExpansion(byte[] key, int key_size)
        {
            int round_number = key_size + 6;
            const int Nb = 4;
            byte[] returned = new byte[4 * Nb * (round_number + 1)];
            int temp = 0;
            int i = 0;

            while (i < key_size)
            {
                returned[i] = (byte)(key[4 * i], key[4 * i + 1], key[4 * i + 2], key[4 * i + 3]);
                i++;
            }
            i = key_size;

            while (i < Nb * (round_number + 1))
            {
                temp = returned[i - 1];
                if (i % key_size == 0)
                    temp = aes_bytes_sub(RotWord(temp)) ^ Rcon[i / key_size];
                else if (key_size > 6 && (i % key_size) == 4)
                    temp = aes_bytes_sub(temp);
                returned[i] = returned[i - key_size] ^ temp;
                i++;
            }
            return returned;
        }*/

        public static byte[] aes_cipher_encrypt(this byte[] to_encrypt, byte[] key)
        {
            byte[] encrypted = new byte[256];
            byte[] bytes_256 = new byte[256];
            byte[,] encrypted_2d = new byte[16, 16];

            int i = 0, j = 0;
            const int ROUND_COUNT = 3;
            const int KEY_SIZE_IN_BYTES = 4*4;

            if (key.Length != KEY_SIZE_IN_BYTES)
            {
                Console.WriteLine("The key ain't 16 bytes");
                return null;
            }
            if (to_encrypt == null)
            {
                Console.WriteLine("The plain text is empty");
                return null;
            }

            // to_encrypt -> bytes_256 (1d array -> 1d array with fixed size [256])
            for(i = 0; i < 256; i++)
            {
                bytes_256[i] = 0x00;
                if(i < to_encrypt.Length)
                {
                    bytes_256[i] = to_encrypt[i];
                }
            }
            
            // bytes_256 -> encrypted_2d (1d array -> 2d array)
            for (i = 0; i < 16; i++)
            {
                for (j = 0; j < 16; j++)
                {
                    encrypted_2d[i, j] = bytes_256[i * 16 + j];
                    //Console.WriteLine("{0}, {1} <- {2}", i, j, bytes_256[i * 16 + j]);
                }
            }
            
            //Console.WriteLine(String.Format(":Pre-anything (i=0-3, j=0): {0,10:X}, {1,10:X}, {2,10:X}, {3,10:X}", returned_bytes[0, 0], returned_bytes[1, 0], returned_bytes[2, 0], returned_bytes[3, 0]));
            //Console.WriteLine(String.Format(":Post-sub_bytes (i=0-3, j=0): {0,10:X}, {1,10:X}, {2,10:X}, {3,10:X}", returned_bytes[0, 0], returned_bytes[1, 0], returned_bytes[2, 0], returned_bytes[3, 0]));
            //Console.WriteLine(String.Format(":Post-shift_rows (i=0-3, j=0): {0,10:X}, {1,10:X}, {2,10:X}, {3,10:X}", returned_bytes[0, 0], returned_bytes[1, 0], returned_bytes[2, 0], returned_bytes[3, 0]));
            //Console.WriteLine(String.Format(":Post-mix_columns (i=0-3, j=0): {0,10:X}, {1,10:X}, {2,10:X}, {3,10:X}", returned_bytes[0, 0], returned_bytes[1, 0], returned_bytes[2, 0], returned_bytes[3, 0]));
            //Console.WriteLine(String.Format(":Post-add_round_key (i=0-3, j=0): {0,10:X}, {1,10:X}, {2,10:X}, {3,10:X}", returned_bytes[0, 0], returned_bytes[1, 0], returned_bytes[2, 0], returned_bytes[3, 0]));
            encrypted_2d = aes_add_round_key(encrypted_2d, key);

            for (i = 0; i < ROUND_COUNT; i++)
            {
                encrypted_2d = aes_bytes_sub(encrypted_2d, true);
                encrypted_2d = aes_shift_rows(encrypted_2d, true);
                encrypted_2d = internet_aes_mix_cols(encrypted_2d, true);
                encrypted_2d = aes_add_round_key(encrypted_2d, key);
            }
            encrypted_2d = aes_bytes_sub(encrypted_2d, true);
            encrypted_2d = aes_shift_rows(encrypted_2d, true);
            encrypted_2d = aes_add_round_key(encrypted_2d, key);

            // encrypted_2d -> encrypted (2d array -> 1d array)
            for (i = 0; i < encrypted_2d.GetLength(0); i++)
            {
                for (j = 0; j < encrypted_2d.GetLength(1); j++)
                {
                    encrypted[i * encrypted_2d.GetLength(0) + j] = encrypted_2d[i, j];
                }
            }

            return encrypted;
        }

        public static byte[] aes_cipher_decrypt(this byte[] to_decrypt, byte[] key)
        {
            byte[] encrypted = new byte[256];
            byte[] bytes_256 = new byte[256];
            byte[,] encrypted_2d = new byte[16, 16];

            int i = 0, j = 0;
            const int ROUND_COUNT = 3;
            const int KEY_SIZE_IN_BYTES = 4 * 4;

            if (key.Length != KEY_SIZE_IN_BYTES)
            {
                Console.WriteLine("The key ain't 16 bytes");
                return null;
            }
            if (to_decrypt == null)
            {
                Console.WriteLine("The plain text is empty");
                return null;
            }

            // to_encrypt -> bytes_256 (1d array -> 1d array with fixed size [256])
            for (i = 0; i < 256; i++)
            {
                bytes_256[i] = 0x00;
                if (i < to_decrypt.Length)
                {
                    bytes_256[i] = to_decrypt[i];
                }
            }

            // bytes_256 -> encrypted_2d (1d array -> 2d array)
            for (i = 0; i < 16; i++)
            {
                for (j = 0; j < 16; j++)
                {
                    encrypted_2d[i, j] = bytes_256[i * 16 + j];
                    //Console.WriteLine("{0}, {1} <- {2}", i, j, bytes_256[i * 16 + j]);
                }
            }

            //Console.WriteLine(String.Format(":Pre-anything (i=0-3, j=0): {0,10:X}, {1,10:X}, {2,10:X}, {3,10:X}", returned_bytes[0, 0], returned_bytes[1, 0], returned_bytes[2, 0], returned_bytes[3, 0]));
            //Console.WriteLine(String.Format(":Post-sub_bytes (i=0-3, j=0): {0,10:X}, {1,10:X}, {2,10:X}, {3,10:X}", returned_bytes[0, 0], returned_bytes[1, 0], returned_bytes[2, 0], returned_bytes[3, 0]));
            //Console.WriteLine(String.Format(":Post-shift_rows (i=0-3, j=0): {0,10:X}, {1,10:X}, {2,10:X}, {3,10:X}", returned_bytes[0, 0], returned_bytes[1, 0], returned_bytes[2, 0], returned_bytes[3, 0]));
            //Console.WriteLine(String.Format(":Post-mix_columns (i=0-3, j=0): {0,10:X}, {1,10:X}, {2,10:X}, {3,10:X}", returned_bytes[0, 0], returned_bytes[1, 0], returned_bytes[2, 0], returned_bytes[3, 0]));
            //Console.WriteLine(String.Format(":Post-add_round_key (i=0-3, j=0): {0,10:X}, {1,10:X}, {2,10:X}, {3,10:X}", returned_bytes[0, 0], returned_bytes[1, 0], returned_bytes[2, 0], returned_bytes[3, 0]));
            encrypted_2d = aes_add_round_key(encrypted_2d, key);

            for (i = 0; i < ROUND_COUNT; i++)
            {
                encrypted_2d = aes_shift_rows(encrypted_2d, false);
                encrypted_2d = aes_bytes_sub(encrypted_2d, false);
                encrypted_2d = aes_add_round_key(encrypted_2d, key);
                encrypted_2d = internet_aes_mix_cols(encrypted_2d, false);
            }
            encrypted_2d = aes_shift_rows(encrypted_2d, false);
            encrypted_2d = aes_bytes_sub(encrypted_2d, false);
            encrypted_2d = aes_add_round_key(encrypted_2d, key);

            // encrypted_2d -> encrypted (2d array -> 1d array)
            for (i = 0; i < encrypted_2d.GetLength(0); i++)
            {
                for (j = 0; j < encrypted_2d.GetLength(1); j++)
                {
                    encrypted[i * encrypted_2d.GetLength(0) + j] = encrypted_2d[i, j];
                }
            }

            return encrypted;
        }

        //https://stackoverflow.com/questions/311165/how-do-you-convert-a-byte-array-to-a-hexadecimal-string-and-vice-versa
        public static byte[] string_to_byte_array(string hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        //https://www.codeproject.com/Questions/791798/Convert-Hex-string-to-normal-String-in-Csharp
        public static string hex_to_string(string InputText)
        {

            byte[] bb = Enumerable.Range(0, InputText.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(InputText.Substring(x, 2), 16))
                             .ToArray();
            return System.Text.Encoding.ASCII.GetString(bb);
            // or System.Text.Encoding.UTF7.GetString
            // or System.Text.Encoding.UTF8.GetString
            // or System.Text.Encoding.Unicode.GetString
            // or etc.
        }
    }
}
