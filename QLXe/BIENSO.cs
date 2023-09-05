using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace QLXe
{
    internal class BIENSO
    {
        private int matinh;
        private string seri;
        private string songaunhien;

        public BIENSO(int matinh, string seri)
        {
            this.matinh = matinh;
            this.seri = seri;
        }

        public BIENSO()
        {
        }

        public int Matinh { get => matinh; set => matinh = value; }
        public string Seri { get => seri; set => seri = value; }

        private static String digits = "0123456789";
        
 
        private static Random generator = new Random();

        public string randomAlphaNumeric(int numberOfCharactor)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < numberOfCharactor; i++)
            {
                int number = randomNumber(0, digits.Length - 1);
                char ch = digits[number];
                sb.Append(ch);
            }
            return sb.ToString();
        }

        public int randomNumber(int min, int max)
        {
            return generator.Next((max - min) + 1) + min;
        }

        public string Create_BS(int MaTinh, string seri)
        {
            string BS = MaTinh.ToString() + seri + "-";
            songaunhien = randomAlphaNumeric(5);
            return BS + songaunhien;
        }

        public string Create_BSDep(int MaTinh, string seri, string socuoi)
        {
            string BS = MaTinh.ToString() + seri + "-";
            songaunhien = socuoi;
            return BS + songaunhien;
        }
    }
}
