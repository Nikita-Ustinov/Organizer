using System;

namespace Organizer
{
	public class ListAction
	{
		int LengthToDoList=0;
		Action First=null;
		
		public ListAction(String popisDela)
		{ 	
			if (First==null) {
				First = new Action(popisDela);
			}
			else {
				Action templ;
				templ=First;
				while(templ.next!=null) {
					templ=templ.next;
				}
				templ.next= new Action(popisDela);
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
		
		
		
		}
	}

