using System;
using toDoList.Models;
using toDoList.Data;


namespace toDoList.Controllers
{
	public class TasksController
	{
		protected readonly TasksContext _taskContext;

		public TasksController(TasksContext taskContext)
		{
			_taskContext = taskContext;
		}

		public void CreateTask()
		{

		}

		public void UpdateTask()
		{

		}

		public void DeleteTask()
		{

		}

		public void ReadTask()
		{

		}
	}
}

