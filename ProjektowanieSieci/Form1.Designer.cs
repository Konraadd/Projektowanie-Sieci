namespace ProjektowanieSieci
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
            this.labelV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.textBoxTi = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxAn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Location = new System.Drawing.Point(37, 9);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(74, 13);
            this.labelV.TabIndex = 0;
            this.labelV.Text = "V (pojemność)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ti (dane klas ruchu)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "a (średni ruch podzielony przez pojemność)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "A1:A2:An (proporcje ruchu klas)";
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(40, 36);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(200, 20);
            this.textBoxV.TabIndex = 4;
            this.textBoxV.Text = "50";
            // 
            // textBoxTi
            // 
            this.textBoxTi.Location = new System.Drawing.Point(400, 36);
            this.textBoxTi.Name = "textBoxTi";
            this.textBoxTi.Size = new System.Drawing.Size(200, 20);
            this.textBoxTi.TabIndex = 5;
            this.textBoxTi.Text = "1:5:10";
            this.textBoxTi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(40, 114);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(200, 20);
            this.textBoxA.TabIndex = 6;
            this.textBoxA.Text = "0.5:1.5:0.1";
            // 
            // textBoxAn
            // 
            this.textBoxAn.Location = new System.Drawing.Point(400, 114);
            this.textBoxAn.Name = "textBoxAn";
            this.textBoxAn.Size = new System.Drawing.Size(200, 20);
            this.textBoxAn.TabIndex = 7;
            this.textBoxAn.Text = "1:1:1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAn);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxTi);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.TextBox textBoxTi;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxAn;
        private System.Windows.Forms.Button button1;
    }
}

