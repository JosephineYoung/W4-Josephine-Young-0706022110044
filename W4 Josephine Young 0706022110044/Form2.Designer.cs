namespace W4_Josephine_Young_0706022110044
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxNama2 = new System.Windows.Forms.TextBox();
            this.tBoxAlamat2 = new System.Windows.Forms.TextBox();
            this.tBoxTelp2 = new System.Windows.Forms.TextBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnPrevData = new System.Windows.Forms.Button();
            this.btnNextData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alamat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telp:";
            // 
            // tBoxNama2
            // 
            this.tBoxNama2.Location = new System.Drawing.Point(101, 32);
            this.tBoxNama2.Name = "tBoxNama2";
            this.tBoxNama2.Size = new System.Drawing.Size(348, 27);
            this.tBoxNama2.TabIndex = 3;
            // 
            // tBoxAlamat2
            // 
            this.tBoxAlamat2.Location = new System.Drawing.Point(101, 69);
            this.tBoxAlamat2.Name = "tBoxAlamat2";
            this.tBoxAlamat2.Size = new System.Drawing.Size(472, 27);
            this.tBoxAlamat2.TabIndex = 4;
            // 
            // tBoxTelp2
            // 
            this.tBoxTelp2.Location = new System.Drawing.Point(101, 106);
            this.tBoxTelp2.Name = "tBoxTelp2";
            this.tBoxTelp2.Size = new System.Drawing.Size(259, 27);
            this.tBoxTelp2.TabIndex = 5;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(32, 158);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(94, 29);
            this.btnKembali.TabIndex = 6;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnPrevData
            // 
            this.btnPrevData.Location = new System.Drawing.Point(159, 158);
            this.btnPrevData.Name = "btnPrevData";
            this.btnPrevData.Size = new System.Drawing.Size(94, 29);
            this.btnPrevData.TabIndex = 7;
            this.btnPrevData.Text = "Prev Data";
            this.btnPrevData.UseVisualStyleBackColor = true;
            this.btnPrevData.Click += new System.EventHandler(this.btnPrevData_Click);
            // 
            // btnNextData
            // 
            this.btnNextData.Location = new System.Drawing.Point(283, 158);
            this.btnNextData.Name = "btnNextData";
            this.btnNextData.Size = new System.Drawing.Size(94, 29);
            this.btnNextData.TabIndex = 8;
            this.btnNextData.Text = "Next Data";
            this.btnNextData.UseVisualStyleBackColor = true;
            this.btnNextData.Click += new System.EventHandler(this.btnNextData_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 281);
            this.Controls.Add(this.btnNextData);
            this.Controls.Add(this.btnPrevData);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.tBoxTelp2);
            this.Controls.Add(this.tBoxAlamat2);
            this.Controls.Add(this.tBoxNama2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form Tampilan Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxNama2;
        private System.Windows.Forms.TextBox tBoxAlamat2;
        private System.Windows.Forms.TextBox tBoxTelp2;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnPrevData;
        private System.Windows.Forms.Button btnNextData;
    }
}