# Form Đăng Ký Khóa Học – ComboBox Binding, RadioButton, CheckBox, DateTimePicker, MaskedTextBox

Bài tập Windows Forms (C#): form đăng ký khóa học dùng nhiều loại control nhập liệu khác nhau, có binding dữ liệu cho ComboBox.

## Nguyễn Duy Tuấn - 4810310492

Sử dụng ComboBox (Binding Data), RadioButton, CheckBox, DateTimePicker & MaskedTextBox.

## Yêu cầu và cách đáp ứng

| Yêu cầu | Cách thực hiện |
|---|---|
| `mtxtPhone`: Mask SĐT `(000) 000-0000` | `mtxtPhone.Mask = "(000) 000-0000"`, kiểm tra `MaskCompleted` trước khi xử lý |
| `dtpBirthDate`: Format Short (dd/MM/yyyy) | `Format = Custom`, `CustomFormat = "dd/MM/yyyy"` |
| `cboCourse`: Nạp danh sách khóa học (DisplayMember, ValueMember) | Binding `List<Course>` với `DisplayMember = "CourseName"`, `ValueMember = "CourseId"` |
| Nút "Đăng ký": tổng hợp và in thông tin lên MessageBox | `btnRegister_Click` gom tên, SĐT, ngày sinh, giới tính (RadioButton), khóa học, hình thức học (CheckBox) rồi hiển thị `MessageBox` |

## Công nghệ

- C# / .NET Windows Forms

## Cấu trúc project

```
RegisterFormApp/
├── Form1.cs              # Class Course + logic: nạp danh sách khóa học, xử lý đăng ký
├── Form1.Designer.cs     # Khai báo control: TextBox, MaskedTextBox, DateTimePicker, RadioButton, CheckBox, ComboBox
├── Program.cs            # Điểm khởi chạy ứng dụng
└── README.md
```

## Cách chạy

1. Mở Visual Studio → **File > New Project** → chọn **Windows Forms App (.NET)**.
2. Đặt tên project là `RegisterFormApp` (trùng namespace trong code).
3. Thay nội dung 3 file `Form1.cs`, `Form1.Designer.cs`, `Program.cs` bằng code trong repo.
4. Nhấn **F5** để chạy.

## Kết quả

- Nhập họ tên, số điện thoại theo đúng mask, chọn ngày sinh, giới tính, khóa học và hình thức học.
- Bấm "Đăng ký" → nếu thiếu tên hoặc SĐT chưa đủ số, hiện cảnh báo; nếu hợp lệ, hiện `MessageBox` tổng hợp toàn bộ thông tin đã nhập.

<!-- Chèn ảnh chụp màn hình giao diện thực tế vào đây, ví dụ: -->
<!-- ![Register Form](screenshots/register-form.png) -->
