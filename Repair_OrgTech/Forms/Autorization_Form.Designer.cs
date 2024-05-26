namespace Repair_OrgTech
{
    partial class Autorization_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Title = new System.Windows.Forms.Label();
            this.box_Login = new System.Windows.Forms.TextBox();
            this.box_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.check_Password = new System.Windows.Forms.CheckBox();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.lbl_LogIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Title.Location = new System.Drawing.Point(254, 118);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(190, 39);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Авторизация";
            // 
            // box_Login
            // 
            this.box_Login.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Login.Location = new System.Drawing.Point(181, 292);
            this.box_Login.Name = "box_Login";
            this.box_Login.Size = new System.Drawing.Size(337, 41);
            this.box_Login.TabIndex = 1;
            // 
            // box_Password
            // 
            this.box_Password.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Password.Location = new System.Drawing.Point(181, 375);
            this.box_Password.Name = "box_Password";
            this.box_Password.Size = new System.Drawing.Size(337, 41);
            this.box_Password.TabIndex = 2;
            this.box_Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(187, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(187, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // check_Password
            // 
            this.check_Password.AutoSize = true;
            this.check_Password.Checked = true;
            this.check_Password.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_Password.Location = new System.Drawing.Point(536, 389);
            this.check_Password.Name = "check_Password";
            this.check_Password.Size = new System.Drawing.Size(22, 21);
            this.check_Password.TabIndex = 5;
            this.check_Password.UseVisualStyleBackColor = true;
            this.check_Password.CheckedChanged += new System.EventHandler(this.check_Password_CheckedChanged);
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SignIn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SignIn.Location = new System.Drawing.Point(232, 440);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(235, 58);
            this.btn_SignIn.TabIndex = 6;
            this.btn_SignIn.Text = "Войти";
            this.btn_SignIn.UseMnemonic = false;
            this.btn_SignIn.UseVisualStyleBackColor = true;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // lbl_LogIn
            // 
            this.lbl_LogIn.AutoSize = true;
            this.lbl_LogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_LogIn.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_LogIn.ForeColor = System.Drawing.Color.Blue;
            this.lbl_LogIn.Location = new System.Drawing.Point(267, 515);
            this.lbl_LogIn.Name = "lbl_LogIn";
            this.lbl_LogIn.Size = new System.Drawing.Size(164, 28);
            this.lbl_LogIn.TabIndex = 7;
            this.lbl_LogIn.Text = "Оставить заявку";
            this.lbl_LogIn.Click += new System.EventHandler(this.lbl_LogIn_Click);
            // 
            // Autorization_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 664);
            this.Controls.Add(this.lbl_LogIn);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.check_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_Password);
            this.Controls.Add(this.box_Login);
            this.Controls.Add(this.lbl_Title);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(720, 720);
            this.Name = "Autorization_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox box_Login;
        private System.Windows.Forms.TextBox box_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check_Password;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Label lbl_LogIn;
    }
}

