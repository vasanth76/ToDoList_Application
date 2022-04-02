using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ToDoApp
{
    public class TodoListViewModel
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }
        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();

            TodoItems.Add(new TodoItem("Fight club", "download and watch it", false));
            TodoItems.Add(new TodoItem("Avengers", "download and watch the movie", false));
            TodoItems.Add(new TodoItem("Euphoria", "Download and watch the series", false));
        }
        public ICommand AddTodoCommand => new Command(AddTodoItem);
        public string NewTodoTitleValue { get; set; }
        public string NewTodoDesValue { get; set; }
        void AddTodoItem()
        {
            TodoItems.Add(new TodoItem(NewTodoTitleValue, NewTodoDesValue, false));
        }

        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
        public string RemoveTodoTitleValue { get; set; }
        void RemoveTodoItem(object o)
        {
            TodoItem todoItemBeingRemoved = o as TodoItem;
            TodoItems.Remove(todoItemBeingRemoved);
        }

        public ICommand EditTodoCommand => new Command(EditTodoItem);
        public String EditTodoTitleValue { get; set; }
        void EditTodoItem(object o)
        {
            TodoItem todoItemBeingEdited = o as TodoItem;
            string title = o.ToString();
            Console.WriteLine(title);
        }
    }
}