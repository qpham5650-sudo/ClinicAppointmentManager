using System.ComponentModel;
using System.Text.RegularExpressions;

namespace ClinicAppointmentManager
{
    public partial class Form1 : Form
    {
        private BindingList<Appointment> appointments =
            new BindingList<Appointment>();

        private BindingSource source =
            new BindingSource();

        private ErrorProvider errorProvider =
            new ErrorProvider();

        public Form1()
        {
            InitializeComponent();

            InitializeData();
            InitializeGrid();
        }

        private void InitializeData()
        {
            source.DataSource = appointments;

            dgvAppointments.DataSource = source;

            cboDoctor.Items.AddRange(
                new string[]
                {
                    "BS Nguyễn Văn A",
                    "BS Trần Văn B",
                    "BS Lê Thị C"
                });

            cboStatus.Items.AddRange(
                new string[]
                {
                    "Chờ khám",
                    "Đang khám",
                    "Hoàn tất",
                    "Đã hủy"
                });

            cboFilterStatus.Items.Add("Tất cả");

            cboFilterStatus.Items.AddRange(
                new string[]
                {
                    "Chờ khám",
                    "Đang khám",
                    "Hoàn tất",
                    "Đã hủy"
                });

            cboFilterStatus.SelectedIndex = 0;

            UpdateStatusBar();
        }

        private void InitializeGrid()
        {
            dgvAppointments.AutoGenerateColumns = false;

            dgvAppointments.Columns.Clear();

            dgvAppointments.Columns.Add(
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Mã",
                    DataPropertyName = "AppointmentId"
                });

            dgvAppointments.Columns.Add(
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Họ tên",
                    DataPropertyName = "PatientName"
                });

            dgvAppointments.Columns.Add(
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "SĐT",
                    DataPropertyName = "PhoneNumber"
                });

            dgvAppointments.Columns.Add(
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Ngày hẹn",
                    DataPropertyName = "AppointmentDate"
                });

            dgvAppointments.Columns.Add(
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Bác sĩ",
                    DataPropertyName = "Doctor"
                });

            dgvAppointments.Columns.Add(
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Trạng thái",
                    DataPropertyName = "Status"
                });

            dgvAppointments.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        private bool ValidateInput()
        {
            errorProvider.Clear();

            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                errorProvider.SetError(
                    txtPatientName,
                    "Tên không được trống");

                valid = false;
            }

            if (!Regex.IsMatch(
                txtPhone.Text,
                @"^0\d{9}$"))
            {
                errorProvider.SetError(
                    txtPhone,
                    "Số điện thoại không hợp lệ");

                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                errorProvider.SetError(
                    txtReason,
                    "Nhập lý do khám");

                valid = false;
            }

            if (dtpAppointment.Value <
                DateTime.Now)
            {
                errorProvider.SetError(
                    dtpAppointment,
                    "Ngày hẹn không hợp lệ");

                valid = false;
            }

            if (appointments.Any(x =>
                    x.AppointmentId ==
                    txtAppointmentId.Text))
            {
                errorProvider.SetError(
                    txtAppointmentId,
                    "Mã lịch hẹn đã tồn tại");

                valid = false;
            }

            return valid;
        }

        private void btnAdd_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidateInput())
                return;

            appointments.Add(
                new Appointment
                {
                    AppointmentId =
                        txtAppointmentId.Text,

                    PatientName =
                        txtPatientName.Text,

                    PhoneNumber =
                        txtPhone.Text,

                    AppointmentDate =
                        dtpAppointment.Value,

                    Doctor =
                        cboDoctor.Text,

                    Reason =
                        txtReason.Text,

                    Status =
                        cboStatus.Text
                });

            UpdateStatusBar();
        }

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            if (source.Current == null)
                return;

            if (MessageBox.Show(
                "Xóa lịch hẹn?",
                "Xác nhận",
                MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                source.RemoveCurrent();
                UpdateStatusBar();
            }
        }

        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            if (source.Current
                is Appointment ap)
            {
                ap.PatientName =
                    txtPatientName.Text;

                ap.PhoneNumber =
                    txtPhone.Text;

                ap.AppointmentDate =
                    dtpAppointment.Value;

                ap.Doctor =
                    cboDoctor.Text;

                ap.Reason =
                    txtReason.Text;

                ap.Status =
                    cboStatus.Text;

                source.ResetBindings(false);

                UpdateStatusBar();
            }
        }

        private void UpdateStatusBar()
        {
            lblTotal.Text =
                $"Tổng lịch hẹn: {source.Count}";
        }
    }
}