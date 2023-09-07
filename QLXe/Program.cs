using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DSXE ds = new DSXE();
            XE xe;
            
            string chon;

            ds.them_xe(new OTO(new DateTime(2022,8,23), 93, "H1", 6, 1));
            ds.them_xe(new TAI(new DateTime(2021, 7, 10), 93, "H1",15000));
            ds.them_xe(new OTO(new DateTime(2019, 6, 30), 93, "H1", 2, 0));
            ds.them_xe(new OTO(new DateTime(2022, 8, 1), 93, "H1", 9, 1));
            ds.them_xe(new TAI(new DateTime(2020, 9, 7), 93, "H1", 6000));
            ds.them_xe(new TAI(new DateTime(2022, 8, 15), 93, "H1", 23000));
            ds.them_xe(new OTO(new DateTime(2017, 4, 23), 93, "H1", 15, 0));
            ds.them_xe(new OTO(new DateTime(2022, 8, 6), 93, "H1", 7, 0));
            ds.them_xe(new TAI(new DateTime(2002, 8, 15), 93, "H1", 23000));
            do
            {
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. Them 1 xe oto");
                Console.WriteLine("2. Them 1 xe tai");
                Console.WriteLine("3. Xuat thong tin tat ca cac xe");
                Console.WriteLine("4. Tim xe co so cho ngoi nhieu nhat");
                Console.WriteLine("5. Sap xep trong tai xe tang dan");
                Console.WriteLine("6. Xuat danh sach cac bien so xe dep");
                Console.WriteLine("7. Tinh so tien đang kiem đinh ky cua tung xe đen thoi điem hien tai.");
                Console.WriteLine("8. Tinh thoi gian dang kiem dinh ki cua tung xe sap toi");
                Console.WriteLine("9. Tong so tien da dang kiem");
                chon = Console.ReadLine();
                switch(chon)
                {
                    case "1":
                        xe = new OTO();
                        xe.input();
                        ds.them_xe(xe);
                        break;
                    case "2":
                        xe = new TAI();
                        xe.input();
                        ds.them_xe(xe);
                        break;
                    case "3":
                        ds.xuat_dsxe();
                        break;
                    case "4":
                        ds.tim_OtoNhieuChoNgoi();
                        break; 
                    case "5":
                        ds.sort_TrongTai();
                        break;
                    case "6":
                        ds.List_BienSoXe_Dep();
                        break;
                    case "7":
                        ds.TinhTienDK();
                        break;
                    case "8":
                        ds.TinhTGDangKiemDinhKi();
                        break;
                    case "9":
                        ds.TongTienDK();
                        break;
                    default:
                        chon = "0";
                        break;
                }
            } while (chon != "0");
            
            Console.ReadLine();
        }
    }
}
