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
		public MainForm()
		{
			InitializeComponent();
//			String Years=null;
//			textBox1.Text=Years;
//			LeapYear y = new LeapYear();
//			textBox1.Text=y.writeYears();
//			Console.ReadLine();
			
			ListYear calendar = new ListYear();
			for (int i=0; i<pocetLet; i++) {
				textBox1.Text= calendar.addYear().ToString();
			}
			
			
		}
	}
}
