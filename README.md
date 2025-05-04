# MobileShoppe

**MobileShoppe** là phần mềm quản lý bán hàng điện thoại di động, hỗ trợ thao tác với thông tin khách hàng, sản phẩm, tồn kho và giao dịch bán hàng.

## ⚙️ Yêu cầu hệ thống

- Hệ điều hành: Windows 10 trở lên
- .NET Framework: 4.7.2 trở lên
- SQL Server: SQL Server 2016 trở lên (hoặc tương thích)

## 🛠️ Cài đặt và khởi chạy

### 1. Cài đặt cơ sở dữ liệu

1. Mở **SQL Server Management Studio (SSMS)**.
2. Kết nối đến **SQL Server Instance** của bạn.
3. Mở tệp `MobileShoppe.sql` (có sẵn trong thư mục gốc dự án).
4. Thực thi toàn bộ script để tạo và khởi tạo dữ liệu cho cơ sở dữ liệu MobileShoppe.

> **Lưu ý:** Đảm bảo bạn có quyền `CREATE DATABASE` và `INSERT` trên server đang sử dụng.

### 2. Chạy ứng dụng

1. Mở solution bằng **Visual Studio**.
2. Kiểm tra chuỗi kết nối trong file cấu hình (nếu có) và đảm bảo trỏ đúng đến SQL Server vừa tạo ở bước trên.
3. Build và chạy chương trình (`F5` hoặc `Ctrl + F5`).

## 📁 Các tính năng chính

- Đăng nhập người dùng
- Quản lý khách hàng và đơn hàng
- Quản lý kho hàng điện thoại (IMEI, trạng thái bán, giá)
- Thống kê doanh thu theo khoảng thời gian
- Báo cáo tồn kho theo hãng và model

## 📌 Lưu ý

- Trước khi chạy chương trình, bạn **bắt buộc** phải thực thi file `MobileShoppe.sql` trong SQL Server.
- Chương trình sử dụng stored procedure và các ràng buộc liên kết dữ liệu nên cần đúng cấu trúc DB.

## 👨‍💻 Tác giả

- Lam Tri Phuc
- [Liên hệ hỗ trợ qua GitHub Issues hoặc email nếu cần]
