namespace RegisterFormApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;

        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;

        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;

        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;

        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cboCourse;

        private System.Windows.Forms.GroupBox grpStudyMode;
        private System.Windows.Forms.CheckBox chkOnline;
        private System.Windows.Forms.CheckBox chkOffline;

        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();

            this.lblPhone = new System.Windows.Forms.Label();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();

            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();

            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();

            this.lblCourse = new System.Windows.Forms.Label();
            this.cboCourse = new System.Windows.Forms.ComboBox();

            this.grpStudyMode = new System.Windows.Forms.GroupBox();
            this.chkOnline = new System.Windows.Forms.CheckBox();
            this.chkOffline = new System.Windows.Forms.CheckBox();

            this.btnRegister = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblFullName
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(30, 25);
            this.lblFullName.Text = "Họ và tên:";

            // txtFullName
            this.txtFullName.Location = new System.Drawing.Point(160, 22);
            this.txtFullName.Size = new System.Drawing.Size(200, 23);

            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(30, 60);
            this.lblPhone.Text = "Số điện thoại:";

            // mtxtPhone - Mask (000) 000-0000
            this.mtxtPhone.Location = new System.Drawing.Point(160, 57);
            this.mtxtPhone.Size = new System.Drawing.Size(200, 23);
            this.mtxtPhone.Mask = "(000) 000-0000";

            // lblBirthDate
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(30, 95);
            this.lblBirthDate.Text = "Ngày sinh:";

            // dtpBirthDate - Format Short, tuỳ chỉnh dd/MM/yyyy
            this.dtpBirthDate.Location = new System.Drawing.Point(160, 92);
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 23);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.CustomFormat = "dd/MM/yyyy";

            // lblGender
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(30, 130);
            this.lblGender.Text = "Giới tính:";

            // rbMale
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(160, 128);
            this.rbMale.Text = "Nam";
            this.rbMale.Checked = true;

            // rbFemale
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(240, 128);
            this.rbFemale.Text = "Nữ";

            // lblCourse
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(30, 165);
            this.lblCourse.Text = "Khóa học:";

            // cboCourse
            this.cboCourse.Location = new System.Drawing.Point(160, 162);
            this.cboCourse.Size = new System.Drawing.Size(200, 23);
            this.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // grpStudyMode
            this.grpStudyMode.Location = new System.Drawing.Point(30, 200);
            this.grpStudyMode.Size = new System.Drawing.Size(330, 60);
            this.grpStudyMode.Text = "Hình thức học";
            this.grpStudyMode.Controls.Add(this.chkOnline);
            this.grpStudyMode.Controls.Add(this.chkOffline);

            // chkOnline
            this.chkOnline.AutoSize = true;
            this.chkOnline.Location = new System.Drawing.Point(20, 25);
            this.chkOnline.Text = "Online";

            // chkOffline
            this.chkOffline.AutoSize = true;
            this.chkOffline.Location = new System.Drawing.Point(120, 25);
            this.chkOffline.Text = "Offline";

            // btnRegister
            this.btnRegister.Location = new System.Drawing.Point(160, 275);
            this.btnRegister.Size = new System.Drawing.Size(100, 32);
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(400, 330);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.grpStudyMode);
            this.Controls.Add(this.btnRegister);
            this.Text = "Đăng ký khóa học";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}