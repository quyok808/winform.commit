using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXe
{
    internal class DSXE
    {
        List<XE> ds = new List<XE>();

        public void them_xe(XE x)
        {
            ds.Add(x);
        }

        public void xuat_dsxe()
        {
            ds.ForEach(x => { x.output(); Console.WriteLine("------------------"); });
        }

        public void tim_OtoNhieuChoNgoi()
        {
            var max_cho = ds.Where(x => x is OTO).Max(x => (x as OTO).Sochongoi);
            List<XE> kq = ds.Where(x => x is OTO && (x as OTO).Sochongoi == max_cho).ToList();
            kq.ForEach(x => { x.output(); Console.WriteLine("---------"); });
        }

        public void sort_TrongTai()
        {
            List<XE> kq2 = ds.Where(x=>x is TAI).OrderBy(x => (x as TAI).Trongtai).ToList(); 
            kq2.ForEach(x => { x.output(); Console.WriteLine("---------"); });
        }

        public void List_BienSoXe_Dep()
        {
            
        }
    }
}
