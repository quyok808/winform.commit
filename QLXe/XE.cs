using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXe
{
    internal class XE
    { 
        protected DateTime ngaySX;
        private BIENSO bs = new BIENSO();
        protected string BienSo;

        #region Constructor
        public XE(DateTime NgaySX, int MaTinh, string seri)
        {
            ngaySX = NgaySX;
            BienSo = bs.Create_BS(MaTinh, seri);
        }

        public XE()
        {           
        }
        #endregion

        
        public virtual void input()
        { 
            Console.WriteLine("Nhap vao ngay thang nam san xuat: ");
            ngaySX = DateTime.Parse(Console.ReadLine());
            int ma_tinh;
            string seri;
            Console.WriteLine("Nhap ma tinh: ");
            ma_tinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ma seri: ");
            seri = Console.ReadLine();
            //BienSo = bs.Create_BS(ma_tinh, seri);
            BienSo = bs.Create_BSDep(ma_tinh, seri,"99997");
        }

        public virtual void output()
        {
            Console.Write("Ngay sx: {0}\n", ngaySX.GetDateTimeFormats());
            Console.Write("Bien so: {0}\n", BienSo);
        }

        public bool Check_Bien_Dep()
        {
            
        }
    }
}
