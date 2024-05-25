namespace Repair_OrgTech.Forms
{
    partial class Operator_Form
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_Feedback = new System.Windows.Forms.Button();
            this.lbl_Back = new System.Windows.Forms.Label();
            this.btn_AddRequest = new System.Windows.Forms.Button();
            this.grid_Request = new System.Windows.Forms.DataGridView();
            this.lbl_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Request)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(78, 192);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 20);
            this.linkLabel1.TabIndex = 32;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // btn_Feedback
            // 
            this.btn_Feedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Feedback.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Feedback.Location = new System.Drawing.Point(12, 114);
            this.btn_Feedback.Name = "btn_Feedback";
            this.btn_Feedback.Size = new System.Drawing.Size(235, 55);
            this.btn_Feedback.TabIndex = 31;
            this.btn_Feedback.Text = "Отзыв";
            this.btn_Feedback.UseMnemonic = false;
            this.btn_Feedback.UseVisualStyleBackColor = true;
            // 
            // lbl_Back
            // 
            this.lbl_Back.AutoSize = true;
            this.lbl_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Back.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Back.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Back.Location = new System.Drawing.Point(1114, 11);
            this.lbl_Back.Name = "lbl_Back";
            this.lbl_Back.Size = new System.Drawing.Size(92, 28);
            this.lbl_Back.TabIndex = 30;
            this.lbl_Back.Text = "<--Назад";
            this.lbl_Back.Click += new System.EventHandler(this.lbl_Back_Click);
            // 
            // btn_AddRequest
            // 
            this.btn_AddRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddRequest.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddRequest.Location = new System.Drawing.Point(12, 53);
            this.btn_AddRequest.Name = "btn_AddRequest";
            this.btn_AddRequest.Size = new System.Drawing.Size(235, 55);
            this.btn_AddRequest.TabIndex = 29;
            this.btn_AddRequest.Text = "Добавить заявку";
            this.btn_AddRequest.UseMnemonic = false;
            this.btn_AddRequest.UseVisualStyleBackColor = true;
            // 
            // grid_Request
            // 
            this.grid_Request.AllowUserToAddRows = false;
            this.grid_Request.AllowUserToDeleteRows = false;
            this.grid_Request.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.grid_Request.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid_Request.BackgroundColor = System.Drawing.Color.White;
            this.grid_Request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Request.Location = new System.Drawing.Point(253, 53);
            this.grid_Request.Name = "grid_Request";
            this.grid_Request.ReadOnly = true;
            this.grid_Request.RowHeadersVisible = false;
            this.grid_Request.RowHeadersWidth = 62;
            this.grid_Request.RowTemplate.Height = 28;
            this.grid_Request.Size = new System.Drawing.Size(953, 621);
            this.grid_Request.TabIndex = 28;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 11);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(434, 39);
            this.lbl_Title.TabIndex = 27;
            this.lbl_Title.Text = "Ремонт оргтехники - Оператор";
            // 
            // Operator_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1218, 684);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_Feedback);
            this.Controls.Add(this.lbl_Back);
            this.Controls.Add(this.btn_AddRequest);
            this.Controls.Add(this.grid_Request);
            this.Controls.Add(this.lbl_Title);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1240, 740);
            this.MinimumSize = new System.Drawing.Size(1240, 740);
            this.Name = "Operator_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ремонт оргтехники";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Request)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_Feedback;
        private System.Windows.Forms.Label lbl_Back;
        private System.Windows.Forms.Button btn_AddRequest;
        private System.Windows.Forms.DataGridView grid_Request;
        private System.Windows.Forms.Label lbl_Title;
    }
}