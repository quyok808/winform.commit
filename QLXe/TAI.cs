using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXe
{
    internal class TAI : XE
    {
        long trongtai;
        #region constructor
        public TAI()
        {
        }

        public TAI(DateTime NgaySX, int MaTinh, string seri,long trongtai) : base(NgaySX, MaTinh, seri)
        {
            this.Trongtai = trongtai;
        }
        
        #endregion
        public long Trongtai { get => trongtai; set => trongtai = value; }

        public override void input()
        {
            base.input();
            Console.WriteLine("Nhap vao trong tai cua xe: ");
            Trongtai = long.Parse(Console.ReadLine());
        }

        public override void output()
        {
            base.output();
            Console.WriteLine("Trong tai: {0}kg", Trongtai);
        }
    }
}
