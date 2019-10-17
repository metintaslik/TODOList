using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO_DAL;

namespace TODO_BL
{
    public class ToDoProcess
    {
        #region Definitions
        // Yapılacakları listelemek için
        private readonly List<ToDo> _toDoList;
        #endregion

        /// <summary>
        /// Yapıcı method ile kullanacağımız fieldleri tanımlamak için classlardan referans alıyoruz.
        /// </summary>
        public ToDoProcess()
        {
            _toDoList = new List<ToDo>();
        }

        public 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="to_Do">Parametre olarak ToDo class tipi</param>
        /// <returns></returns>
        public bool ToDoAdd(ToDo to_Do)
        {
            try
            {

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
