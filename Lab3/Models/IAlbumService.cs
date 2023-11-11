using Microsoft.AspNetCore.Mvc;

namespace Lab3.Models
{
    public interface IAlbumService
    {
        int Add(Album album);
        Album? FindById(int id);
        List<Album> FindAll();
        void Delete(int id);
        void Update(Album album);
    }
}
