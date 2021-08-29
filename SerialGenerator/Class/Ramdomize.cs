using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialGenerator.Class
{
    public class Ramdomize
    {
        private readonly static Random random = new(); 
        private int SizeString { get; set; }
        private int Divisors { get; set; }
        private string Serial { get; set; }
        private bool Upper { get; set; }
        private bool Lower { get; set; }
        private bool Number { get; set; }

        const string charAll = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        const string charLowerNumbers = "abcdefghijklmnopqrstuvwxyz0123456789";
        const string charUpperNumbers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        const string charUpperLower = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        const string charUppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string charLowers = "abcdefghijklmnopqrstuvwxyz";
        const string charNumbers = "0123456789";
        
        public Ramdomize()
        {
        }

        public Ramdomize(int sizeString, int divisors, bool upper, bool lower, bool number)
        {
            SizeString = sizeString;
            Divisors = divisors;
            Upper = upper;
            Lower = lower;
            Number = number;
        }
        public void Ramdom() 
        {
            if (Upper && Lower && Number)
            {
                Serial = GenerateString(charAll);
            }
            else if (Upper && Lower)
            {
                Serial = GenerateString(charUpperLower);
            }
            else if (Upper && Number)
            {
                Serial = GenerateString(charUpperNumbers);
            }
            else if (Lower && Number)
            {
                Serial = GenerateString(charLowerNumbers);
            }
            else if (Upper) 
            {
                Serial = GenerateString(charUppers);
            }
            else if (Lower)
            {
                Serial = GenerateString(charLowers);
            }
            else if (Number)
            {
                Serial = GenerateString(charNumbers);
            }
        }
        private string GenerateBox(string characters) 
        {
               return new string (Enumerable.Repeat(characters, SizeString).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private string GenerateString(string characters) 
        {
            string serial = "";
            if (Divisors == 0) 
            {
                serial = GenerateBox(characters);
            }
            else 
            {
                for (int i = 0; i <= Divisors; i++)
                {
                    if (Divisors == i)
                    {
                        serial += GenerateBox(characters);
                    }
                    else 
                    {
                        serial += $"{GenerateBox(characters)}-";
                    }
                }
            }
            return serial;
        }
        public string SerialWithDivider()
        {
            return Serial;
        }
        public string SerialWithoutDivider()
        {
            return Serial.Replace("-", "");
        }
    }
}
