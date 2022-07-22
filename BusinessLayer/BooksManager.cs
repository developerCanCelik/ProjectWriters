using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BooksManager
    {
        Repository<Books> bookRepo = new Repository<Books>();
        public int BLAdd(Books p)
        {
            if (p.BookName.Length <= 5)
            {
                return -1;
            }
            return bookRepo.Insert(p);
        }
        public int BlDell(int p)
        {
            if (p != 0)
            {
                Books b = bookRepo.Find(x => x.BookID == p);
                return bookRepo.Delete(b);
            }else
            {
                return -1;
            }
        }
        public int BlUpdate(Books p)
        {
            if (p.BookName == "" || p.BookName.Length <= 3)
            {
                return -1;
            }
            Books books = bookRepo.Find(x => x.BookID == p.BookID);
            books.BookName = p.BookName;
            books.BookPage = p.BookPage;
            books.WriterID = p.WriterID;
            return bookRepo.Update(books);
        }
        public List<Books> GetByName(string p)
        {
            return bookRepo.List(x => x.BookName == p);
        }
    }
}
