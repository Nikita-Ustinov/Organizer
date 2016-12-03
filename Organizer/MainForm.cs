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
		{	DateTime d = new DateTime();
			createCalendar();
			InitializeComponent();
			label1.Text = "Vyberte datum na ktery chcete ulozit nove připomínání";
			button1.Text = "Najit den";
			button2.Text = "Ulozit nove připomínání ";
//			label2.Text = "Vymazani pripominani";
			button3.Text = "Vymazat";
			label2.Text="od";
			label3.Text="do";	
			label4.Text="-";	
			button4.Text = "Zobrazit";		
			showAction(d);
		}

		
		void createCalendar() {
			for (int i=0; i<200; i++) {
				calendar.addYear();
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{	try {
				showAction();
			}
			catch (Exception ee){
				textBox2.Text = "Spatny format datumu! Zadejte datum ve tvaru d.m.rrrr ";
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{	
			if(textBox2.Text=="") {
				textBox2.Text = "Spatny format datumu! Zadejte datum ve tvaru d.m.rrrr ";
			}
			else {
				doNewAction();
				textBox2.Text = "Pripominani uspesne ulozeno";
			}
			
		}

		void Button3Click(object sender, EventArgs e)
		{	
			try {
				String [] date = textBox1.Text.Split('.');
				int nDay = int.Parse(date[0]);
				int nMonth = int.Parse(date[1]);
				int nYear = int.Parse(date[2]);
				String popisDela = textBox3.Text;
				calendar.vymazatPropominani(nDay, nMonth, nYear, popisDela);
				textBox2.Text = "Pripominani uspesne smazano";
			}
			catch (Exception ee){
				textBox2.Text = "Doslo k chybe! Bud to spatny format datumu nebo jste spatne napsal pripominani k vymazani ";
			}
			
		}		
		
		void Button4Click(object sender, EventArgs e) {
			try {
				String [] date1 = textBox4.Text.Split('.');
				int nDay1 = int.Parse(date1[0]);
				int nMonth1 = int.Parse(date1[1]);
				int nYear1 = int.Parse(date1[2]);
				
				String [] date2 = textBox5.Text.Split('.');
				int nDay2 = int.Parse(date2[0]);
				int nMonth2 = int.Parse(date2[1]);
				int nYear2 = int.Parse(date2[2]);
				vsichnyPripminani(nDay1, nMonth1, nYear1, nDay2, nMonth2, nYear2);
			}
			catch (Exception ee){
				textBox2.Text = "Spatny format datumu! Zadejte datum ve tvaru d.m.rrrr ";
			}
			
			
		}
		
		void vsichnyPripminani(int nDay1,int nMonth1,int nYear1,int nDay2,int nMonth2,int nYear2) {
			if ((nDay1==nDay2)&&(nMonth1==nMonth2)&&(nYear2==nYear1)){
				textBox2.Text = "Mate v intervalu je jeden den. Zadejte vetsi interval";
			}
			else {
				if (calendar.vypsatZIntervalu( nDay1, nMonth1, nYear1, nDay2, nMonth2, nYear2)!=null) {
					textBox2.Text= calendar.vypsatZIntervalu( nDay1, nMonth1, nYear1, nDay2, nMonth2, nYear2) ;
				}
				else {
					textBox2.Text= "Nemate zadne pripominani";
				}
			}
		}
	
		
		void doNewAction() {
			try {
				String [] date = textBox1.Text.Split('.');
				int nDay = int.Parse(date[0]);
				int nMonth = int.Parse(date[1]);
				int nYear = int.Parse(date[2]);
				String popisDela = textBox2.Text;
				calendar.findDate(nDay, nMonth, nYear, popisDela);
			}
			catch (Exception ee){
				textBox2.Text = "Spatny format datumu! Zadejte datum ve tvaru d.m.rrrr ";
			}
		}
		
		void showAction() {
			try {
				String [] date = textBox1.Text.Split('.');
				int nDay = int.Parse(date[0]);
				int nMonth = int.Parse(date[1]);
				int nYear = int.Parse(date[2]);
				textBox2.Text = calendar.findDate(nDay, nMonth, nYear);
			}
			catch (Exception ee){
				textBox2.Text = "Spatny format datumu! Zadejte datum ve tvaru d.m.rrrr ";
			}
		}
		
		void showAction(DateTime d) {
			int nDay = d.Day;
			int nMonth = d.Month;
			int nYear = d.Year;
			if(calendar.findDate(nDay, nMonth, nYear)=="Записей нет") {
				textBox2.Text = "Na dneska nemate zadne pripominani";
			}
		}
		
		
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
