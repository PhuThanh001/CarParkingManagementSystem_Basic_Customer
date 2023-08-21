using DataObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookRepository : RepositoryBase<Book>
    {
        public IEnumerable<Book> GetAll()
        {
            return _dbSet.ToList();
        }

    }
}
