namespace ByPassNSS
{
    partial class Form1
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
            this.txtConect = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConect
            // 
            this.txtConect.Location = new System.Drawing.Point(82, 158);
            this.txtConect.Name = "txtConect";
            this.txtConect.Size = new System.Drawing.Size(93, 23);
            this.txtConect.TabIndex = 0;
            this.txtConect.Text = "RemovePass";
            this.txtConect.UseVisualStyleBackColor = true;
            this.txtConect.Click += new System.EventHandler(this.txtConect_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(216, 158);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(95, 23);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return_Exit";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Disconect LAN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "DisableRoom";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 235);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtConect);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtConect;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

