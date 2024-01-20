using Data.Entities;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Lab3.Models
{
    public class EFAlbumService : IAlbumService
    {
        private AppDbContext _context;

        public EFAlbumService(AppDbContext context)
        {
            _context = context;
        }

        public PagingList<Album> FindPage(int page, int size, List<Album> posts)
        {
            return PagingList<Album>.Create(
                (p, s) => posts.OrderBy(c => c.PublicationDate).Skip((p - 1) * s).Take(s)
                , page, size, posts.Count()
            );
        }

        public int Add(Album album)
        {
            var e = _context.Albums.Add(AlbumMapper.ToEntity(album));
            _context.SaveChanges();
            return e.Entity.AlbumId;
        }

        public void Delete(int id)
        {
            AlbumEntity? find = _context.Albums.Find(id);
            if (find != null)
            {
                _context.Albums.Remove(find);
            }
        }

        public List<Album> FindAll()
        {
            return _context.Albums.Select(e => AlbumMapper.FromEntity(e)).ToList(); ;
        }

        public Album? FindById(int id)
        {
            return AlbumMapper.FromEntity(_context.Albums.Find(id));
        }

        public void Update(Album album)
        {
            _context.Albums.Update(AlbumMapper.ToEntity(album));
        }
    }
}
