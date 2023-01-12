using System;

namespace ToDoList
{
    public class Validators
    {
        public void InputaActionToBeDoneValidator(ToDo toDo)
        {
            while (toDo.ActionToBeDone == "")
            {
                Console.WriteLine("Campo obrigatório");
                Console.WriteLine("Tarefa: ");
                toDo.ActionToBeDone = Console.ReadLine();
            }
        }

        public void InputToGetDoneByValidator(ToDo toDo)
        {
            var date = Console.ReadLine();
            var convert = DateTime.TryParse(date, out var result);

            if (!convert)
            {
                toDo.ToGetDoneBy = DateTime.Today;
            }
            else
            {
                convert = DateTime.TryParse(date, out result);
                toDo.ToGetDoneBy = result;
            }
        }
    }
}

