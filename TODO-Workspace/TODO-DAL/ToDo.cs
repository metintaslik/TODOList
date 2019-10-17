using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_DAL
{
    public class ToDo
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime AddedDate { get; }
        public DateTime ToDoDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}