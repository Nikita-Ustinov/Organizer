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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 63);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(6, 112);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(257, 66);
			this.textBox2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Дата\r\n";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 14);
			this.label2.TabIndex = 3;
			this.label2.Text = "Напоминание";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 191);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Запись напоминаний";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Controls.Add(this.textBox4);
			this.groupBox2.Location = new System.Drawing.Point(12, 225);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(272, 189);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Показать напомнинания за день";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 14);
			this.label3.TabIndex = 6;
			this.label3.Text = "Дата\r\n";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 14);
			this.label4.TabIndex = 7;
			this.label4.Text = "Напоминание";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(6, 39);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 4;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(6, 88);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(257, 66);
			this.textBox4.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(156, 20);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 63);
			this.button1.TabIndex = 4;
			this.button1.Text = "Записать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(156, 17);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(107, 63);
			this.button2.TabIndex = 8;
			this.button2.Text = "Показать";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 409);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Organizer";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
	}
}
