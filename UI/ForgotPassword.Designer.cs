namespace prj_CuoiKyXDHTTT.UI
{
    partial class ForgotPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.txtHint = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLoginpage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.TabIndex = 2;
            this.label2.Text = "Hint";
            //
            // txtUid
            // 
            this.txtUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUid.Location = new System.Drawing.Point(414, 93);
            this.txtUid.Margin = new System.Windows.Forms.Padding(6);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(303, 38);
            this.txtUid.TabIndex = 7;
            //
            // txtHint
            // 
            this.txtHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHint.Location = new System.Drawing.Point(414, 173);
            this.txtHint.Margin = new System.Windows.Forms.Padding(6);
            this.txtHint.Name = "txtHint";
            this.txtHint.Size = new System.Drawing.Size(303, 38);
            this.txtHint.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(342, 266);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(191, 57);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtpass
            // 
            this.txtpass.AutoSize = true;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(464, 371);
            this.txtpass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(117, 31);
            this.txtpass.TabIndex = 11;
            this.txtpass.Text = "_ _ _ _ _";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 371);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Your password is:";
            // 
            // lblLoginpage
            // 
            this.lblLoginpage.AutoSize = true;
            this.lblLoginpage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoginpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginpage.Location = new System.Drawing.Point(708, 456);
            this.lblLoginpage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLoginpage.Name = "lblLoginpage";
            this.lblLoginpage.Size = new System.Drawing.Size(143, 31);
            this.lblLoginpage.TabIndex = 12;
            this.lblLoginpage.Text = "LoginPage";
            this.lblLoginpage.Click += new System.EventHandler(this.lblLoginpage_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 531);
            this.Controls.Add(this.lblLoginpage);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtHint);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.TextBox txtHint;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label txtpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLoginpage;
    }
}