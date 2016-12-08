using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Organizer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{	
		ListYear calendar = new ListYear();
		DateTime nowDate = DateTime.Now;
		String jmeno=null;
		String listAction = null;
		int count=0;
		public MainForm()
		{	
			DateTime d = new DateTime();
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
			label5.Text="Vase jmeno";
			button4.Text = "Zobrazit";
			button5.Text = "Prihlasit se";	
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
				count++;
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
				listAction+=nDay.ToString()+"."+nMonth.ToString()+"."+nYear.ToString()+"\r\n" + popisDela+"\r\n";
				if (count==0) {
					try {
						listAction = File.ReadAllText(jmeno);
						}
					catch(Exception ee) {
						}
				}
				File.WriteAllText(jmeno, listAction);
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
		
		
		void Button5Click(object sender, EventArgs e)
		{
			if (textBox6.Text!= "") {
				jmeno=textBox6.Text+ ".txt";
				try {
				textBox2.Text = "Jste prihlasen/a jako " + jmeno;
				deseralizace(jmeno);
				}
				catch (Exception ee) {}
			}
			else 
				textBox2.Text = "Nezadali jste zadne jmeno!";
		}
		
		void deseralizace(String jmeno) {
			using (StreamReader sr = new StreamReader(@jmeno))
			{
				String popisDela = null;
				String dataText = null;
				while(!sr.EndOfStream)
				{
					dataText=sr.ReadLine().ToString();
					popisDela = sr.ReadLine().ToString();
					String [] date = dataText.Split('.');
					int nDay = int.Parse(date[0]);
					int nMonth = int.Parse(date[1]);
					int nYear = int.Parse(date[2]);
					calendar.findDate(nDay, nMonth, nYear, popisDela);
				}
			}
		}
	}
}
