using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SV> listSV = new List<SV>();
            SV sV;

            listSV.Add(new SV("1", "A", "CNTT", 4.0));
            listSV.Add(new SV("2", "B", "NNA", 7.0));
            listSV.Add(new SV("3", "C", "nna", 5.0));
            listSV.Add(new SV("8", "D", "cntt", 1.0));
            listSV.Add(new SV("14", "E", "CnTT", 9.0));
            listSV.Add(new SV("19", "F", "cntt", 8.0));
            listSV.Add(new SV("5", "G", "cntt", 10.0));
            listSV.Add(new SV("7", "H", "CNTT", 8.0));

            string chon;
            do
            {
                Console.WriteLine("1. Them sv");
                Console.WriteLine("2. Xuat dssv");
                Console.WriteLine("3. Xuat sv khoa cntt");
                Console.WriteLine("4. Xuat sv co1 dtb >= 5");
                Console.WriteLine("5. Xuat dssv co1 dtb tang dan");
                Console.WriteLine("6. Xuat dssv co dtb >= 5 va khoa cntt");
                Console.WriteLine("Chon chuc nang: ");
                chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        sV = new SV();
                        sV.Input();
                        listSV.Add(sV);
                        break;
                    case "2":
                        listSV.ForEach(s => { s.Output(); });
                        break;
                    case "3":
                        List<SV> kq1 = listSV.Where(x => x.Khoa.Equals("cntt",StringComparison.OrdinalIgnoreCase)).ToList();
                        kq1.ForEach(p=> { p.Output(); });
                        break;
                    case "4":
                        List<SV> kq2 = listSV.Where(x => x.Dtb >= 5).ToList();
                        kq2.ForEach(p => { p.Output(); });
                        break;
                    case "5":
                        List<SV> kq3 = listSV.OrderBy(x => x.Dtb).ToList();
                        kq3.ForEach(p => { p.Output(); });
                        break;
                    case "6":
                        List<SV> kq4 = listSV.Where(x => x.Dtb >= 5 && x.Khoa.Equals("cntt", StringComparison.OrdinalIgnoreCase)).ToList();
                        kq4.ForEach(p => { p.Output(); });
                        break;
                    default:
                        chon = "0";
                        break;
                }
            } while (chon != "0");
        }

    }
}
