using BusinessLayer;
using EntityLayer.Entities;

namespace ProjectWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            WriterManager wm = new WriterManager();
            BooksManager bm = new BooksManager();
            /*foreach (var item in wm.GetAll())
            {
                Console.WriteLine("Yazar İsmi: {0}", item.WriterName);
            }
            Console.ReadKey();*/
            /*Books book = new Books();
            book.BookName = "Mai ve Siyah";
            book.BookPage = 400;
            book.WriterID = 1;
            bm.BLAdd(book);*/
            /*bm.BlDell(2);*/
            /*Books book = new Books();
            book.BookID = 8;
            book.BookName = "Aşk-ı Memnu";
            book.BookPage = 450;
            book.WriterID = 1;
            bm.BlUpdate(book);*/
            /*
            foreach (var item in bm.GetByName("Aşk-ı Memnu"))
            {
   
                int writerId = item.WriterID;
                foreach (var item2 in wm.GetByID(writerId))
                {
                    Console.WriteLine(item2.WriterName);
                }
            }
            Console.ReadKey();*/
        }
    }
}