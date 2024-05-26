namespace Repair_OrgTech.Forms
{
    partial class Manager_Form
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.grid_Request = new System.Windows.Forms.DataGridView();
            this.btn_AddRequest = new System.Windows.Forms.Button();
            this.lbl_Back = new System.Windows.Forms.Label();
            this.btn_Feedback = new System.Windows.Forms.Button();
            this.btn_AddRoleUser = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.lbl_Count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Request)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(441, 39);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Ремонт оргтехники - Менеджер";
            // 
            // grid_Request
            // 
            this.grid_Request.AllowUserToAddRows = false;
            this.grid_Request.AllowUserToDeleteRows = false;
            this.grid_Request.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.grid_Request.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid_Request.BackgroundColor = System.Drawing.Color.White;
            this.grid_Request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Request.Location = new System.Drawing.Point(253, 51);
            this.grid_Request.Name = "grid_Request";
            this.grid_Request.ReadOnly = true;
            this.grid_Request.RowHeadersVisible = false;
            this.grid_Request.RowHeadersWidth = 62;
            this.grid_Request.RowTemplate.Height = 28;
            this.grid_Request.Size = new System.Drawing.Size(953, 621);
            this.grid_Request.TabIndex = 2;
            // 
            // btn_AddRequest
            // 
            this.btn_AddRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddRequest.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddRequest.Location = new System.Drawing.Point(12, 51);
            this.btn_AddRequest.Name = "btn_AddRequest";
            this.btn_AddRequest.Size = new System.Drawing.Size(235, 55);
            this.btn_AddRequest.TabIndex = 7;
            this.btn_AddRequest.Text = "Добавить заявку";
            this.btn_AddRequest.UseMnemonic = false;
            this.btn_AddRequest.UseVisualStyleBackColor = true;
            this.btn_AddRequest.Click += new System.EventHandler(this.btn_AddRequest_Click);
            // 
            // lbl_Back
            // 
            this.lbl_Back.AutoSize = true;
            this.lbl_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Back.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Back.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Back.Location = new System.Drawing.Point(1114, 9);
            this.lbl_Back.Name = "lbl_Back";
            this.lbl_Back.Size = new System.Drawing.Size(92, 28);
            this.lbl_Back.TabIndex = 8;
            this.lbl_Back.Text = "<--Назад";
            this.lbl_Back.Click += new System.EventHandler(this.lbl_Back_Click);
            // 
            // btn_Feedback
            // 
            this.btn_Feedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Feedback.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Feedback.Location = new System.Drawing.Point(12, 270);
            this.btn_Feedback.Name = "btn_Feedback";
            this.btn_Feedback.Size = new System.Drawing.Size(235, 55);
            this.btn_Feedback.TabIndex = 11;
            this.btn_Feedback.Text = "Отзыв";
            this.btn_Feedback.UseMnemonic = false;
            this.btn_Feedback.UseVisualStyleBackColor = true;
            // 
            // btn_AddRoleUser
            // 
            this.btn_AddRoleUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddRoleUser.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddRoleUser.Location = new System.Drawing.Point(12, 112);
            this.btn_AddRoleUser.Name = "btn_AddRoleUser";
            this.btn_AddRoleUser.Size = new System.Drawing.Size(235, 91);
            this.btn_AddRoleUser.TabIndex = 9;
            this.btn_AddRoleUser.Text = "Добавить роль или пользователя";
            this.btn_AddRoleUser.UseMnemonic = false;
            this.btn_AddRoleUser.UseVisualStyleBackColor = true;
            // 
            // btn_Report
            // 
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Report.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Report.Location = new System.Drawing.Point(12, 209);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(235, 55);
            this.btn_Report.TabIndex = 10;
            this.btn_Report.Text = "Отчет";
            this.btn_Report.UseMnemonic = false;
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Count.Location = new System.Drawing.Point(12, 633);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(115, 39);
            this.lbl_Count.TabIndex = 12;
            this.lbl_Count.Text = "Заявок:";
            // 
            // Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1218, 684);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.btn_Feedback);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_AddRoleUser);
            this.Controls.Add(this.lbl_Back);
            this.Controls.Add(this.btn_AddRequest);
            this.Controls.Add(this.grid_Request);
            this.Controls.Add(this.lbl_Title);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1240, 740);
            this.MinimumSize = new System.Drawing.Size(1240, 740);
            this.Name = "Manager_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ремонт оргтехники";
            this.Load += new System.EventHandler(this.Manager_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Request)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DataGridView grid_Request;
        private System.Windows.Forms.Button btn_AddRequest;
        private System.Windows.Forms.Label lbl_Back;
        private System.Windows.Forms.Button btn_Feedback;
        private System.Windows.Forms.Button btn_AddRoleUser;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Label lbl_Count;
    }
}