﻿namespace QuanLyDaiHocGiaDinh.Views
{
    partial class AdminCreateDepartment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtPhongBan = new DevExpress.XtraEditors.TextEdit();
            this.lblPhongBan = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhongBan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(337, 201);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(94, 29);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Cancel";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(126, 201);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "OK";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtPhongBan
            // 
            this.txtPhongBan.Location = new System.Drawing.Point(216, 110);
            this.txtPhongBan.Name = "txtPhongBan";
            this.txtPhongBan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPhongBan.Properties.Appearance.Options.UseFont = true;
            this.txtPhongBan.Size = new System.Drawing.Size(192, 28);
            this.txtPhongBan.TabIndex = 7;
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblPhongBan.Appearance.Options.UseFont = true;
            this.lblPhongBan.Location = new System.Drawing.Point(115, 113);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(83, 21);
            this.lblPhongBan.TabIndex = 6;
            this.lblPhongBan.Text = "Phòng ban:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(199, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(195, 28);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Thêm phòng ban";
            // 
            // AdminCreateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 265);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtPhongBan);
            this.Controls.Add(this.lblPhongBan);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminCreateDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminCreateDepartment";
            ((System.ComponentModel.ISupportInitialize)(this.txtPhongBan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.TextEdit txtPhongBan;
        private DevExpress.XtraEditors.LabelControl lblPhongBan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}