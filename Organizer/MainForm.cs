using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Organizer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{	
		ListYear calendar = new ListYear();
		
		public MainForm()
		{
			createCalendar();
			InitializeComponent();
				
		}

		
		void createCalendar() {
			for (int i=0; i<10; i++) {
				calendar.addYear();
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			doNewAction();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			showAction();
		}
		
		
		void doNewAction() {
			String [] date = textBox1.Text.Split('.');
			int nDay = int.Parse(date[0]);
			int nMonth = int.Parse(date[1]);
			int nYear = int.Parse(date[2]);
			String popisDela = textBox2.Text;
			calendar.findDate(nDay, nMonth, nYear, popisDela);
		}
		
		void showAction() {
			String [] date = textBox1.Text.Split('.');
			int nDay = int.Parse(date[0]);
			int nMonth = int.Parse(date[1]);
			int nYear = int.Parse(date[2]);
			textBox4.Text = calendar.findDate(nDay, nMonth, nYear);
		}
		
	}
}
