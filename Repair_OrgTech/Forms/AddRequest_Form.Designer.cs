namespace Repair_OrgTech.Forms
{
    partial class AddRequest_Form
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
            this.box_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.box_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.box_CompDate = new System.Windows.Forms.DateTimePicker();
            this.box_Model = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.box_Problem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.box_Status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.box_Parts = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.box_Master = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.box_Client = new System.Windows.Forms.ComboBox();
            this.btn_AddRequest = new System.Windows.Forms.Button();
            this.lbl_Back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(275, 39);
            this.lbl_Title.TabIndex = 28;
            this.lbl_Title.Text = "Добавление заявки";
            // 
            // box_Type
            // 
            this.box_Type.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Type.FormattingEnabled = true;
            this.box_Type.Location = new System.Drawing.Point(19, 92);
            this.box_Type.Name = "box_Type";
            this.box_Type.Size = new System.Drawing.Size(268, 41);
            this.box_Type.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = "Тип";
            // 
            // box_StartDate
            // 
            this.box_StartDate.CalendarFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_StartDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.box_StartDate.Location = new System.Drawing.Point(19, 180);
            this.box_StartDate.Name = "box_StartDate";
            this.box_StartDate.Size = new System.Drawing.Size(268, 41);
            this.box_StartDate.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 28);
            this.label2.TabIndex = 32;
            this.label2.Text = "Прием заявки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "Завершение заявки";
            // 
            // box_CompDate
            // 
            this.box_CompDate.CalendarFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_CompDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_CompDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.box_CompDate.Location = new System.Drawing.Point(19, 272);
            this.box_CompDate.Name = "box_CompDate";
            this.box_CompDate.Size = new System.Drawing.Size(268, 41);
            this.box_CompDate.TabIndex = 33;
            // 
            // box_Model
            // 
            this.box_Model.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Model.Location = new System.Drawing.Point(305, 92);
            this.box_Model.Name = "box_Model";
            this.box_Model.Size = new System.Drawing.Size(685, 41);
            this.box_Model.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(300, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 28);
            this.label4.TabIndex = 36;
            this.label4.Text = "Модель устройства";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(300, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 28);
            this.label5.TabIndex = 38;
            this.label5.Text = "Описание проблемы";
            // 
            // box_Problem
            // 
            this.box_Problem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Problem.Location = new System.Drawing.Point(305, 180);
            this.box_Problem.Multiline = true;
            this.box_Problem.Name = "box_Problem";
            this.box_Problem.Size = new System.Drawing.Size(685, 133);
            this.box_Problem.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 28);
            this.label6.TabIndex = 40;
            this.label6.Text = "Статус";
            // 
            // box_Status
            // 
            this.box_Status.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Status.FormattingEnabled = true;
            this.box_Status.Location = new System.Drawing.Point(19, 361);
            this.box_Status.Name = "box_Status";
            this.box_Status.Size = new System.Drawing.Size(268, 41);
            this.box_Status.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(300, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 28);
            this.label7.TabIndex = 42;
            this.label7.Text = "Запчасти";
            // 
            // box_Parts
            // 
            this.box_Parts.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Parts.Location = new System.Drawing.Point(305, 361);
            this.box_Parts.Name = "box_Parts";
            this.box_Parts.Size = new System.Drawing.Size(685, 41);
            this.box_Parts.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(14, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 28);
            this.label8.TabIndex = 44;
            this.label8.Text = "Мастер";
            // 
            // box_Master
            // 
            this.box_Master.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Master.FormattingEnabled = true;
            this.box_Master.Location = new System.Drawing.Point(19, 456);
            this.box_Master.Name = "box_Master";
            this.box_Master.Size = new System.Drawing.Size(455, 41);
            this.box_Master.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(514, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 28);
            this.label9.TabIndex = 46;
            this.label9.Text = "Заказчик";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // box_Client
            // 
            this.box_Client.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Client.FormattingEnabled = true;
            this.box_Client.Location = new System.Drawing.Point(519, 456);
            this.box_Client.Name = "box_Client";
            this.box_Client.Size = new System.Drawing.Size(455, 41);
            this.box_Client.TabIndex = 45;
            // 
            // btn_AddRequest
            // 
            this.btn_AddRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddRequest.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddRequest.Location = new System.Drawing.Point(739, 564);
            this.btn_AddRequest.Name = "btn_AddRequest";
            this.btn_AddRequest.Size = new System.Drawing.Size(235, 55);
            this.btn_AddRequest.TabIndex = 47;
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
            this.lbl_Back.Location = new System.Drawing.Point(898, 9);
            this.lbl_Back.Name = "lbl_Back";
            this.lbl_Back.Size = new System.Drawing.Size(92, 28);
            this.lbl_Back.TabIndex = 48;
            this.lbl_Back.Text = "<--Назад";
            this.lbl_Back.Click += new System.EventHandler(this.lbl_Back_Click);
            // 
            // AddRequest_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 664);
            this.Controls.Add(this.lbl_Back);
            this.Controls.Add(this.btn_AddRequest);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.box_Client);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.box_Master);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.box_Parts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_Status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.box_Problem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_Model);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box_CompDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_StartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_Type);
            this.Controls.Add(this.lbl_Title);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "AddRequest_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить заявку";
            this.Load += new System.EventHandler(this.AddRequest_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ComboBox box_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker box_StartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker box_CompDate;
        private System.Windows.Forms.TextBox box_Model;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox box_Problem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox box_Status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox box_Parts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox box_Master;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox box_Client;
        private System.Windows.Forms.Button btn_AddRequest;
        private System.Windows.Forms.Label lbl_Back;
    }
}