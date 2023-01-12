using System;

namespace ToDoList
{
	public class Actions : Functions
	{
        public void ShowToDoList()
        {
            if (ToDos.Any())
            {
                var checkStatus = ToDos.Where(x => x.Status == "A fazer");

                if (checkStatus != null && checkStatus.Any())
                {
                    foreach (var item in checkStatus)
                    {
                        item.List();
                    }
                }
                else
                {
                    Console.WriteLine("Nenhuma tarefa a ser feita");
                }

            }
            else
            {
                Console.WriteLine("Não há tarefas ainda");
            }
        }

        public void AddToDo()
        {
            var toDo = new ToDo();
            var validator = new Validators();

            Console.WriteLine("Tarefa: ");
            toDo.ActionToBeDone = Console.ReadLine();
            validator.InputaActionToBeDoneValidator(toDo);

            Console.WriteLine("Fazer até: ");
            validator.InputToGetDoneByValidator(toDo);

            var lastToDo = ToDos.LastOrDefault();
            toDo.Id = lastToDo is null ? 1 : lastToDo.Id + 1;
            toDo.Status = "A fazer";

            Console.Clear();
            ToDos.Add(toDo);
            Console.WriteLine("Tarefa adicionada!");
        }

        public void MarkAsDone()
        {
            if(ToDos.Any())
            {
                var checkStatus = ToDos.Where(x => x.Status == "A fazer");

                if(checkStatus != null && checkStatus.Any())
                {
                    Console.WriteLine("Digite o número da tarefa que deseja concluir");
                    int taskToBeMarked = Convert.ToInt32(Console.ReadLine());
                    var doneTask = ToDos.Where(x => x.Id == taskToBeMarked && x.Status == "A fazer");
                    Console.Clear();

                    if(doneTask != null && doneTask.Any())
                    {
                        foreach(var item in doneTask)
                        {
                            item.Status = "Feito";
                        }
                        Console.WriteLine("Tarefa feita!");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhuma tarefa a ser feita");
                }
            }
            else
            {
                Console.WriteLine("Não há tarefas ainda");
            }
        }

        public void ShowWholeList()
        {
            if(ToDos.Any())
            {
               foreach(var item in ToDos)
                {
                    item.List();
                }
            }
            else
            {
                Console.WriteLine("Não há tarefas ainda");
            }
        }

        public void ShowDoneList()
        {
            if (ToDos.Any())
            {
                var checkStatus = ToDos.Where(x => x.Status == "Feito");

                if (checkStatus != null && checkStatus.Any())
                {
                    foreach (var item in checkStatus)
                    {
                        item.List();
                    }
                }
                else
                {
                    Console.WriteLine("Nenhuma tarefa foi feita");
                }

            }
            else
            {
                Console.WriteLine("Não há tarefas ainda");
            }
        }

        public void Remove()
        {
            if (ToDos.Any())
            {
                Console.WriteLine("Digite o número da tarefa que deseja excluir");
                int taskToBeDeleted = int.Parse(Console.ReadLine());
                Console.Clear();

                var checkTask = ToDos.Where(x => x.Id == taskToBeDeleted);
                if(checkTask != null && checkTask.Any())
                {
                    foreach(var item in checkTask)
                    {
                        ToDos.Remove(item);
                        break;
                    }
                    Console.WriteLine("Tarefa excluida com sucesso!");
                }
                else
                {
                    Console.WriteLine("Tarefa não encontrada");
                }

            }
            else
            {
                Console.WriteLine("Não há tarefas ainda");
            }
        }
    }
}

