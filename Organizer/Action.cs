using System;

namespace Organizer
{
	/// <summary>
	/// Description of Action.
	/// </summary>
	public class Action
	{
		public Action next{ get; set; }
		public String PopisDela { get; set; }
		public int priority { get; set; }         // 1-nejvyssi; 3-nejnissi
		
		
		public Action(){}
		
		public Action(String popis) {
			PopisDela = popis;
			priority = 2;
		}
		
		public Action(String popis, int priority)
		{
			PopisDela = popis;
			this.priority = priority;
		}
	}
}
