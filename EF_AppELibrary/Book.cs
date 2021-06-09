using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_AppELibrary
{
    class Book
    {
        public int Id { get; set; }
        public string TitleBook { get; set; }
        public int ReleaseYearBook { get; set; }

        // Внешний ключ
        public int WriterId { get; set; }
        // Навигационное свойство
        public Writer Writer { get; set; }

        // Внешний ключ
        public int SortBookId { get; set; }
        // Навигационное свойство
        public SortBook SortBook { get; set; }


    }
}
