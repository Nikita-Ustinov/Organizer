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
//			createCalendar();
			
			
			
		}
		
		
		
		
		void createCalendar() {
			int pocetLet=8;
			ListYear calendar = new ListYear();
			for (int i=0; i<pocetLet; i++) {
				textBox1.Text= calendar.addYear().ToString();
			}
		}
		
		
		
		
	}
}
