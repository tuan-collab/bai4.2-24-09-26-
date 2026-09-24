# Nguyễn Duy Tuấn - 24810310492

## Form Đăng Ký Khóa Học – ComboBox Binding, RadioButton, CheckBox, DateTimePicker, MaskedTextBox

Bài tập Windows Forms (C#): form đăng ký khóa học dùng nhiều loại control nhập liệu khác nhau, có binding dữ liệu cho ComboBox.

## Cấu trúc project

```
RegisterFormApp/
├── Form1.cs              # Class Course + logic: nạp danh sách khóa học, xử lý đăng ký
├── Form1.Designer.cs     # Khai báo control: TextBox, MaskedTextBox, DateTimePicker, RadioButton, CheckBox, ComboBox
├── Program.cs            # Điểm khởi chạy ứng dụng
└── README.md
```

## Kết quả

- Nhập họ tên, số điện thoại theo đúng mask, chọn ngày sinh, giới tính, khóa học và hình thức học.
- Bấm "Đăng ký" → nếu thiếu tên hoặc SĐT chưa đủ số, hiện cảnh báo; nếu hợp lệ, hiện `MessageBox` tổng hợp toàn bộ thông tin đã nhập.

<!-- Chèn ảnh chụp màn hình giao diện thực tế vào đây, ví dụ: -->
<img width="1215" height="572" alt="Screenshot 2026-09-24 153613" src="https://github.com/user-attachments/assets/401c23fc-18a7-433a-8d6d-48674f8933c1" />

