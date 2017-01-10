using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Organizer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(182, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 61);
			this.label1.TabIndex = 5;
			this.label1.Text = "label1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(182, 147);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(142, 24);
			this.button1.TabIndex = 6;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(182, 118);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(142, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(18, 195);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(330, 171);
			this.textBox2.TabIndex = 9;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(6, 166);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(191, 23);
			this.button3.TabIndex = 10;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(7, 75);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(190, 85);
			this.textBox3.TabIndex = 11;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.monthCalendar1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(336, 177);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(182, 70);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 19);
			this.label8.TabIndex = 21;
			this.label8.Text = "label8";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(182, 92);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(142, 20);
			this.textBox1.TabIndex = 20;
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(6, 9);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 19;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.textBox7);
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Location = new System.Drawing.Point(354, 159);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(203, 207);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Vymazani";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 49);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 23);
			this.label7.TabIndex = 14;
			this.label7.Text = "label7";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(51, 17);
			this.label6.TabIndex = 13;
			this.label6.Text = "label6";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(63, 19);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(81, 20);
			this.textBox7.TabIndex = 12;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button4);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.textBox5);
			this.groupBox3.Controls.Add(this.textBox4);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Location = new System.Drawing.Point(354, 14);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(203, 139);
			this.groupBox3.TabIndex = 14;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Vyberte interval";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(23, 95);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(155, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(95, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "label4";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(118, 59);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(79, 20);
			this.textBox5.TabIndex = 3;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(7, 60);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(82, 20);
			this.textBox4.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(118, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "label3";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(66, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "label2";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 23);
			this.label5.TabIndex = 15;
			this.label5.Text = "label5";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(77, 16);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(132, 20);
			this.textBox6.TabIndex = 16;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(6, 42);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(248, 23);
			this.button5.TabIndex = 17;
			this.button5.Text = "button5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.button5);
			this.groupBox4.Controls.Add(this.textBox6);
			this.groupBox4.Location = new System.Drawing.Point(150, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(264, 75);
			this.groupBox4.TabIndex = 18;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Prihlaseni";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(565, 374);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBox2);
			this.Name = "MainForm";
			this.Text = "Organizer";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}
