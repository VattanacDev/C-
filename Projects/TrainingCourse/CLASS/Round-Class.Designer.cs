namespace CLASS
{
    partial class Round_Class
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioS = new System.Windows.Forms.RadioButton();
            this.radioP = new System.Windows.Forms.RadioButton();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(105, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "បញ្ចូលតំលៃR";
            // 
            // radioS
            // 
            this.radioS.AutoSize = true;
            this.radioS.Location = new System.Drawing.Point(55, 57);
            this.radioS.Name = "radioS";
            this.radioS.Size = new System.Drawing.Size(32, 17);
            this.radioS.TabIndex = 2;
            this.radioS.TabStop = true;
            this.radioS.Text = "S";
            this.radioS.UseVisualStyleBackColor = true;
            this.radioS.Click += new System.EventHandler(this.radioS_Click);
            // 
            // radioP
            // 
            this.radioP.AutoSize = true;
            this.radioP.Location = new System.Drawing.Point(55, 95);
            this.radioP.Name = "radioP";
            this.radioP.Size = new System.Drawing.Size(32, 17);
            this.radioP.TabIndex = 3;
            this.radioP.TabStop = true;
            this.radioP.Text = "P";
            this.radioP.UseVisualStyleBackColor = true;
            // 
            // lblShow
            // 
            this.lblShow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.Location = new System.Drawing.Point(67, 226);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(158, 30);
            this.lblShow.TabIndex = 5;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(25, 150);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(227, 30);
            this.btnCal.TabIndex = 6;
            this.btnCal.Text = "HoverMe";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            this.btnCal.MouseLeave += new System.EventHandler(this.btnCal_MouseLeave);
            this.btnCal.MouseHover += new System.EventHandler(this.btnCal_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "ចម្លើយ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "just Hover to show the answer";
            // 
            // Round_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 288);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.radioP);
            this.Controls.Add(this.radioS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Name = "Round_Class";
            this.Text = "Round_Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioS;
        private System.Windows.Forms.RadioButton radioP;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}