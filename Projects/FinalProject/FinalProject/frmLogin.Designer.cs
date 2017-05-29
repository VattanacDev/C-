namespace FinalProject
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPassWord = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblShow_or_Hide = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.Depth = 0;
            this.txtUserName.ForeColor = System.Drawing.Color.Transparent;
            this.txtUserName.Hint = "User Name";
            this.txtUserName.Location = new System.Drawing.Point(245, 220);
            this.txtUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.Size = new System.Drawing.Size(279, 23);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.UseSystemPasswordChar = false;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassWord.Depth = 0;
            this.txtPassWord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPassWord.Hint = "PassWord";
            this.txtPassWord.Location = new System.Drawing.Point(245, 284);
            this.txtPassWord.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '\0';
            this.txtPassWord.SelectedText = "";
            this.txtPassWord.SelectionLength = 0;
            this.txtPassWord.SelectionStart = 0;
            this.txtPassWord.Size = new System.Drawing.Size(279, 23);
            this.txtPassWord.TabIndex = 1;
            this.txtPassWord.Tag = "";
            this.txtPassWord.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblShow_or_Hide);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPassWord);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 536);
            this.panel1.TabIndex = 4;
            // 
            // lblShow_or_Hide
            // 
            this.lblShow_or_Hide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShow_or_Hide.Image = ((System.Drawing.Image)(resources.GetObject("lblShow_or_Hide.Image")));
            this.lblShow_or_Hide.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblShow_or_Hide.Location = new System.Drawing.Point(488, 278);
            this.lblShow_or_Hide.Name = "lblShow_or_Hide";
            this.lblShow_or_Hide.Size = new System.Drawing.Size(47, 25);
            this.lblShow_or_Hide.TabIndex = 8;
            this.lblShow_or_Hide.Text = " ";
            this.toolTip1.SetToolTip(this.lblShow_or_Hide, "Show or Hide Password");
            this.lblShow_or_Hide.Click += new System.EventHandler(this.lblSHoorHide_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Image = global::FinalProject.Properties.Resources.Lock_20px;
            this.label4.Location = new System.Drawing.Point(203, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = " ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Image = global::FinalProject.Properties.Resources.User_20pxko;
            this.label3.Location = new System.Drawing.Point(204, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = " ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(323, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 110);
            this.label1.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(273, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(212, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Calcel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogin.Location = new System.Drawing.Point(273, 351);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(212, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 536);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtUserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassWord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblShow_or_Hide;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}