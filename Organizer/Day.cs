﻿using System;

namespace Organaizer
{
	public class Day
	{
		public int numberOfDay { get; set; }
		ListAction toDoList;
		
		public Day(){}
		
		public Day(int j) {
		 numberOfDay = j;
		}
		
	}
}