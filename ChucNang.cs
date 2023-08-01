
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore1{
    public class ChucNang {

        public ChucNang() {
        }

        public int maChucNang;
        public string tenChucNang;

        /*public void CacChucNang()
        {
            maChucNang = 2;
            tenChucNang = "Thêm Nhân Viên";
        }*/
        public void HienThiDanhSachChucNang()
        {
            Console.WriteLine("**** QUẢN Lý NHÀ SÁCH ****");
            Console.WriteLine("Danh sách các chức năng:");
            Console.WriteLine("1. Thông tin nhân viên");
            Console.WriteLine("2. Thêm nhân viên");
            Console.WriteLine("3. Cập Nhật Nhân Viên");
            // Thêm các chức năng khác vào đây nếu cần

        }
        public void getMaChucNang() {
            Console.WriteLine("Nhập mã chức năng:");
            maChucNang = int.Parse(Console.ReadLine());
            switch (maChucNang)
            {
                case 1:
                    tenChucNang = "Thông tin nhân viên";
                    break;
                case 2:
                    tenChucNang = "Thêm nhân viên";
                    break;
                case 3:
                    tenChucNang = "Cập Nhật Nhân Viên";
                    break;
                default:
                    xacNhanMaChucNang();
                    break;
            }
            Console.WriteLine($"Bạn đã chọn chức năng: {tenChucNang}");
        }

        public bool xacNhanMaChucNang() {
            if (maChucNang >= 1 && maChucNang <= 3)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Mã chức năng không hợp lệ.");
                return false;
            }
        }
        
        public void ThucHienChucNang()
        {
            NhanVien nhanVien = new NhanVien();

            switch (maChucNang)
            {
                case 1:
                    break;
                case 2:
                    Console.Write("Nhấn Enter để chuyển sang trang thêm Nhân Viên\r\n"); 
                    Console.ReadKey();
                    Console.Clear();
                    nhanVien.getMaNhanVien();
                    nhanVien.xacNhanMaNhanVien();
                    break;
                case 3:
                    // Gọi các phương thức cho chức năng 3 tại đây (nếu có)
                    break;
                // Triển khai các chức năng khác tương tự
                default:
                    Console.WriteLine("Mã chức năng không hợp lệ.");
                    break;
            }
        }


    }
}