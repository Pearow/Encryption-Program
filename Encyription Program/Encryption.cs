using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Encryption_Program
{
    public class Encryption
    {
        public string sentence;
        private string language;

        private string[] encrypt_keys = new string[0];
        private string[] encrypt_values = new string[0];
        private string[] decrypt_keys = new string[0];
        private string[] decrypt_values = new string[0];

        private bool dictloaded;
        public Encryption(string Asentence, string Alanguage)
        {
            sentence = Asentence;
            language = Alanguage;
            LoadLang();
        }

        private void LoadLang()
        {
            string path = "Dicts/" + language + ".txt";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path, Encoding.UTF8);
                string[] passes = new string[lines.Length*2];
                Array.Clear(encrypt_keys, 0, encrypt_keys.Length);
                Array.Clear(encrypt_values, 0, encrypt_values.Length);
                Array.Clear(decrypt_keys, 0, decrypt_keys.Length);
                Array.Clear(decrypt_values, 0, decrypt_values.Length);
                Array.Resize(ref encrypt_keys, lines.Length);
                Array.Resize(ref encrypt_values, lines.Length);
                Array.Resize(ref decrypt_keys, lines.Length);
                Array.Resize(ref decrypt_values, lines.Length);

                int[] vs = new int[lines.Length];
                byte i = 0;
                foreach (string line in lines)
                {
                    string[] vs1 = line.Split(' ');
                    passes[i*2] = vs1[0];
                    passes[i*2+1] = vs1[1];
                    vs[i] = vs1[0].Length;
                    i++;
                }
                Array.Sort(vs);
                Array.Reverse(vs);

                byte a = 0;
                foreach(int len in vs)
                {
                    for (i = 0; i < passes.Length/2; i++)
                    {
                        if (passes[i*2].Length == len && !encrypt_keys.Contains(passes[i*2]))
                        {
                            encrypt_keys[a] = passes[i * 2];
                            encrypt_values[a] = passes[i * 2 + 1];
                            a++;
                        }
                        
                    }
                }
                Array.Clear(passes,0,passes.Length);
                Array.Clear(vs, 0, vs.Length);
                i = 0;
                foreach (string line in lines)
                {
                    string[] vs1 = line.Split(' ');
                    passes[i * 2] = vs1[0];
                    passes[i * 2 + 1] = vs1[1];
                    vs[i] = vs1[1].Length;
                    i++;
                }
                Array.Sort(vs);
                Array.Reverse(vs);
                a = 0;
                foreach (int len in vs)
                {
                    for (i = 0; i < passes.Length / 2; i++)
                    {
                        if (passes[i * 2+1].Length == len && !decrypt_values.Contains(passes[i * 2]))
                        {
                            decrypt_keys[a] = passes[i * 2 + 1];
                            decrypt_values[a] = passes[i * 2];
                            a++;
                        }
                    }
                }
                dictloaded = true;
            }
            else
            {
                Console.WriteLine("Language file not found");
                dictloaded = false;
            }
        }

        public string Encrypt()
        {
            if (!dictloaded)
            {
                return "Dictionary not loaded";
            }

            string encrypted = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                bool succes = false;
                for (int inx = 0; inx < encrypt_keys.Length; inx++)
                {
                    if (sentence[i] == ' ' || sentence[i] == '\n')
                    {
                        encrypted += sentence[i];
                        succes = true;
                        break;
                    }

                    else if (encrypt_keys[inx].Length <= sentence.Substring(i).Length && sentence.Substring(i, encrypt_keys[inx].Length) == encrypt_keys[inx])
                    {
                        encrypted += encrypt_values[inx];
                        succes = true;
                        i += encrypt_keys[inx].Length - 1;
                        break;
                    }
                }
                if (!succes)
                {
                    Console.WriteLine("Çevirilemedi {0}", sentence[i]);
                    encrypted += "µ";
                }
            }
            sentence = encrypted;
            return encrypted;
        }

        public string Decrypt()
        {
            if (!dictloaded)
            {
                return "Dictionary not loaded";
            }

            string encrypted = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                bool succes = false;
                for (int inx = 0; inx < decrypt_keys.Length; inx++)
                {
                    if (sentence[i] == ' ' || sentence[i] == '\n')
                    {
                        encrypted += sentence[i];
                        succes = true;
                        break;
                    }
                    else if (decrypt_keys[inx].Length <= sentence.Substring(i).Length && sentence.Substring(i, decrypt_keys[inx].Length) == decrypt_keys[inx])
                    {
                        encrypted += decrypt_values[inx];
                        succes = true;
                        i += decrypt_keys[inx].Length - 1;
                        break;
                    }
                }
                if (!succes)
                {
                    Console.WriteLine("Çevirilemedi {0} index {1}", sentence[i], i);
                    encrypted += "µ";
                }
            }
            sentence = encrypted;
            return encrypted;
        }

        public void ChangeDict(string new_dict)
        {
            if(File.Exists("Dicts/" + new_dict + ".txt"))
            {
                language = new_dict;
                LoadLang();
            }
            else
            {
                Console.WriteLine("Geçersiz");
            }
        }
    }
}
