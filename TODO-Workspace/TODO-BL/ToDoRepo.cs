using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO_DAL;

namespace TODO_BL
{
    public class ToDoRepo : IToDo
    {
        #region Definitions
        // TO DO: Yapılacaklar listesi için.
        private static List<ToDo> _toDoList = new List<ToDo>();
        // TO DO: id'leri tanımlamak için.
        private int _counter = 1;
        #endregion

        #region Methods
        /// <summary>
        /// Yapılacak eklemek için kullanılır. Ekleme başarılı ise "Başarıyla eklendi." geriye döner.
        /// <para>Daha önceden eklenmiş bir yapılacak eklendiyse "Başarısız, bu yapılacak daha önceden eklenmiş." hatası geriye döner.</para>
        /// <para>Hatalı bir durum ile karşılaşıldığında geriye hata mesajı döner.</para>
        /// </summary>
        /// <param name="to_Do">Listeye eklemek için ToDo referans tipli parametre</param>
        /// <returns></returns>
        public string AddToDo(ToDo to_Do)
        {
            try
            {
                if (!_toDoList.Any(x => x.Description != to_Do.Description && x.ToDoDate != to_Do.ToDoDate))
                {
                    to_Do.Id = _counter++;
                    to_Do.AddedDate = DateTime.Now.Date;
                    _toDoList.Add(to_Do);
                    return "Başarıyla eklendi.";
                }
                else
                    return "Başarısız, bu yapılacak daha önceden eklenmiş.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// Yapılacak silmek için DeleteToDo() methodu kullanılır. Silme başarılı ise "Başarıyla silindi." geriye döner.
        /// <para>Hatalı bir durum ile karşılaşıldığında geriye hata mesajı döner.</para>
        /// </summary>
        /// <param name="id">Silinmek istenen yapılacağın id'si</param>
        /// <returns></returns>
        public string DeleteToDo(int id)
        {
            try
            {
                _toDoList.Remove(_toDoList.Find(x=>x.Id == id));
                return "Başarıyla silindi.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// Tüm yapılacakları listelemek için kullanılır.
        /// <para>Hatalı bir durum ile karşılaşıldığında geriye hata mesajı döner.</para>
        /// </summary>
        /// <returns></returns>
        public object GetAllToDo()
        {
            try
            {
                return _toDoList.AsEnumerable();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// Güncellenicek yapılacak için kullanılır. Güncelleme başarılı ise "Başarıyla güncellendi." geriye döner.
        /// <para>Hatalı bir durum ile karşılaşıldığında geriye hata mesajı döner.</para>
        /// </summary>
        /// <param name="to_Do">Listede olan yapılacağı güncellemek için ToDo referans tipli parametre</param>
        /// <returns></returns>
        public string UpdateToDo(ToDo to_Do)
        {
            try
            {
                _toDoList.ForEach(x =>
                {
                    x.Description = to_Do.Description;
                    x.ModifiedDate = DateTime.Now.Date;
                    x.ToDoDate = to_Do.ToDoDate;
                });
                return "Başarıyla güncellendi.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ToDo ToDoFindById(int id)
        {
            try
            {
                return _toDoList.Find(x => x.Id == id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
