using System;
using System.Collections.Generic;

namespace ToDoList
{
    public class ToDoItem
    {
        //Create a class to use within the todolist
        public string Text { get; set; }
        public bool IsCompleted { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a list to store the todo items
            List<ToDoItem> todoList = new List<ToDoItem>();

            //Loop menu till the user decides to exit
            bool exit = false;
            while(!exit)
            {
                Console.WriteLine("Welcome to My ToDoList");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Create a new todo item");
                Console.WriteLine("2. View all your todo items");
                Console.WriteLine("3. Delete a todo item");
                Console.WriteLine("4. Exit");
                //Read the users choice
                int choice = int.Parse(Console.ReadLine());

                //Use a switch statement to execute the appropriate action
                switch(choice)
                {
                    case 1:
                        //Create a new todo item
                        Console.WriteLine("Enter the text of the todo item");
                        string text = Console.ReadLine();
                        ToDoItem item = new ToDoItem { Text = text, IsCompleted = false };
                        todoList.Add(item);
                        break;
                    case 2:
                        //View all the todo items
                        Console.WriteLine("Here is everything in your todo list");
                        for(int i = 0; i < todoList.Count; i++)
                        {
                            ToDoItem currentItem = todoList[i];
                            Console.WriteLine($"{i + 1}. {currentItem.Text}");
                        }
                        break;
                    case 3:
                        //Delete an item from the list
                        Console.WriteLine("Please enter the number of the todo item you want to delete");
                        int index = int.Parse(Console.ReadLine()) - 1;
                        if(index >=0 && index < todoList.Count)
                        {
                            todoList.RemoveAt(index);
                            Console.WriteLine("Successfully deleted.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid index, please try again");
                        }
                        break;
                    case 4:
                        //Exit the menu
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}