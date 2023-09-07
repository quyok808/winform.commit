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

        public override long TienDangKiem()
        {
            long tien = 1;
            DateTime today = DateTime.Now;
            int n = today.Year - ngaySX.Year;
            if (n <= 20)
            {
                if (trongtai > 20000) 
                {
                    tien = (long)((2 * n)*560000);
                }else if (trongtai >= 7000)
                {
                    tien = (long)((2 * n) * 350000);
                }
                else
                {
                    tien = (long)((2 * n) * 320000);
                } 
            } else
            {
                int m = n - 20;

                if (trongtai > 20000)
                {
                    tien = (long)((2 * 20) * 560000);
                }
                else if (trongtai >= 7000)
                {
                    tien = (long)((2 * 20) * 350000);
                }
                else
                {
                    tien = (long)((2 * 20) * 320000);
                } 


                if (trongtai > 20000)
                {
                    tien += (long)((4 * m) * 560000);
                }
                else if (trongtai >= 7000)
                {
                    tien += (long)((4 * m) * 350000);
                }
                else
                {
                    tien += (long)((4 * m) * 320000);
                }
            }
            return tien;
        }

        public override DateTime ThoiGianDangKiemDK()
        {
            DateTime tg;
            DateTime today = DateTime.Now;
            int n = today.Year - ngaySX.Year;
            if (n <= 20)
            { 
                tg = ngaySX.AddMonths(6 + 12 * n);
            }
            else
            {
                tg = ngaySX.AddYears(20);
                while(tg.Year < today.Year || tg.Month < today.Month)
                {
                    tg = tg.AddMonths(3);
                }
            }
            
            return tg;
        }
    }
}
