namespace Repair_OrgTech.Forms
{
    partial class AddRoleUser_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AddRole = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.box_Role = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_Surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_RoleSelect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.box_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.box_Lastname = new System.Windows.Forms.TextBox();
            this.box_Phone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.box_Login = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.box_Password = new System.Windows.Forms.TextBox();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.lbl_Back = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(257, 39);
            this.lbl_Title.TabIndex = 29;
            this.lbl_Title.Text = "Добавление роли";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 39);
            this.label1.TabIndex = 30;
            this.label1.Text = "Добавление пользователя";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_AddRole);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.box_Role);
            this.panel1.Location = new System.Drawing.Point(19, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 640);
            this.panel1.TabIndex = 31;
            // 
            // btn_AddRole
            // 
            this.btn_AddRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddRole.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddRole.Location = new System.Drawing.Point(62, 344);
            this.btn_AddRole.Name = "btn_AddRole";
            this.btn_AddRole.Size = new System.Drawing.Size(235, 55);
            this.btn_AddRole.TabIndex = 48;
            this.btn_AddRole.Text = "Добавить роль";
            this.btn_AddRole.UseMnemonic = false;
            this.btn_AddRole.UseVisualStyleBackColor = true;
            this.btn_AddRole.Click += new System.EventHandler(this.btn_AddRole_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 28);
            this.label4.TabIndex = 38;
            this.label4.Text = "Название роли";
            // 
            // box_Role
            // 
            this.box_Role.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Role.Location = new System.Drawing.Point(8, 270);
            this.box_Role.Name = "box_Role";
            this.box_Role.Size = new System.Drawing.Size(338, 41);
            this.box_Role.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(388, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 40;
            this.label2.Text = "Фамилия";
            // 
            // box_Surname
            // 
            this.box_Surname.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Surname.Location = new System.Drawing.Point(393, 179);
            this.box_Surname.Name = "box_Surname";
            this.box_Surname.Size = new System.Drawing.Size(318, 41);
            this.box_Surname.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(386, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 28);
            this.label3.TabIndex = 38;
            this.label3.Text = "Роль в системе";
            // 
            // box_RoleSelect
            // 
            this.box_RoleSelect.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_RoleSelect.FormattingEnabled = true;
            this.box_RoleSelect.Location = new System.Drawing.Point(391, 90);
            this.box_RoleSelect.Name = "box_RoleSelect";
            this.box_RoleSelect.Size = new System.Drawing.Size(268, 41);
            this.box_RoleSelect.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(388, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 28);
            this.label5.TabIndex = 42;
            this.label5.Text = "Имя";
            // 
            // box_Name
            // 
            this.box_Name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Name.Location = new System.Drawing.Point(393, 265);
            this.box_Name.Name = "box_Name";
            this.box_Name.Size = new System.Drawing.Size(318, 41);
            this.box_Name.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(386, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 28);
            this.label6.TabIndex = 44;
            this.label6.Text = "Отчество";
            // 
            // box_Lastname
            // 
            this.box_Lastname.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Lastname.Location = new System.Drawing.Point(391, 356);
            this.box_Lastname.Name = "box_Lastname";
            this.box_Lastname.Size = new System.Drawing.Size(318, 41);
            this.box_Lastname.TabIndex = 43;
            // 
            // box_Phone
            // 
            this.box_Phone.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Phone.Location = new System.Drawing.Point(393, 442);
            this.box_Phone.Mask = "+7(999) 000-0000";
            this.box_Phone.Name = "box_Phone";
            this.box_Phone.Size = new System.Drawing.Size(238, 41);
            this.box_Phone.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(388, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 28);
            this.label7.TabIndex = 46;
            this.label7.Text = "Телефон";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(727, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 28);
            this.label8.TabIndex = 48;
            this.label8.Text = "Логин";
            // 
            // box_Login
            // 
            this.box_Login.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Login.Location = new System.Drawing.Point(732, 179);
            this.box_Login.Name = "box_Login";
            this.box_Login.Size = new System.Drawing.Size(258, 41);
            this.box_Login.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(727, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 28);
            this.label9.TabIndex = 50;
            this.label9.Text = "Пароль";
            // 
            // box_Password
            // 
            this.box_Password.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Password.Location = new System.Drawing.Point(732, 265);
            this.box_Password.Name = "box_Password";
            this.box_Password.Size = new System.Drawing.Size(258, 41);
            this.box_Password.TabIndex = 49;
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddUser.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddUser.Location = new System.Drawing.Point(643, 597);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(347, 55);
            this.btn_AddUser.TabIndex = 49;
            this.btn_AddUser.Text = "Добавить пользователя";
            this.btn_AddUser.UseMnemonic = false;
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // lbl_Back
            // 
            this.lbl_Back.AutoSize = true;
            this.lbl_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Back.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Back.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Back.Location = new System.Drawing.Point(898, 9);
            this.lbl_Back.Name = "lbl_Back";
            this.lbl_Back.Size = new System.Drawing.Size(92, 28);
            this.lbl_Back.TabIndex = 51;
            this.lbl_Back.Text = "<--Назад";
            this.lbl_Back.Click += new System.EventHandler(this.lbl_Back_Click);
            // 
            // AddRoleUser_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 664);
            this.Controls.Add(this.lbl_Back);
            this.Controls.Add(this.btn_AddUser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.box_Password);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.box_Login);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.box_Phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_Lastname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.box_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_Surname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box_RoleSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "AddRoleUser_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление роли или пользователя";
            this.Load += new System.EventHandler(this.AddRoleUser_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox box_Role;
        private System.Windows.Forms.Button btn_AddRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_Surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox box_RoleSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox box_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox box_Lastname;
        private System.Windows.Forms.MaskedTextBox box_Phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox box_Login;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox box_Password;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.Label lbl_Back;
    }
}