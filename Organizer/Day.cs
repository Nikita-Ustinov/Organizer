using System;
using System.Runtime.Serialization.Formatters.Binary;
namespace Organizer
{
	
	[Serializable]
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
