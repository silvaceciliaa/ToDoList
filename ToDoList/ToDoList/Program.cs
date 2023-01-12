
using System;
using ToDoList;

Actions actions = new Actions();
bool loopMenu = true;

Console.WriteLine("Olá suas tarefas a serem feitas são:\n");
actions.ShowToDoList();

while (loopMenu)
{
    Console.WriteLine("\n(1)Adicionar nova tarefa (2)Marcar tarefa como feita (3)Mostrar todas tarefas (4)Mostrar tarefas a fazer (5)Mostrar tarefas feitas (6)Remover tarefa (7)Sair\n");
    var menuOption = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (menuOption)
    {
        case 1:
            actions.AddToDo();
            break;
        case 2:
            actions.MarkAsDone();
            break;
        case 3:
            actions.ShowWholeList();
            break;
        case 4:
            actions.ShowToDoList();
            break;
        case 5:
            actions.ShowDoneList();
            break;
        case 6:
            actions.Remove();
            break;
        case 7:
            loopMenu = false;
            break;
        default:
            Console.WriteLine("Ação não compreendida");
            break;
    }

}

