using System;

namespace Organizer
{
	public class ListAction
	{
		int LengthToDoList=0;
		public Action First;
		
		public ListAction(String popisDela)
		{ 	
			if (First==null) {
				First = new Action(popisDela);
			}
			else {
				
			}
		}
		
		public ListAction(String popisDela, int priority)
		{ 	
			if (First==null) {
				First = new Action(popisDela, priority);
			}
			else {
				Action templ;
				templ=First;
				while(templ.next!=null) {
					templ=templ.next;
				}
				templ.next= new Action(popisDela, priority);
			}
		}
		
		public void addAction(String popisDela) {
				Action templ=First;				
				while(templ.next!=null) {
					templ=templ.next;
				}
				templ.next= new Action(popisDela);
		}
		
		public void addAction(String popisDela, int priority) {
					Action templ=First;				
				while(templ.next!=null) {
					templ=templ.next;
				}
				templ.next= new Action(popisDela, priority );
		}
	}
}
