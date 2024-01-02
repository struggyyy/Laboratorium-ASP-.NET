using Data.Entities;
using Lab3.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Lab3.Models
{
    public interface IContactService
    {
        int Add(Contact contact);
        Contact? FindById(int id);
        List<Contact> FindAll();
        void DeleteById(int id);
        void Update(Contact contact);
        List<OrganizationEntity> FindAllOrganizations();
        PagingList<Contact> FindPage(int page, int size);

    }
}
