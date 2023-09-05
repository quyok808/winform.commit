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
    }
}
