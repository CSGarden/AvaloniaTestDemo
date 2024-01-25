using System.Collections.Generic;
using ToDoList.DataModel;

namespace ToDoList.Services {

    public class ToDoListService {

        public IEnumerable<ToDoItem> GetItems() => new[]
        {
            new ToDoItem { Description = "遛狗" },
            new ToDoItem { Description = "买些牛奶" },
            new ToDoItem { Description = "学习阿瓦罗尼亚", IsChecked = true },
            new ToDoItem { Description = "怎么还不显示" },
        };
    }
}