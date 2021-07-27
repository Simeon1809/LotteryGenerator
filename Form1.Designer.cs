
using System;

namespace Lottery_Generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLottery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLottery2 = new System.Windows.Forms.TextBox();
            this.txtLottery5 = new System.Windows.Forms.TextBox();
            this.txtLottery3 = new System.Windows.Forms.TextBox();
            this.txtLottery6 = new System.Windows.Forms.TextBox();
            this.txtLottery4 = new System.Windows.Forms.TextBox();
            this.txtLottery1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 500;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 500;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 500;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // timer7
            // 
            this.timer7.Enabled = true;
            this.timer7.Interval = 500;
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(724, 595);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(251, 72);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLottery
            // 
            this.btnLottery.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLottery.Location = new System.Drawing.Point(202, 595);
            this.btnLottery.Name = "btnLottery";
            this.btnLottery.Size = new System.Drawing.Size(251, 72);
            this.btnLottery.TabIndex = 1;
            this.btnLottery.Text = "Lottery";
            this.btnLottery.UseVisualStyleBackColor = true;
            this.btnLottery.Click += new System.EventHandler(this.btnLottery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(273, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lottery Number Generator";
            // 
            // txtLottery2
            // 
            this.txtLottery2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtLottery2.Enabled = false;
            this.txtLottery2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLottery2.Location = new System.Drawing.Point(474, 96);
            this.txtLottery2.Multiline = true;
            this.txtLottery2.Name = "txtLottery2";
            this.txtLottery2.Size = new System.Drawing.Size(211, 137);
            this.txtLottery2.TabIndex = 3;
            this.txtLottery2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLottery2.TextChanged += new System.EventHandler(this.txtLottery2_TextChanged);
            // 
            // txtLottery5
            // 
            this.txtLottery5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtLottery5.Enabled = false;
            this.txtLottery5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLottery5.Location = new System.Drawing.Point(647, 271);
            this.txtLottery5.Multiline = true;
            this.txtLottery5.Name = "txtLottery5";
            this.txtLottery5.Size = new System.Drawing.Size(211, 137);
            this.txtLottery5.TabIndex = 5;
            this.txtLottery5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLottery5.TextChanged += new System.EventHandler(this.txtLottery5_TextChanged);
            // 
            // txtLottery3
            // 
            this.txtLottery3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtLottery3.Enabled = false;
            this.txtLottery3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLottery3.Location = new System.Drawing.Point(724, 96);
            this.txtLottery3.Multiline = true;
            this.txtLottery3.Name = "txtLottery3";
            this.txtLottery3.Size = new System.Drawing.Size(211, 137);
            this.txtLottery3.TabIndex = 7;
            this.txtLottery3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLottery3.TextChanged += new System.EventHandler(this.txtLottery3_TextChanged);
            // 
            // txtLottery6
            // 
            this.txtLottery6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtLottery6.Enabled = false;
            this.txtLottery6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLottery6.Location = new System.Drawing.Point(497, 432);
            this.txtLottery6.Multiline = true;
            this.txtLottery6.Name = "txtLottery6";
            this.txtLottery6.Size = new System.Drawing.Size(211, 131);
            this.txtLottery6.TabIndex = 11;
            this.txtLottery6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLottery6.TextChanged += new System.EventHandler(this.txtLottery6_TextChanged);
            // 
            // txtLottery4
            // 
            this.txtLottery4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtLottery4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLottery4.Location = new System.Drawing.Point(356, 271);
            this.txtLottery4.Multiline = true;
            this.txtLottery4.Name = "txtLottery4";
            this.txtLottery4.Size = new System.Drawing.Size(211, 137);
            this.txtLottery4.TabIndex = 15;
            this.txtLottery4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLottery4.TextChanged += new System.EventHandler(this.txtLottery4_TextChanged);
            // 
            // txtLottery1
            // 
            this.txtLottery1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtLottery1.Enabled = false;
            this.txtLottery1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLottery1.Location = new System.Drawing.Point(233, 96);
            this.txtLottery1.Multiline = true;
            this.txtLottery1.Name = "txtLottery1";
            this.txtLottery1.Size = new System.Drawing.Size(211, 137);
            this.txtLottery1.TabIndex = 14;
            this.txtLottery1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLottery1.TextChanged += new System.EventHandler(this.txtLottery1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 668);
            this.Controls.Add(this.txtLottery1);
            this.Controls.Add(this.txtLottery4);
            this.Controls.Add(this.txtLottery6);
            this.Controls.Add(this.txtLottery3);
            this.Controls.Add(this.txtLottery5);
            this.Controls.Add(this.txtLottery2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLottery);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLottery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLottery2;
        private System.Windows.Forms.TextBox txtLottery5;
        private System.Windows.Forms.TextBox txtLottery3;
        private System.Windows.Forms.TextBox txtLottery6;
        private System.Windows.Forms.TextBox txtLottery4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.TextBox txtLottery1;
    }
}

