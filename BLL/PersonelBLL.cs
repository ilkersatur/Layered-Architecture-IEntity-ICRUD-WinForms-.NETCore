using Model;
using DAL;
namespace BLL
{
    public class PersonelBLL
    {
        PersonelDAL dal;
        public PersonelBLL()
        {
            dal = new PersonelDAL();
        }
    }
}