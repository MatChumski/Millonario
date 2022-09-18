namespace Millonario
{
    partial class Signup
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
            this.pnlSignup = new System.Windows.Forms.Panel();
            this.lblMissingInfo = new System.Windows.Forms.Label();
            this.lblSignupWrongPwd = new System.Windows.Forms.Label();
            this.txtSignupPwd2 = new System.Windows.Forms.TextBox();
            this.txtSignupEmail = new System.Windows.Forms.TextBox();
            this.txtSignupCancel = new System.Windows.Forms.Button();
            this.lblSignupWrongEmail = new System.Windows.Forms.Label();
            this.txtSignupPwd = new System.Windows.Forms.TextBox();
            this.pnlSignupTitle = new System.Windows.Forms.Panel();
            this.lblSignupTitle = new System.Windows.Forms.Label();
            this.txtSignupUser = new System.Windows.Forms.TextBox();
            this.btnSignupSignup = new System.Windows.Forms.Button();
            this.pnlSignup.SuspendLayout();
            this.pnlSignupTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSignup
            // 
            this.pnlSignup.Controls.Add(this.lblMissingInfo);
            this.pnlSignup.Controls.Add(this.lblSignupWrongPwd);
            this.pnlSignup.Controls.Add(this.txtSignupPwd2);
            this.pnlSignup.Controls.Add(this.txtSignupEmail);
            this.pnlSignup.Controls.Add(this.txtSignupCancel);
            this.pnlSignup.Controls.Add(this.lblSignupWrongEmail);
            this.pnlSignup.Controls.Add(this.txtSignupPwd);
            this.pnlSignup.Controls.Add(this.pnlSignupTitle);
            this.pnlSignup.Controls.Add(this.txtSignupUser);
            this.pnlSignup.Controls.Add(this.btnSignupSignup);
            this.pnlSignup.Location = new System.Drawing.Point(15, 12);
            this.pnlSignup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlSignup.Name = "pnlSignup";
            this.pnlSignup.Size = new System.Drawing.Size(905, 490);
            this.pnlSignup.TabIndex = 1;
            // 
            // lblMissingInfo
            // 
            this.lblMissingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMissingInfo.AutoSize = true;
            this.lblMissingInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMissingInfo.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMissingInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMissingInfo.Location = new System.Drawing.Point(344, 420);
            this.lblMissingInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMissingInfo.Name = "lblMissingInfo";
            this.lblMissingInfo.Size = new System.Drawing.Size(221, 16);
            this.lblMissingInfo.TabIndex = 10;
            this.lblMissingInfo.Text = "Por favor complete todos los campos";
            this.lblMissingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSignupWrongPwd
            // 
            this.lblSignupWrongPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSignupWrongPwd.AutoSize = true;
            this.lblSignupWrongPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSignupWrongPwd.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSignupWrongPwd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSignupWrongPwd.Location = new System.Drawing.Point(368, 335);
            this.lblSignupWrongPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignupWrongPwd.Name = "lblSignupWrongPwd";
            this.lblSignupWrongPwd.Size = new System.Drawing.Size(176, 16);
            this.lblSignupWrongPwd.TabIndex = 9;
            this.lblSignupWrongPwd.Text = "Las contraseñas no coinciden";
            this.lblSignupWrongPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSignupPwd2
            // 
            this.txtSignupPwd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSignupPwd2.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSignupPwd2.ForeColor = System.Drawing.Color.LightGray;
            this.txtSignupPwd2.Location = new System.Drawing.Point(250, 296);
            this.txtSignupPwd2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSignupPwd2.Name = "txtSignupPwd2";
            this.txtSignupPwd2.Size = new System.Drawing.Size(408, 36);
            this.txtSignupPwd2.TabIndex = 7;
            this.txtSignupPwd2.Text = "Confirmar Contraseña";
            this.txtSignupPwd2.Enter += new System.EventHandler(this.txtSignupPwd2_Enter);
            this.txtSignupPwd2.Leave += new System.EventHandler(this.txtSignupPwd2_Leave);
            // 
            // txtSignupEmail
            // 
            this.txtSignupEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSignupEmail.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSignupEmail.ForeColor = System.Drawing.Color.LightGray;
            this.txtSignupEmail.Location = new System.Drawing.Point(250, 180);
            this.txtSignupEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSignupEmail.Name = "txtSignupEmail";
            this.txtSignupEmail.Size = new System.Drawing.Size(408, 36);
            this.txtSignupEmail.TabIndex = 6;
            this.txtSignupEmail.Text = "E-Mail";
            this.txtSignupEmail.Enter += new System.EventHandler(this.txtSignupEmail_Enter);
            this.txtSignupEmail.Leave += new System.EventHandler(this.txtSignupEmail_Leave);
            // 
            // txtSignupCancel
            // 
            this.txtSignupCancel.BackColor = System.Drawing.Color.DarkGray;
            this.txtSignupCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtSignupCancel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSignupCancel.Location = new System.Drawing.Point(475, 379);
            this.txtSignupCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSignupCancel.Name = "txtSignupCancel";
            this.txtSignupCancel.Size = new System.Drawing.Size(183, 38);
            this.txtSignupCancel.TabIndex = 5;
            this.txtSignupCancel.Text = "Regresar";
            this.txtSignupCancel.UseVisualStyleBackColor = false;
            this.txtSignupCancel.Click += new System.EventHandler(this.txtSignupCancel_Click);
            // 
            // lblSignupWrongEmail
            // 
            this.lblSignupWrongEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSignupWrongEmail.AutoSize = true;
            this.lblSignupWrongEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSignupWrongEmail.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSignupWrongEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSignupWrongEmail.Location = new System.Drawing.Point(396, 219);
            this.lblSignupWrongEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignupWrongEmail.Name = "lblSignupWrongEmail";
            this.lblSignupWrongEmail.Size = new System.Drawing.Size(117, 16);
            this.lblSignupWrongEmail.TabIndex = 1;
            this.lblSignupWrongEmail.Text = "Dirección no Válida";
            this.lblSignupWrongEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSignupPwd
            // 
            this.txtSignupPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSignupPwd.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSignupPwd.ForeColor = System.Drawing.Color.LightGray;
            this.txtSignupPwd.Location = new System.Drawing.Point(250, 238);
            this.txtSignupPwd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSignupPwd.Name = "txtSignupPwd";
            this.txtSignupPwd.Size = new System.Drawing.Size(408, 36);
            this.txtSignupPwd.TabIndex = 4;
            this.txtSignupPwd.Text = "Contraseña";
            this.txtSignupPwd.Enter += new System.EventHandler(this.txtSignupPwd_Enter);
            this.txtSignupPwd.Leave += new System.EventHandler(this.txtSignupPwd_Leave);
            // 
            // pnlSignupTitle
            // 
            this.pnlSignupTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlSignupTitle.Controls.Add(this.lblSignupTitle);
            this.pnlSignupTitle.Cursor = System.Windows.Forms.Cursors.No;
            this.pnlSignupTitle.Location = new System.Drawing.Point(250, 23);
            this.pnlSignupTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlSignupTitle.Name = "pnlSignupTitle";
            this.pnlSignupTitle.Size = new System.Drawing.Size(408, 70);
            this.pnlSignupTitle.TabIndex = 3;
            // 
            // lblSignupTitle
            // 
            this.lblSignupTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSignupTitle.AutoSize = true;
            this.lblSignupTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSignupTitle.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSignupTitle.Location = new System.Drawing.Point(135, 12);
            this.lblSignupTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignupTitle.Name = "lblSignupTitle";
            this.lblSignupTitle.Size = new System.Drawing.Size(150, 42);
            this.lblSignupTitle.TabIndex = 0;
            this.lblSignupTitle.Text = "Registro";
            this.lblSignupTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSignupUser
            // 
            this.txtSignupUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSignupUser.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSignupUser.ForeColor = System.Drawing.Color.LightGray;
            this.txtSignupUser.Location = new System.Drawing.Point(250, 124);
            this.txtSignupUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSignupUser.Name = "txtSignupUser";
            this.txtSignupUser.Size = new System.Drawing.Size(408, 36);
            this.txtSignupUser.TabIndex = 2;
            this.txtSignupUser.Text = "Usuario";
            this.txtSignupUser.Enter += new System.EventHandler(this.txtSignupUser_Enter);
            this.txtSignupUser.Leave += new System.EventHandler(this.txtSignupUser_Leave);
            // 
            // btnSignupSignup
            // 
            this.btnSignupSignup.BackColor = System.Drawing.Color.DarkGray;
            this.btnSignupSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignupSignup.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignupSignup.Location = new System.Drawing.Point(250, 379);
            this.btnSignupSignup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSignupSignup.Name = "btnSignupSignup";
            this.btnSignupSignup.Size = new System.Drawing.Size(183, 38);
            this.btnSignupSignup.TabIndex = 1;
            this.btnSignupSignup.Text = "Registrarse";
            this.btnSignupSignup.UseVisualStyleBackColor = false;
            this.btnSignupSignup.Click += new System.EventHandler(this.btnSignupSignup_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.pnlSignup);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(949, 558);
            this.MinimumSize = new System.Drawing.Size(949, 558);
            this.Name = "Signup";
            this.Text = "Form2";
            this.pnlSignup.ResumeLayout(false);
            this.pnlSignup.PerformLayout();
            this.pnlSignupTitle.ResumeLayout(false);
            this.pnlSignupTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlSignup;
        private Button txtSignupCancel;
        private Label lblSignupWrongEmail;
        private TextBox txtSignupPwd;
        private Panel pnlSignupTitle;
        private Label lblSignupTitle;
        private TextBox txtSignupUser;
        private Button btnSignupSignup;
        private TextBox txtSignupEmail;
        private Label lblSignupWrongPwd;
        private TextBox txtSignupPwd2;
        private Label lblMissingInfo;
    }
}