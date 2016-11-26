using System;

namespace Organizer
{
	/// <summary>
	/// Description of Year.
	/// </summary>
	public  class Year
	{	public Year Next;
		protected int YearNumber;
		protected  Day [][] Month = new Day[12][];
			
		public Year(){}
		
		public Year(int numberOfYear){
			YearNumber=numberOfYear;
		}
		
		public String  writeYears() {
			String s=null;
			int count=0;
			for (int i=0; i<12; i++) {
				for (int j=0; j<Month[i].Length; j++) {
					s+=Month[i][j].numberOfDay;
					s+=" ";
					count++;
					if (count==7){
						s+="\r\n";
						count=0;
					}
				}
			}
			
			return s;
		}
		
		
		public void findMonth( Year yearNeeded,int nMonth,int nDay, String popisDela) {
			if (yearNeeded.Month[nMonth][nDay].toDoList == null) {
				yearNeeded.Month[nMonth][nDay].toDoList= new ListAction(popisDela);
			}
			else {
				Action templ = yearNeeded.Month[nMonth][nDay].toDoList.First;
				while(templ.next!=null) {
					templ = templ.next;
				}
				templ.PopisDela=popisDela;
			}
		}
		
		public String findMonth( Year yearNeeded,int nMonth,int nDay) {
			if (yearNeeded.Month[nMonth][nDay].toDoList == null) {
			return "Записей нет";
			}
			else {
				Action templ = yearNeeded.Month[nMonth][nDay].toDoList.First;
				while(templ.next!=null) {
					templ = templ.next;
				}
				return templ.PopisDela;
			}
		}
		
	}
}
