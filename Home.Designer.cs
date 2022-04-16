
namespace RSA1710900
{
    partial class Home
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
            this.btRSA = new System.Windows.Forms.Button();
            this.btVigener = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btthanhvien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRSA
            // 
            this.btRSA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRSA.Location = new System.Drawing.Point(81, 373);
            this.btRSA.Name = "btRSA";
            this.btRSA.Size = new System.Drawing.Size(150, 56);
            this.btRSA.TabIndex = 2;
            this.btRSA.Text = "THUẬT TOÁN RSA";
            this.btRSA.Click += new System.EventHandler(this.btRSA_Click);
            // 
            // btVigener
            // 
            this.btVigener.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVigener.Location = new System.Drawing.Point(596, 370);
            this.btVigener.Name = "btVigener";
            this.btVigener.Size = new System.Drawing.Size(169, 62);
            this.btVigener.TabIndex = 1;
            this.btVigener.Text = "THUẬT TOÁN Vigener";
            this.btVigener.UseVisualStyleBackColor = true;
            this.btVigener.Click += new System.EventHandler(this.btVigener_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 204);
            this.label2.TabIndex = 4;
            this.label2.Text = "1. Võ Duy Kha - 4501104104\r\n2. Nguyễn Văn Huy Em - 4501104059\r\n3. Nguyễn Thị Thu " +
    "Hải - 4501104068\r\n4. Phạm Như Ý - 4501104287\r\n5. Nguyễn Thị Minh Phượng - 450110" +
    "4187\r\n6. Nguyễn Quốc Trung - 4501104261";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(282, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "NHÓM CNS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 90);
            this.label1.TabIndex = 6;
            this.label1.Text = "CHƯƠNG TRÌNH THỰC HIỆN \r\n  CÁC THUẬT TOÁN MÃ HÓA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btthanhvien
            // 
            this.btthanhvien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthanhvien.Location = new System.Drawing.Point(350, 370);
            this.btthanhvien.Name = "btthanhvien";
            this.btthanhvien.Size = new System.Drawing.Size(139, 62);
            this.btthanhvien.TabIndex = 3;
            this.btthanhvien.Text = "Thành Viên";
            this.btthanhvien.UseVisualStyleBackColor = true;
            this.btthanhvien.Click += new System.EventHandler(this.btthanhvien_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btthanhvien);
            this.Controls.Add(this.btVigener);
            this.Controls.Add(this.btRSA);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRSA;
        private System.Windows.Forms.Button btVigener;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btthanhvien;
    }
}