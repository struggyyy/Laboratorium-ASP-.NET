using Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Models.Contact
{
    public interface IContactService
    {
        int Add(Contact contact);
        Contact? FindById(int id);
        List<Contact> FindAll();
        void DeleteById(int id);
        void Update(Contact contact);
        List<OrganizationEntity> FindAllOrganizations();
    }
}
