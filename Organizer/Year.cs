using System;

namespace Organizer
{
	/// <summary>
	/// Description of Year.
	/// </summary>
	public class Year
	{	public Year Next;
		protected int YearNumber;
		protected Day [][] Month = new Day[12][];
			
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
		
	}
}
