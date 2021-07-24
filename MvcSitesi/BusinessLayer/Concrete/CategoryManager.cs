using DataAccsessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAllBl()
        {
            return repo.List();
        }

        public void CategoryAddBl(Category p)
        {
            if(p.CategoryName=="" || p.CategoryName.Length<=3 || p.CategoryName.Length>=51 || p.CategoryDescription == "")
            {
                //Hata Mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
            
    }
}
