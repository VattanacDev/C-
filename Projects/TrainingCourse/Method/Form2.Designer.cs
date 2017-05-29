namespace Method
{
    partial class Form2
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
            this.btnOUt = new System.Windows.Forms.Button();
            this.btnParams = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOUt
            // 
            this.btnOUt.Location = new System.Drawing.Point(63, 103);
            this.btnOUt.Name = "btnOUt";
            this.btnOUt.Size = new System.Drawing.Size(75, 23);
            this.btnOUt.TabIndex = 0;
            this.btnOUt.Text = "OUT";
            this.btnOUt.UseVisualStyleBackColor = true;
            this.btnOUt.Click += new System.EventHandler(this.btnOUt_Click);
            // 
            // btnParams
            // 
            this.btnParams.Location = new System.Drawing.Point(157, 103);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(75, 23);
            this.btnParams.TabIndex = 1;
            this.btnParams.Text = "Parame";
            this.btnParams.UseVisualStyleBackColor = true;
            this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(157, 147);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(75, 23);
            this.btnRef.TabIndex = 2;
            this.btnRef.Text = "Ref";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Default";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Default_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Recursive";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Recursive_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(157, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Contructor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Contructor_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnParams);
            this.Controls.Add(this.btnOUt);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOUt;
        private System.Windows.Forms.Button btnParams;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

    }
}