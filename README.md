## README

### Dự án Phần mềm Ngân hàng

Đây là một dự án phần mềm ngân hàng được phát triển để cung cấp các tính năng cơ bản của một ngân hàng, bao gồm cập nhật thông tin khách hàng, mở tài khoản, quản lý nhân viên và ghi nhận các giao dịch tài chính. Dự án cũng bao gồm các tính năng liệt kê và thống kê dữ liệu, cũng như quản trị hệ thống với phân quyền người dùng.

### Các chức năng chính:

#### A. Cập nhật:
1. **Cập nhật Khách hàng**
   - Thêm, xóa, sửa thông tin khách hàng.
2. **Mở tài khoản cho khách hàng**
   - Thêm mới tài khoản cho khách hàng.
3. **Cập nhật nhân viên**
   - Thêm, xóa, sửa thông tin nhân viên.
   - Chuyển nhân viên qua chi nhánh khác.
4. **Cập nhật các giao dịch của khách**
   - Ghi nhận giao dịch: gửi tiền, rút tiền, chuyển tiền.
   - Hỗ trợ các chức năng: Thêm, xóa, phục hồi, ghi và thoát.

#### B. Liệt kê - Thống kê
1. **Sao kê giao dịch của 1 tài khoản trong 1 khoảng thời gian**
   - Hiển thị thông tin chi tiết về các giao dịch của tài khoản trong khoảng thời gian đã chọn.
2. **Liệt kê các tài khoản mở trong 1 khoảng thời gian của chi nhánh**
   - Hiển thị danh sách các tài khoản được mở trong một khoảng thời gian cụ thể của một hoặc tất cả các chi nhánh.
3. **Liệt kê các khách hàng theo từng chi nhánh**
   - Sắp xếp và hiển thị thông tin khách hàng theo từng chi nhánh, theo thứ tự tăng dần theo họ tên.

#### C. Quản trị:
- Phân quyền quản trị cho 2 nhóm: Ngân hàng và Chi nhánh.
- Người dùng thuộc nhóm Ngân hàng có thể chọn chi nhánh để xem báo cáo và dữ liệu tương ứng.
- Người dùng thuộc nhóm Chi nhánh chỉ có quyền làm việc trên chi nhánh mà họ đã đăng nhập.
- Hỗ trợ tạo tài khoản đăng nhập với các quyền hạn tương ứng.

### Hướng dẫn cài đặt:

1. Clone repository từ GitHub:

```
git clone https://github.com/huynhngoanhthai/distribute_SQL_Server.git
```

2. Mở dự án trong môi trường phát triển (IDE) của bạn.

3. Cấu hình môi trường và cài đặt các thư viện cần thiết (nếu có).

4. Chạy ứng dụng và trải nghiệm các tính năng.

### Công nghệ sử dụng:

- Ngôn ngữ lập trình: [C#]
- Framework: [Winform]

### Tác giả:

- [THÁI](mailto:huynhngoanhthai@gmail.com)

### Bản quyền:

Dự án được phát hành dưới giấy phép [MIT License](LICENSE).
