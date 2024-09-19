namespace FunnyFarm
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
            this.txtBoCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeCount = new System.Windows.Forms.TextBox();
            this.txtCuuCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInitFarm = new System.Windows.Forms.Button();
            this.btnFeedAnimals = new System.Windows.Forms.Button();
            this.btnGetStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoCount
            // 
            this.txtBoCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoCount.Location = new System.Drawing.Point(30, 109);
            this.txtBoCount.Multiline = true;
            this.txtBoCount.Name = "txtBoCount";
            this.txtBoCount.Size = new System.Drawing.Size(178, 38);
            this.txtBoCount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(297, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số lượng gia súc";
            // 
            // txtDeCount
            // 
            this.txtDeCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeCount.Location = new System.Drawing.Point(584, 109);
            this.txtDeCount.Multiline = true;
            this.txtDeCount.Name = "txtDeCount";
            this.txtDeCount.Size = new System.Drawing.Size(178, 38);
            this.txtDeCount.TabIndex = 2;
            // 
            // txtCuuCount
            // 
            this.txtCuuCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuuCount.Location = new System.Drawing.Point(301, 109);
            this.txtCuuCount.Multiline = true;
            this.txtCuuCount.Name = "txtCuuCount";
            this.txtCuuCount.Size = new System.Drawing.Size(178, 38);
            this.txtCuuCount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập số lượng bò";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(580, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập số lượng dê";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(297, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhập số lượng cừu";
            // 
            // btnInitFarm
            // 
            this.btnInitFarm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInitFarm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitFarm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInitFarm.Location = new System.Drawing.Point(30, 256);
            this.btnInitFarm.Name = "btnInitFarm";
            this.btnInitFarm.Size = new System.Drawing.Size(178, 59);
            this.btnInitFarm.TabIndex = 7;
            this.btnInitFarm.Text = "Tạo nông trại";
            this.btnInitFarm.UseVisualStyleBackColor = false;
            this.btnInitFarm.Click += new System.EventHandler(this.btnInitFarm_Click);
            // 
            // btnFeedAnimals
            // 
            this.btnFeedAnimals.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFeedAnimals.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedAnimals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFeedAnimals.Location = new System.Drawing.Point(301, 256);
            this.btnFeedAnimals.Name = "btnFeedAnimals";
            this.btnFeedAnimals.Size = new System.Drawing.Size(183, 59);
            this.btnFeedAnimals.TabIndex = 8;
            this.btnFeedAnimals.Text = "Cho gia súc ăn";
            this.btnFeedAnimals.UseVisualStyleBackColor = false;
            this.btnFeedAnimals.Click += new System.EventHandler(this.btnFeedAnimals_Click);
            // 
            // btnGetStatistics
            // 
            this.btnGetStatistics.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGetStatistics.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetStatistics.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetStatistics.Location = new System.Drawing.Point(584, 256);
            this.btnGetStatistics.Name = "btnGetStatistics";
            this.btnGetStatistics.Size = new System.Drawing.Size(178, 59);
            this.btnGetStatistics.TabIndex = 9;
            this.btnGetStatistics.Text = "Thông tin thu hoạch";
            this.btnGetStatistics.UseVisualStyleBackColor = false;
            this.btnGetStatistics.Click += new System.EventHandler(this.btnGetStatistics_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetStatistics);
            this.Controls.Add(this.btnFeedAnimals);
            this.Controls.Add(this.btnInitFarm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCuuCount);
            this.Controls.Add(this.txtDeCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoCount);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeCount;
        private System.Windows.Forms.TextBox txtCuuCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInitFarm;
        private System.Windows.Forms.Button btnFeedAnimals;
        private System.Windows.Forms.Button btnGetStatistics;
    }
}

