using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Lab3.Models
{
    public interface IAlbumService
    {
        int Add(Album model);
        Album? FindById(int id);
        List<Album> FindAll();
        void Delete(int id);
        void Update(Album model);
        List<OrganizationEntity> FindAllOrganizations();
        PagingList<Album> FindPage(int page, int size);
    }
}
