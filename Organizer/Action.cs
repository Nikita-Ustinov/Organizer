using System;
using System.Runtime.Serialization.Formatters.Binary;
namespace Organizer
{
	/// <summary>
	/// Description of Action.
	/// </summary>
	/// 
	
	[Serializable]
	public class Action
	{
		public Action next{ get; set; }
		public String PopisDela { get; set; }
		
		
		public Action(){}
		
		public Action(String popis) {
			PopisDela = popis;
		}
	}
}
