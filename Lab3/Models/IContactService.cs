using Microsoft.AspNetCore.Mvc;

namespace Lab3.Models
{
    public interface IContactService
    {
        int Add(Contact Name);
        void Delete(int id);
        void Update(Contact Name);
        List<Contact> FindAll();
        Contact? FindById(int id);
    }
}
