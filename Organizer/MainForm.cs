using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;


namespace Organizer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	
	public partial class MainForm : Form
	{	
		ListYear calendar = new ListYear();
		String jmeno=null;
		int count=0;
		public MainForm()
		{	
			InitializeComponent();
			groupBox1.Visible = false;
			groupBox2.Visible = false;
			groupBox3.Visible = false;
			textBox2.Visible = false;
			label1.Text = "Vyberte datum na ktery chcete ulozit nove připomínání";
			button1.Text = "Najit den";
			button2.Text = "Ulozit nove připomínání ";
			button3.Text = "Vymazat";
			label2.Text="od";
			label3.Text="do";	
			label4.Text="-";
			label5.Text="Vase jmeno:";
			label6.Text="Datum:";
			label7.Text="Co smazat: ";
			label8.Text = "Format - d.m.rrrr";
			button4.Text = "Zobrazit";
			button5.Text = "Prihlasit se";	
		}

		
		void createCalendar() {
			for (int i=0; i<200; i++) {
				calendar.addYear();
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
				showAction();
		}
		
		void Button2Click(object sender, EventArgs e)
		{	
			if(textBox2.Text == null) {
				textBox2.Text = "Nemate nic k ulozeni";
			}
			else {
				doNewAction();
				textBox2.Text = "Pripominani uspesne ulozeno";
				count++;
				serializace();
				}
			
		}

		void Button3Click(object sender, EventArgs e)
		{	
			try {
				String [] date = textBox7.Text.Split('.');
				int nDay = int.Parse(date[0]);
				int nMonth = int.Parse(date[1]);
				int nYear = int.Parse(date[2]);
				String popisDela = textBox3.Text;
				calendar.vymazatPropominani(nDay, nMonth, nYear, popisDela);
				serializace();
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
		
		void vsichnyPripminani(int nDay1,int nMonth1,int nYear1,int nDay2,int nMonth2,int nYear2) {			// zobrazuje seznam pripominani z intervalu
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
	
		
		void doNewAction() {															// vyttori nove propominani
				int nDay, nYear, nMonth;
				if ((textBox1.Text != null)&&(textBox1.Text != "")) {
					String [] date = textBox1.Text.Split('.');
					nDay = int.Parse(date[0]);
					nMonth = int.Parse(date[1]);
					nYear = int.Parse(date[2]);
				}
				else {
					DateTime XDay = new DateTime();
					XDay = monthCalendar1.SelectionStart;
					nDay = XDay.Day;
					nMonth = XDay.Month;
					nYear = XDay.Year;
				}
				String popisDela = textBox2.Text;
				calendar.findDate(nDay, nMonth, nYear, popisDela);
				serializace();
			}
		
		
		void showAction() {														//zobrazi pripominani z jednoho dne
				int nDay, nYear, nMonth;
				if ((textBox1.Text != null)&&(textBox1.Text != "")) {
					String [] date = textBox1.Text.Split('.');
					nDay = int.Parse(date[0]);
					nMonth = int.Parse(date[1]);
					nYear = int.Parse(date[2]);
				}
				else {
					DateTime XDay = new DateTime();
					XDay = monthCalendar1.SelectionStart;
					nDay = XDay.Day;
					nMonth = XDay.Month;
					nYear = XDay.Year;
				}
				if ((calendar.findDate(nDay, nMonth, nYear) == null)||(calendar.findDate(nDay, nMonth, nYear) == "")) {
					textBox2.Text = "Na dneska nemate zadne pripominani";
				}
				else 
				textBox2.Text = calendar.findDate(nDay, nMonth, nYear);
		}
		
		void showActionToday() {								//startova metoda, ktera zobrazi seznam pripominani na dneska pri startu programu
			DateTime d = new DateTime();
			d=DateTime.Now;
			int nDay = d.Day;
			int nMonth = d.Month;
			int nYear = d.Year;
			if(calendar.findDate(nDay, nMonth, nYear)=="Записей нет") {
				textBox2.Text = "Na dneska nemate zadne pripominani";
			}
			else {
				textBox2.Text = calendar.findDate(nDay, nMonth, nYear);
			}
		}
		
		
		void Button5Click(object sender, EventArgs e)
		{			
			if (textBox6.Text != "") {
				jmeno=textBox6.Text;
				textBox2.Text = "Jste prihlasen/a jako " + jmeno;
				deseralizace();
				showActionToday();
				groupBox4.Visible = false;
				groupBox1.Visible = true;
				groupBox2.Visible = true;
				groupBox3.Visible = true;
				textBox2.Visible = true;
			}
			else 
				textBox2.Text = "Nezadali jste zadne jmeno!";
		}
		
		
		
		void serializace() {
			BinaryFormatter formatter = new BinaryFormatter();
			using ( var fSream = new FileStream(jmeno+".dat", FileMode.Create, FileAccess.Write, FileShare.None)) {
				formatter.Serialize(fSream, calendar);
			}
		}
		
		
		void deseralizace() {
			try {
				using (var fStream = File.OpenRead(jmeno + ".dat")) {
					BinaryFormatter formatter = new BinaryFormatter();
					calendar = (ListYear)formatter.Deserialize(fStream);
				}
			}
			catch (Exception e) {
				createCalendar();
			}
		}
		
		
	}
}
