using System;

namespace Organizer
{
	public class Day
	{
		public int numberOfDay { get; set; }
		public ListAction toDoList { get; set; }
		
		public Day(){}
		
		public Day(int j) {
		 numberOfDay = j+1;
		}
		
	}
}
