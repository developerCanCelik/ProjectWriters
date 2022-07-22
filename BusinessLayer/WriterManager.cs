using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class WriterManager
    {
        Repository<Writer> writerRepo = new Repository<Writer>();
        public List<Writer> GetAll()
        {
            return writerRepo.List();
        }
        public List<Writer> GetByID(int p)
        {
            Writer Wr = writerRepo.Find(x => x.WriterID == p);
            return writerRepo.List(x => x.WriterID == Wr.WriterID);
        }

    }
}
