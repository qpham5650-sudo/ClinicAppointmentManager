namespace ClinicAppointmentManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuExportCsv;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotal;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.TextBox txtAppointmentId;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtReason;

        private System.Windows.Forms.ComboBox cboDoctor;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;

        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;

        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.DataGridView dgvAppointments;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuExportCsv = new ToolStripMenuItem();

            statusStrip1 = new StatusStrip();
            lblTotal = new ToolStripStatusLabel();

            tableLayoutPanel1 =
                new TableLayoutPanel();

            txtAppointmentId =
                new TextBox();

            txtPatientName =
                new TextBox();

            txtPhone =
                new TextBox();

            txtReason =
                new TextBox();

            cboDoctor =
                new ComboBox();

            cboStatus =
                new ComboBox();

            cboFilterStatus =
                new ComboBox();

            dtpAppointment =
                new DateTimePicker();

            dtpFilterDate =
                new DateTimePicker();

            txtSearch =
                new TextBox();

            btnAdd =
                new Button();

            btnUpdate =
                new Button();

            btnDelete =
                new Button();

            btnClear =
                new Button();

            dgvAppointments =
                new DataGridView();

            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)
                dgvAppointments).BeginInit();

            SuspendLayout();

            // Menu

            mnuExportCsv.Text =
                "Export CSV";

            menuStrip1.Items.AddRange(
                new ToolStripItem[]
                {
                    mnuExportCsv
                });

            // Status

            lblTotal.Text =
                "Tổng lịch hẹn: 0";

            statusStrip1.Items.AddRange(
                new ToolStripItem[]
                {
                    lblTotal
                });

            // Layout

            tableLayoutPanel1.Dock =
                DockStyle.Top;

            tableLayoutPanel1.Height = 180;

            tableLayoutPanel1.ColumnCount = 4;

            tableLayoutPanel1.RowCount = 5;

            tableLayoutPanel1.Controls.Add(
                new Label()
                {
                    Text = "Mã lịch hẹn"
                }, 0, 0);

            tableLayoutPanel1.Controls.Add(
                txtAppointmentId, 1, 0);

            tableLayoutPanel1.Controls.Add(
                new Label()
                {
                    Text = "Họ tên"
                }, 2, 0);

            tableLayoutPanel1.Controls.Add(
                txtPatientName, 3, 0);

            tableLayoutPanel1.Controls.Add(
                new Label()
                {
                    Text = "SĐT"
                }, 0, 1);

            tableLayoutPanel1.Controls.Add(
                txtPhone, 1, 1);

            tableLayoutPanel1.Controls.Add(
                new Label()
                {
                    Text = "Ngày hẹn"
                }, 2, 1);

            tableLayoutPanel1.Controls.Add(
                dtpAppointment, 3, 1);

            tableLayoutPanel1.Controls.Add(
                new Label()
                {
                    Text = "Bác sĩ"
                }, 0, 2);

            tableLayoutPanel1.Controls.Add(
                cboDoctor, 1, 2);

            tableLayoutPanel1.Controls.Add(
                new Label()
                {
                    Text = "Trạng thái"
                }, 2, 2);

            tableLayoutPanel1.Controls.Add(
                cboStatus, 3, 2);

            tableLayoutPanel1.Controls.Add(
                new Label()
                {
                    Text = "Lý do"
                }, 0, 3);

            tableLayoutPanel1.Controls.Add(
                txtReason, 1, 3);

            tableLayoutPanel1.SetColumnSpan(
                txtReason, 3);

            // Search

            tableLayoutPanel1.Controls.Add(
                new Label()
                {
                    Text = "Tìm kiếm"
                }, 0, 4);

            tableLayoutPanel1.Controls.Add(
                txtSearch, 1, 4);

            tableLayoutPanel1.Controls.Add(
                cboFilterStatus, 2, 4);

            tableLayoutPanel1.Controls.Add(
                dtpFilterDate, 3, 4);

            // Buttons

            btnAdd.Text = "Thêm";
            btnUpdate.Text = "Cập nhật";
            btnDelete.Text = "Xóa";
            btnClear.Text = "Làm mới";

            btnAdd.Location =
                new Point(20, 190);

            btnUpdate.Location =
                new Point(120, 190);

            btnDelete.Location =
                new Point(240, 190);

            btnClear.Location =
                new Point(340, 190);

            // Grid

            dgvAppointments.Dock =
                DockStyle.Bottom;

            dgvAppointments.Height = 300;

            dgvAppointments.SelectionMode =
                DataGridViewSelectionMode
                .FullRowSelect;

            // Form

            AutoScaleDimensions =
                new SizeF(7F, 15F);

            AutoScaleMode =
                AutoScaleMode.Font;

            ClientSize =
                new Size(1200, 700);

            Controls.Add(
                dgvAppointments);

            Controls.Add(
                btnAdd);

            Controls.Add(
                btnUpdate);

            Controls.Add(
                btnDelete);

            Controls.Add(
                btnClear);

            Controls.Add(
                tableLayoutPanel1);

            Controls.Add(
                statusStrip1);

            Controls.Add(
                menuStrip1);

            MainMenuStrip =
                menuStrip1;

            Text =
                "Clinic Appointment Manager";

            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                dgvAppointments).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}