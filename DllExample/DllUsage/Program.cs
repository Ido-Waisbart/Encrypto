using System;
using EncryptoLib;
using System.Numerics;
using System.Text;

namespace DllUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            string to_encrypt = "HELLo therE!";
            string to_decrypt = "defgH..?";
            int key = 3;

            string to_encrypt2 = "ATTACKATDAWN";
            string to_decrypt2 = "LXFOPVEFRNHR";
            string key2 = "LEMONLEMONLE";

            string to_encrypt3 = "ABC is good";

            //string to_encrypt4 = "ABCDEFG, HIJK, LMNOP, QRS, TUV, W, X, Y and Z!";
            string to_encrypt4 = "Hello";
            byte[] bytes4 = new byte[256];
            bytes4 = Encoding.Default.GetBytes(to_encrypt4);
            
            Tuple<Tuple<int, int>, Tuple<int, int>> RSA_keys = Encrypto.rsa_key_generation();
            Tuple<Tuple<int, int>, Tuple<int, int>> custom_RSA_keys = new Tuple<Tuple<int, int>, Tuple<int, int>>(new Tuple<int, int>(589, 73), new Tuple<int, int>(589, 37));

            Console.WriteLine("Ce - " + Encrypto.caesar_cipher_encrypt(to_encrypt, key));
            Console.WriteLine("Cd - " + Encrypto.caesar_cipher_decrypt(to_decrypt, key));
            Console.WriteLine();
            //Console.WriteLine("RSAe - " + Encrypto.rsa_cipher_encrypt(to_encrypt3, custom_RSA_keys.Item1));
            BigInteger[] rsa_encrypted = Encrypto.rsa_cipher_encrypt(to_encrypt3, custom_RSA_keys.Item1);
            Console.WriteLine("RSAd - " + Encrypto.rsa_cipher_decrypt(rsa_encrypted, custom_RSA_keys.Item2));
            Console.WriteLine();
            Console.WriteLine("Ve - " + Encrypto.vigenere_cipher_encrypt(to_encrypt2, key2));
            Console.WriteLine("Vd - " + Encrypto.vigenere_cipher_decrypt(to_decrypt2, key2));
            Console.WriteLine();
            Console.WriteLine("before ASE - " + BitConverter.ToString(bytes4).Replace("-", ""));
            //Console.WriteLine("ASAEd - " + Encoding.Default.GetString(Encrypto.aes_cipher_encrypt(bytes4, Encoding.ASCII.GetBytes("123456789ABCDEFG"))));
            Console.WriteLine("ASEe - " + BitConverter.ToString(Encrypto.aes_cipher_encrypt(bytes4, Encoding.ASCII.GetBytes("123456789ABCDEFG"))).Replace("-", ""));
            byte[] bytes4_aes_encrypted = Encrypto.aes_cipher_encrypt(bytes4, Encoding.ASCII.GetBytes("123456789ABCDEFG"));

            Console.WriteLine("! " + BitConverter.ToString(bytes4).Replace("-", ""));
            Console.WriteLine("\" " + BitConverter.ToString(bytes4_aes_encrypted).Replace("-", ""));

            byte[] bytes4_aes_decrypted = Encrypto.aes_cipher_decrypt(bytes4_aes_encrypted, Encoding.ASCII.GetBytes("123456789ABCDEFG"));
            
            Console.WriteLine("$ " + BitConverter.ToString(bytes4_aes_decrypted).Replace("-", ""));

            Console.WriteLine("ASEd - " + BitConverter.ToString(bytes4_aes_decrypted).Replace("-", ""));
            //Console.WriteLine(Encrypto.aes_cipher_encrypt(to_encrypt5));
            Console.WriteLine();
            
            /* A col mix test that worked successfully!
            byte[,] bbb = new byte[,] { { 0xdb }, { 0x13 }, { 0x53 }, { 0x45 } };
            byte[,] bbbb = Encrypto.internet_aes_mix_cols(bbb);
            Console.WriteLine("{0,10:X}, {1,10:X}, {2,10:X}, {3,10:X}", bbbb[0, 0], bbbb[1, 0], bbbb[2, 0], bbbb[3, 0]);*/

            Console.ReadKey(true);
        }
    }
}
