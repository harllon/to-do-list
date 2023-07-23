using System;
namespace toDoList.Models
{
	public class Tasks
	{
        public int Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public bool IsDone { get; set; }

        public Tasks()
		{

		}
	}
}

