using System;
using System.Runtime.Serialization.Formatters.Binary;
namespace Organizer
{
	
	[Serializable]
	public class ListAction
	{
		public Action First { get; set; }
		
		public ListAction(String popisDela)
		{ 	
			if (First==null) {
				First = new Action(popisDela);
			}
			else {
				
			}
		}
		
		public void addAction(String popisDela) {
				Action templ=First;				
				while(templ.next!=null) {
					templ=templ.next;
				}
				templ.next= new Action(popisDela);
		}
		
		public void removeAction(String popis) {
			Action templ = First;
			int count=0;
			while(!templ.PopisDela.StartsWith(popis)) {
				count++;
				templ= templ.next;
			}
			templ = First;
			if (count != 0){
				while(count!=1){
					templ=templ.next;
					count--;
				}
				if (templ.next.next != null) {
					templ.next=templ.next.next;
				}
				else {
					templ.next = null;
				}
			}
			else {
				if (First.next == null) {
					First = null;
				}
				else {
					First=First.next;
				}
				
			}
		}
		
	}
}
