using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXe
{
    internal class OTO : XE
    {
        protected int sochongoi;
        int dk_kingdoanhvantai;        

        #region Constructor

        public OTO()
        {
        }

        public OTO(DateTime NgaySX, int MaTinh, string seri, int sochongoi, int dk_kingdoanhvantai) : base(NgaySX, MaTinh, seri)
        {
            this.Sochongoi = sochongoi;
            this.Dk_kingdoanhvantai = dk_kingdoanhvantai;
        }

        
        #endregion
        public int Sochongoi { get => sochongoi; set => sochongoi = value; }
        public int Dk_kingdoanhvantai { get => dk_kingdoanhvantai; set => dk_kingdoanhvantai = value; }


        public override void input()
        {
            base.input();
            Console.WriteLine("Nhap vao so cho ngoi: ");
            Sochongoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Co dang ki kinh doanh van tai khong ? (1/0)");
            Dk_kingdoanhvantai = int.Parse(Console.ReadLine());
        }

        public override void output()
        {
            base.output();
            Console.WriteLine("So cho ngoi: {0}", Sochongoi);
            if (Dk_kingdoanhvantai == 0) Console.WriteLine("Khong dang ki kinh doanh");
            else Console.WriteLine("Co dang ki kinh doanh");
        }

        public override long TienDangKiem()
        {
            long tien = 0;
            DateTime today = DateTime.Now;
            int n = today.Year - ngaySX.Year;
            if (n <= 7)
            {
                if (sochongoi <= 9)
                {
                    if (dk_kingdoanhvantai == 0)
                    {
                        tien = (long)((0.5 * n) * 240000);
                    }
                    else
                    {
                        tien = (n * 240000);
                    }
                } else
                {
                    if (sochongoi == 10)
                    {
                        tien = (n * 240000);
                    } else if (sochongoi > 10)
                    {
                        tien = (n * 320000);
                    }
                }
            } else
            {
                int m = n - 7;
                if (sochongoi <= 9)
                {
                    if (dk_kingdoanhvantai == 0)
                    {
                        tien = (long)((0.5 * 7) * 240000);
                    }
                    else
                    {
                        tien = (7 * 240000);
                    }
                }
                else
                {
                    if (sochongoi == 10)
                    {
                        tien = (7 * 240000);
                    }
                    else if (sochongoi > 10)
                    {
                        tien = (7 * 320000);
                    }
                }

                if (sochongoi <= 10)
                {
                    tien += (long)((2*m)*240000);
                } else
                {
                    tien += (long)((2 * m) * 320000);
                }
                
            }
            return tien;
        }

        public override DateTime ThoiGianDangKiemDK()
        {
            DateTime tg;
            DateTime today = DateTime.Now;
            int n = today.Year - ngaySX.Year;
            if (n <= 7)
            {
                if (sochongoi <= 9)
                {
                    if (dk_kingdoanhvantai == 0)
                    {
                        if (n % 2 == 0)
                            tg = ngaySX.AddYears(n + 2);
                        else
                            tg = ngaySX.AddYears(n + 1);
                    }
                    else
                    {
                        tg = ngaySX.AddYears(n + 1);
                    }
                }
                else
                {
                    tg = ngaySX.AddYears(n + 1);
                }
            }
            else
            {
                if (sochongoi <= 9)
                {
                    if (dk_kingdoanhvantai == 0)
                    {
                        if (n % 2 == 0)
                            tg = ngaySX.AddYears(n + 2);
                        else
                            tg = ngaySX.AddYears(n + 1);
                    }
                    else
                    {
                        tg = ngaySX.AddYears(n + 1);
                    }
                }
                else
                {
                    int m = n - 7;
                    tg = ngaySX.AddYears(7);
                    tg = tg.AddMonths(6+12*m);
                }
            }
            return tg;
        }
    }
}
