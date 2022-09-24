
namespace KBC
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
            this.components = new System.ComponentModel.Container();
            this.QuestionBox = new System.Windows.Forms.TextBox();
            this.Option1 = new System.Windows.Forms.Button();
            this.Option2 = new System.Windows.Forms.Button();
            this.Option4 = new System.Windows.Forms.Button();
            this.Option3 = new System.Windows.Forms.Button();
            this.Fifty = new System.Windows.Forms.PictureBox();
            this.Hint = new System.Windows.Forms.PictureBox();
            this.Next = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerlbl = new System.Windows.Forms.Label();
            this.ptlbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Fifty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionBox
            // 
            this.QuestionBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.QuestionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionBox.Location = new System.Drawing.Point(97, 230);
            this.QuestionBox.Multiline = true;
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.ReadOnly = true;
            this.QuestionBox.Size = new System.Drawing.Size(518, 52);
            this.QuestionBox.TabIndex = 1;
            // 
            // Option1
            // 
            this.Option1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option1.Location = new System.Drawing.Point(97, 314);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(205, 54);
            this.Option1.TabIndex = 2;
            this.Option1.Text = "Option1";
            this.Option1.UseVisualStyleBackColor = false;
            this.Option1.Click += new System.EventHandler(this.Option1_Click);
            // 
            // Option2
            // 
            this.Option2.BackColor = System.Drawing.SystemColors.Highlight;
            this.Option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option2.Location = new System.Drawing.Point(419, 314);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(196, 54);
            this.Option2.TabIndex = 3;
            this.Option2.Text = "Option2";
            this.Option2.UseVisualStyleBackColor = false;
            this.Option2.Click += new System.EventHandler(this.Option2_Click);
            // 
            // Option4
            // 
            this.Option4.BackColor = System.Drawing.SystemColors.Highlight;
            this.Option4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option4.Location = new System.Drawing.Point(419, 404);
            this.Option4.Name = "Option4";
            this.Option4.Size = new System.Drawing.Size(196, 54);
            this.Option4.TabIndex = 4;
            this.Option4.Text = "Option4";
            this.Option4.UseVisualStyleBackColor = false;
            this.Option4.Click += new System.EventHandler(this.Option4_Click);
            // 
            // Option3
            // 
            this.Option3.BackColor = System.Drawing.SystemColors.Highlight;
            this.Option3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option3.Location = new System.Drawing.Point(97, 404);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(205, 54);
            this.Option3.TabIndex = 5;
            this.Option3.Text = "Option3";
            this.Option3.UseVisualStyleBackColor = false;
            this.Option3.Click += new System.EventHandler(this.Option3_Click);
            // 
            // Fifty
            // 
            this.Fifty.Image = global::KBC.Properties.Resources._50__1_;
            this.Fifty.Location = new System.Drawing.Point(97, 479);
            this.Fifty.Name = "Fifty";
            this.Fifty.Size = new System.Drawing.Size(169, 102);
            this.Fifty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Fifty.TabIndex = 8;
            this.Fifty.TabStop = false;
            this.Fifty.Click += new System.EventHandler(this.Fifty_Click);
            // 
            // Hint
            // 
            this.Hint.Image = global::KBC.Properties.Resources.help__1_;
            this.Hint.Location = new System.Drawing.Point(439, 479);
            this.Hint.Name = "Hint";
            this.Hint.Size = new System.Drawing.Size(216, 71);
            this.Hint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Hint.TabIndex = 7;
            this.Hint.TabStop = false;
            this.Hint.Click += new System.EventHandler(this.Hint_Click);
            // 
            // Next
            // 
            this.Next.Image = global::KBC.Properties.Resources.nexti__1_;
            this.Next.Location = new System.Drawing.Point(272, 464);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(161, 117);
            this.Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Next.TabIndex = 6;
            this.Next.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KBC.Properties.Resources.cones_2;
            this.pictureBox1.Location = new System.Drawing.Point(97, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Lime;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(853, 520);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(294, 36);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "1           100            ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Lime;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(853, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 36);
            this.label7.TabIndex = 10;
            this.label7.Text = "7           100000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LimeGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(853, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "6           10000000  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Lime;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(853, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "5           1000000    ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LimeGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(853, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "4           100000      ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(853, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "3           10000        ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LimeGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(853, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 36);
            this.label2.TabIndex = 15;
            this.label2.Text = "2           1000          ";
            // 
            // playerlbl
            // 
            this.playerlbl.AutoSize = true;
            this.playerlbl.BackColor = System.Drawing.Color.DodgerBlue;
            this.playerlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerlbl.Location = new System.Drawing.Point(854, 39);
            this.playerlbl.Name = "playerlbl";
            this.playerlbl.Size = new System.Drawing.Size(0, 36);
            this.playerlbl.TabIndex = 17;
            // 
            // ptlbl
            // 
            this.ptlbl.AutoSize = true;
            this.ptlbl.BackColor = System.Drawing.Color.DodgerBlue;
            this.ptlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptlbl.Location = new System.Drawing.Point(853, 126);
            this.ptlbl.Name = "ptlbl";
            this.ptlbl.Size = new System.Drawing.Size(294, 36);
            this.ptlbl.TabIndex = 18;
            this.ptlbl.Text = "7           100000000";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.timelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.Location = new System.Drawing.Point(308, 366);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(96, 36);
            this.timelbl.TabIndex = 19;
            this.timelbl.Text = "01:00";
            this.timelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timelbl.Click += new System.EventHandler(this.timelbl_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 652);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.ptlbl);
            this.Controls.Add(this.playerlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Fifty);
            this.Controls.Add(this.Hint);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Option3);
            this.Controls.Add(this.Option4);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fifty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox QuestionBox;
        private System.Windows.Forms.Button Option1;
        private System.Windows.Forms.Button Option2;
        private System.Windows.Forms.Button Option4;
        private System.Windows.Forms.Button Option3;
        private System.Windows.Forms.PictureBox Next;
        private System.Windows.Forms.PictureBox Hint;
        private System.Windows.Forms.PictureBox Fifty;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playerlbl;
        private System.Windows.Forms.Label ptlbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timelbl;
    }
}