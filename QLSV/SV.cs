using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    internal class SV
    {
        private string maso;
        private string hoten;
        private string khoa;
        private double dtb;


        #region Constructer
        public SV(string maso, string hoten, string khoa, double dtb)
        {
            this.maso = maso;
            this.hoten = hoten;
            this.khoa = khoa;
            this.dtb = dtb;
        }
        
        public SV()
        {
        }
        #endregion

        #region Getter_And_Setter
        public string Maso { get => maso; set => maso = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public double Dtb { get => dtb; set => dtb = value; }
        #endregion

        public void Input()
        {
            Console.WriteLine("Nhap masv: ");
            Maso = Console.ReadLine();
            Console.WriteLine("Nhap ho ten sv: ");
            Hoten = Console.ReadLine();
            Console.WriteLine("Nhap khoa: ");
            Khoa = Console.ReadLine();
            Console.WriteLine("Nhap dtb: ");
            dtb = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine(maso + " - " + hoten + " - " + khoa + " - " + dtb);
        }
    }
}
