using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3var15task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnOK.Click += BtnOK_Click;
            btnClose.Click += BtnClose_Click;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string birthYearText = txtBirthYear.Text;
            string group = txtGroup.Text;
            string courseText = txtCourse.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) ||
                string.IsNullOrEmpty(birthYearText) || string.IsNullOrEmpty(group) ||
                string.IsNullOrEmpty(courseText))
            {
                MessageBox.Show("Будь ласка, введіть всі дані", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(birthYearText, out int birthYear) || !int.TryParse(courseText, out int course))
            {
                MessageBox.Show("Некоректно введені дані для року народження або курсу", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string gender = MenButton.Checked ? "Чоловік" : "Жінка";
            DateTime birthDate = new DateTime(birthYear, (int)MonthUpDown.Value, (int)DayUpDown.Value);

            string studentInfo = $"Ім'я: {name}\r\nПрізвище: {surname}\r\nДата народження: {birthDate.ToShortDateString()}\r\nСтать: {gender}\r\nГрупа: {group}\r\nКурс: {course}";
            txtOutput.Text = studentInfo;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
