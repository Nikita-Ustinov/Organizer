using System;

namespace Organizer
{
	/// <summary>
	/// Description of Year.
	/// </summary>
	public  class Year
	{	
		public Year Next { get; set; }
//		public Year Next;
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
			if (yearNeeded.Month[nMonth-1][nDay-1].toDoList == null) {
				yearNeeded.Month[nMonth-1][nDay-1].toDoList= new ListAction(popisDela);
			}
			else {
				Action templ = yearNeeded.Month[nMonth-1][nDay-1].toDoList.First;
				while(templ.next!=null) {
					templ = templ.next;
				}
				templ.next = new Action(popisDela);
			}
		}
		
		public String findMonth( Year yearNeeded,int nMonth,int nDay) {
			if (yearNeeded.Month[nMonth-1][nDay-1].toDoList == null) {
			return "Записей нет";
			}
			else {
				Action templ = yearNeeded.Month[nMonth-1][nDay-1].toDoList.First;
				String popis=null;
				int count=-1;
				while(templ!=null) {
				count++;
					
					if (templ.PopisDela!=null) {
						popis+=(count+1).ToString() + " - " + templ.PopisDela + "\r\n";
					}
					if (templ.next!=null){
						templ = templ.next;
					}
					else 
						break;
				}
				return popis;
			}
		}
		
		public void vamazat(Year yearNeeded, int nMonth,int  nDay,String  popisDela){
			yearNeeded.Month[nMonth-1][nDay-1].toDoList. removeAction(popisDela);
		}
		
		public String vypsatZ(int nDay1,int nMonth1,Year startYear,int nDay2,int nMonth2,Year finishYear) {
			Day finishDay = finishYear.Month[nMonth2-1][nDay2] ;
			Day templDay = startYear.Month[nMonth1-1][nDay1-1];
			String popis=null;
			int count=-1;
			
			while(finishDay!=templDay) {
				if (startYear.Month[nMonth1-1][nDay1-1].toDoList == null) {
			      		if (startYear.Month[nMonth1-1].Length-templDay.numberOfDay != 0) {
			      			nDay1++;
			      		}
			      		else  if(nMonth1-1 != 12) {
			      				nMonth1++;
			      				nDay1=1;
			      				}
								else startYear=startYear.Next;
			      		
			      	
				}
				else {
					Action templ = startYear.Month[nMonth1-1][nDay1-1].toDoList.First;
					
					while(templ!=null) {
						count++;
						if (templ.PopisDela!=null) {
							popis+=(count+1).ToString() + " - " + templ.PopisDela + "\r\n";
						}
						if (templ.next!=null){
							templ = templ.next;
						}
						else 
							break;
					}
					if (startYear.Month[nMonth1-1].Length-templDay.numberOfDay != 0) {
			      			nDay1++;
			      		}
			      		else  if(nMonth1-1 != 12) {
			      				nMonth1++;
			      				nDay1=1;
			      				}
								else startYear=startYear.Next;
								
				}
			
				templDay = startYear.Month[nMonth1-1][nDay1-1];
			}
			return popis;
		
	
		}
	}}
