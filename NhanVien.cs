
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore1{
    public class NhanVien {

        public NhanVien() {
        }
        public List<string> maNhanVienList = new List<string>() { "NV001", "NV002", "NV003" };

        public string  maNhanVien;

        public string tenNhanVien;

        public string diaChi;

        public int soDienThoai;

        public string TaiKhoan;

        public string MatKhau;

        public string Email;

        public DateTime NgaySinh;

        public void getMaNhanVien() {
            Console.WriteLine("Nhập mã nhân viên:");
            maNhanVien = Console.ReadLine();
        }

        public void luuThongTinNhanVien() {
            // TODO implement here
        }

        public void huyLuuThongTinNhanVien() {
            // TODO implement here
        }

        public void xacNhanMaNhanVien() {
            if (maNhanVienList.Contains(maNhanVien))
            {
                Console.WriteLine("Mã nhân viên đã tồn tại. Vui lòng nhập mã nhân viên khác.");
                getMaNhanVien(); // Yêu cầu người dùng nhập mã nhân viên mới
                if (maNhanVienList.Contains(maNhanVien))
                {
                    /*Console.WriteLine("Mã nhân viên đã tồn tại. Vui lòng nhập mã nhân viên khác.");*/
                    xacNhanMaNhanVien();
                }
                else
                {
                    themNhanVienMoi();
                }
            }
            else
            {
                themNhanVienMoi();
            }
        }

        public void capNhanThongTinNhanVien() {
            // TODO implement here
        }

        public void themNhanVienMoi() {
            Console.WriteLine("Thêm thông tin nhân viên mới:");

            Console.WriteLine($"Mã nhân viên: {maNhanVien} ");


            Console.Write("Nhập tên nhân viên:");
            tenNhanVien = Console.ReadLine();

            Console.Write("Nhập địa chỉ:");
            diaChi = Console.ReadLine();

             bool isValidPhoneNumber = false;
            do
            {
                Console.WriteLine("Nhập số điện thoại:");
                if (int.TryParse(Console.ReadLine(), out int phoneNumber))
                {
                    // Số điện thoại hợp lệ
                    soDienThoai = phoneNumber;
                    isValidPhoneNumber = true;
                }
                else
                {
                    Console.WriteLine("Số điện thoại không hợp lệ. Vui lòng nhập lại.");
                }
            } while (!isValidPhoneNumber);

            Console.Write("Nhập tài khoản:");
            TaiKhoan = Console.ReadLine();

            Console.Write("Nhập mật khẩu:");
            MatKhau = Console.ReadLine();

            Console.Write("Nhập email:");
            Email = Console.ReadLine();

            Console.WriteLine("Nhập ngày sinh (định dạng dd/MM/yyyy):");
            NgaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Clear();
            Console.WriteLine("Thông tin nhân viên đã nhập:");
            Console.WriteLine($"Tên nhân viên: {tenNhanVien}");
            Console.WriteLine($"Địa chỉ: {diaChi}");
            Console.WriteLine($"Số điện thoại: {soDienThoai}");
            Console.WriteLine($"Tài khoản: {TaiKhoan}");
            Console.WriteLine($"Mật khẩu: {MatKhau}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Ngày sinh: {NgaySinh.ToString("dd/MM/yyyy")}");

            Console.WriteLine("Bạn có muốn thêm nhân viên này không? (Y/N):");
            string confirm = Console.ReadLine();

            if (confirm.ToLower() == "y")
            {
                // Lưu thông tin nhân viên vào danh sách, database, hoặc thực hiện các thao tác khác cần thiết.
                // ...
                Console.WriteLine("Thêm nhân viên thành công.");
            }
            else
            {
                Console.WriteLine("Đã hủy thêm nhân viên.");

            }
            
        }

    }
}