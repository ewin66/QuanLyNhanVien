﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyDaiHocGiaDinh.Model;
using QuanLyDaiHocGiaDinh.Services;

namespace QuanLyDaiHocGiaDinh.Views
{
    public partial class AdminUpdateDepartment : DevExpress.XtraEditors.XtraForm
    {
        private Department _department;
        private DepartmentServices departmentServices = new DepartmentServices();
        public AdminUpdateDepartment(Department department)
        {
            InitializeComponent();
            this._department = department;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Department dep = new Department();
            dep = _department;
            dep.DepartmentName = txtPhongBan.Text;
            departmentServices.updateDepartment(dep);
            XtraMessageBox.Show("Sửa thành công !!!");
            this.Close();
        }
        public void updateDepartment(String departmentName)
        {
            txtPhongBan.Text = departmentName;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}