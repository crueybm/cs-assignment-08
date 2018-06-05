namespace crueybm_Assignment008
{
    partial class frmZeller
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
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.lblChoose = new System.Windows.Forms.Label();
            this.lbCelebrity = new System.Windows.Forms.ListBox();
            this.pbCelebrity = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCelebrity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(12, 9);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(53, 16);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Month:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(12, 34);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(40, 16);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "Day:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Year:";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(12, 103);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(145, 16);
            this.lblRes.TabIndex = 3;
            this.lblRes.Text = "You were born on a:";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(15, 122);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(142, 20);
            this.tbResult.TabIndex = 4;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(90, 61);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(67, 20);
            this.tbYear.TabIndex = 5;
            this.tbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "September",
            "October",
            "November",
            "December"});
            this.cbMonth.Location = new System.Drawing.Point(62, 4);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(95, 21);
            this.cbMonth.TabIndex = 6;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // cbDate
            // 
            this.cbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Location = new System.Drawing.Point(99, 31);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(58, 21);
            this.cbDate.TabIndex = 7;
            this.cbDate.SelectedIndexChanged += new System.EventHandler(this.cbDate_SelectedIndexChanged);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(163, 9);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(135, 16);
            this.lblChoose.TabIndex = 9;
            this.lblChoose.Text = "Select a Celebrity:";
            // 
            // lbCelebrity
            // 
            this.lbCelebrity.FormattingEnabled = true;
            this.lbCelebrity.Location = new System.Drawing.Point(163, 28);
            this.lbCelebrity.Name = "lbCelebrity";
            this.lbCelebrity.Size = new System.Drawing.Size(142, 69);
            this.lbCelebrity.TabIndex = 10;
            this.lbCelebrity.SelectedIndexChanged += new System.EventHandler(this.lbCelebrity_SelectedIndexChanged);
            // 
            // pbCelebrity
            // 
            this.pbCelebrity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCelebrity.Location = new System.Drawing.Point(163, 103);
            this.pbCelebrity.Name = "pbCelebrity";
            this.pbCelebrity.Size = new System.Drawing.Size(142, 134);
            this.pbCelebrity.TabIndex = 11;
            this.pbCelebrity.TabStop = false;
            this.pbCelebrity.SizeModeChanged += new System.EventHandler(this.pbCelebrity_SizeModeChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(15, 214);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(50, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(82, 214);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmZeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 243);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pbCelebrity);
            this.Controls.Add(this.lbCelebrity);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMonth);
            this.Name = "frmZeller";
            this.Text = "Zeller\'s Algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.pbCelebrity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.ListBox lbCelebrity;
        private System.Windows.Forms.PictureBox pbCelebrity;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnReset;
    }
}

