using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RegisterFormApp
{
    // Lớp dùng để binding cho cboCourse (DisplayMember/ValueMember)
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public Course(int id, string name)
        {
            CourseId = id;
            CourseName = name;
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCourses();
        }

        // Nạp danh sách khóa học vào cboCourse, dùng DisplayMember/ValueMember
        private void LoadCourses()
        {
            List<Course> courses = new List<Course>
            {
                new Course(1, "Lập trình C#"),
                new Course(2, "Lập trình C++"),
                new Course(3, "Cơ sở dữ liệu"),
                new Course(4, "Phát triển Web"),
                new Course(5, "Cấu trúc dữ liệu & Giải thuật")
            };

            cboCourse.DataSource = courses;
            cboCourse.DisplayMember = "CourseName"; // hiển thị
            cboCourse.ValueMember = "CourseId";     // giá trị thực

            cboCourse.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!mtxtPhone.MaskCompleted)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số điện thoại theo định dạng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gender = rbMale.Checked ? "Nam" : "Nữ";
            string courseName = (cboCourse.SelectedItem as Course)?.CourseName;
            int courseId = (int)cboCourse.SelectedValue;

            List<string> studyModes = new List<string>();
            if (chkOnline.Checked) studyModes.Add("Online");
            if (chkOffline.Checked) studyModes.Add("Offline");
            string studyModeText = studyModes.Count > 0 ? string.Join(", ", studyModes) : "Chưa chọn";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("THÔNG TIN ĐĂNG KÝ");
            sb.AppendLine($"Họ và tên: {txtFullName.Text}");
            sb.AppendLine($"Số điện thoại: {mtxtPhone.Text}");
            sb.AppendLine($"Ngày sinh: {dtpBirthDate.Value:dd/MM/yyyy}");
            sb.AppendLine($"Giới tính: {gender}");
            sb.AppendLine($"Khóa học: {courseName} (Mã: {courseId})");
            sb.AppendLine($"Hình thức học: {studyModeText}");

            MessageBox.Show(sb.ToString(), "Đăng ký thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}