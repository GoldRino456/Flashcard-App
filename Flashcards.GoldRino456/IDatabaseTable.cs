using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards.GoldRino456
{
    internal interface IDatabaseTable<T>
    {
        public void CreateEntry(T newEntry);
        public T ReadEntry(int id);
        public void UpdateEntry(int id, T updatedEntry);
        public void DeleteEntry(int id);
        public List<T> ReadAllEntries();
    }
}
