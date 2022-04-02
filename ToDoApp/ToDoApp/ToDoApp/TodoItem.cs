using System;

namespace ToDoApp
{
    public class TodoItem
    {
        public string TodoTitle { get; set; }
        public string TodoDes { get; set; }
        public bool Complete { get; set; }
        public TodoItem(string TodoTitle, string TodoDes, bool Complete)
        {
            this.TodoTitle = TodoTitle;
            this.TodoDes = TodoDes;
            this.Complete = Complete;
        }
    }
}
