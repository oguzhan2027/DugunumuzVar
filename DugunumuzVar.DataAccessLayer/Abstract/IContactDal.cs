using DugunumuzVar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DugunumuzVar.DataAccessLayer.Abstract
{
    public interface IContactDal:IGenericDal<Contact>
    {
        List<Contact> GetContactBySubjectWithTesekkur();
    }
}
