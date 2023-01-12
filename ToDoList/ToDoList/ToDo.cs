using System;
namespace ToDoList
{
	public class ToDo
	{
        public int Id { get; set; }

        public string ActionToBeDone { get; set; }

        public DateTime ToGetDoneBy { get; set; }

        public string Status { get; set; }

        public void List()
        {
            Console.WriteLine($"{Id} - {ActionToBeDone}");
            Console.WriteLine($"Data:{ToGetDoneBy}");
            Console.WriteLine("\n");
        }

    }
}

