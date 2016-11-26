using System;

namespace Organizer
{
	/// <summary>
	/// Description of ListYear.
	/// </summary>
	public class ListYear
	{	
		int LenthCalendar=0;
		Year First;
		int FirstYear = 2012;
		
		public ListYear()
		{ 	
			First = new LeapYear(FirstYear);
			LenthCalendar++;
		}
		
		public  int addYear() {
			Year templ = First;
			while (templ.Next!=null) {
				templ=templ.Next;
			}
			
			if ((LenthCalendar/4)!=1) {
				templ.Next= new NormalYear(FirstYear+LenthCalendar);
				LenthCalendar++;
			}
			else {
				templ.Next= new LeapYear(FirstYear+LenthCalendar);
				LenthCalendar++;
			}
			return FirstYear+LenthCalendar-1;
		}
		
		public void findDate(int nDay,int nMonth,int nYear, String popisDela){
			Year yearNeeded = findYear(nYear);
			yearNeeded.findMonth(yearNeeded, nMonth, nDay, popisDela);
		}
		
		
		 Year  findYear(int nYear) {
			Year templ = First;
			for (int i=0; i< nYear-FirstYear; i++) {
				templ=templ.Next;
			}
			return templ;
		}
	}
}
