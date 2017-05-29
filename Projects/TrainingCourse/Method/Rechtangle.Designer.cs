namespace Method
{
    partial class Rechtangle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.rdPtey = new System.Windows.Forms.RadioButton();
            this.rdPakrimart = new System.Windows.Forms.RadioButton();
            this.btnCalcu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "បណ្តោយ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "ទទឹង";
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Khmer OS Battambang", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(80, 65);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(223, 45);
            this.txtWidth.TabIndex = 2;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Khmer OS Battambang", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(80, 148);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(223, 45);
            this.txtHeight.TabIndex = 3;
            // 
            // rdPtey
            // 
            this.rdPtey.AutoSize = true;
            this.rdPtey.Font = new System.Drawing.Font("Khmer OS Battambang", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPtey.Location = new System.Drawing.Point(391, 55);
            this.rdPtey.Name = "rdPtey";
            this.rdPtey.Size = new System.Drawing.Size(164, 40);
            this.rdPtey.TabIndex = 4;
            this.rdPtey.TabStop = true;
            this.rdPtey.Text = "គណនាក្រលាផ្ទៃ";
            this.rdPtey.UseVisualStyleBackColor = true;
            this.rdPtey.MouseLeave += new System.EventHandler(this.rdPtey_MouseLeave);
            // 
            // rdPakrimart
            // 
            this.rdPakrimart.AutoSize = true;
            this.rdPakrimart.Font = new System.Drawing.Font("Khmer OS Battambang", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPakrimart.Location = new System.Drawing.Point(393, 139);
            this.rdPakrimart.Name = "rdPakrimart";
            this.rdPakrimart.Size = new System.Drawing.Size(157, 40);
            this.rdPakrimart.TabIndex = 5;
            this.rdPakrimart.TabStop = true;
            this.rdPakrimart.Text = "គណនាបរិមាត្រ";
            this.rdPakrimart.UseVisualStyleBackColor = true;
            this.rdPakrimart.MouseLeave += new System.EventHandler(this.rdPtey_MouseLeave);
            // 
            // btnCalcu
            // 
            this.btnCalcu.Font = new System.Drawing.Font("Khmer OS Battambang", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcu.Location = new System.Drawing.Point(614, 86);
            this.btnCalcu.Name = "btnCalcu";
            this.btnCalcu.Size = new System.Drawing.Size(99, 42);
            this.btnCalcu.TabIndex = 6;
            this.btnCalcu.Text = "គណនា";
            this.btnCalcu.UseVisualStyleBackColor = true;
            this.btnCalcu.Click += new System.EventHandler(this.btnCalcu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "ចម្លើយ";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResult.Font = new System.Drawing.Font("Khmer OS Battambang", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(451, 203);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(150, 39);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "     ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Rechtangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 282);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcu);
            this.Controls.Add(this.rdPakrimart);
            this.Controls.Add(this.rdPtey);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Rechtangle";
            this.Text = "Rechtangle";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.RadioButton rdPtey;
        private System.Windows.Forms.RadioButton rdPakrimart;
        private System.Windows.Forms.Button btnCalcu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}