using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_DAL
{
    public interface IToDo
    {
        object GetAllToDo();
        string AddToDo(ToDo to_Do);
        string UpdateToDo(ToDo to_Do);
        string DeleteToDo(int id);
        ToDo ToDoFindById(int id);
        List<ToDo> Alert();
    }
}
