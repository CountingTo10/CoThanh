using System;
using System.Text;



namespace BookStore1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ChucNang chucNang = new ChucNang();
            chucNang.HienThiDanhSachChucNang();
            chucNang.getMaChucNang();
            chucNang.ThucHienChucNang();

            Console.WriteLine("Nhấn phím bất kỳ để thoát.");
            Console.ReadKey();
        }
    }
}
;
