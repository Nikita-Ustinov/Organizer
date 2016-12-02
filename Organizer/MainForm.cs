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
		DateTime nowDate = DateTime.Now;
		
		public MainForm()
		{
			createCalendar();
			InitializeComponent();
			label1.Text = "Vyberte datum na ktery chcete ulozit nove připomínání";
			button1.Text = "Najit den";
			button2.Text = "Ulozit nove připomínání ";
			label2.Text = "Vymazani pripominani";
			button3.Text = "Vymazat";
		}

		
		void createCalendar() {
			for (int i=0; i<200; i++) {
				calendar.addYear();
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
//			showAction();
		
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			doNewAction();
			textBox2.Text = "Pripominani uspesne ulozeno";
		}

		void Button3Click(object sender, EventArgs e)
		{
			String [] date = textBox1.Text.Split('.');
			int nDay = int.Parse(date[0]);
			int nMonth = int.Parse(date[1]);
			int nYear = int.Parse(date[2]);
			String popisDela = textBox3.Text;
			calendar.vymazatPropominani(nDay, nMonth, nYear, popisDela);
			textBox2.Text = "Pripominani uspesne smazano";
		}		
		
		void doNewAction() {
			String [] date = textBox1.Text.Split('.');
			int nDay = int.Parse(date[0]);
			int nMonth = int.Parse(date[1]);
			int nYear = int.Parse(date[2]);
			String popisDela = textBox2.Text;
			calendar.findDate(nDay, nMonth, nYear, popisDela);
		}
		
//		void showAction() {
//			DateTime d = new DateTime();
//			String [] date = textBox1.Text.Split('.');
//			int nDay = int.Parse(date[0]);
//			int nMonth = int.Parse(date[1]);
//			int nYear = int.Parse(date[2]);
//			textBox2.Text = calendar.findDate(nDay, nMonth, nYear);
//		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			
		}
		
		
	}
}
