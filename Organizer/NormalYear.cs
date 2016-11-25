using System;

namespace Organizer
{
	/// <summary>
	/// Description of NormalYear.
	/// </summary>
	public class NormalYear: Year
	{
		
		
		public NormalYear(int numberOfYear){
			YearNumber=numberOfYear;
			Month[0] = new Day[31];
			Month[1] = new Day[28];
			Month[2] = new Day[31];
			Month[3] = new Day[30];
			Month[4] = new Day[31];
			Month[5] = new Day[30];
			Month[6] = new Day[31];
			Month[7] = new Day[31];
			Month[8] = new Day[30];
			Month[9] = new Day[31];
			Month[10] = new Day[30];
			Month[11] = new Day[31];
			
			for (int i=0; i< 12; i++) {
				for (int j=0; j<Month[i].Length; j++) {
					Month[i][j] = new Day(j);
				}
			}
		}
	}
}
