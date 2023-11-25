using Data.Entities;

namespace Lab3.Models.Album
{
    public class AlbumMapper
    {
        public static Album FromEntity(AlbumEntity entity)
        {
            return new Album()
            {
                Id = entity.AlbumId,
                Name = entity.Name,
                Band = entity.Band,
                TrackList = entity.TrackList,
                Record = entity.Record,
                ReleaseDate = entity.ReleaseDate,
                Duration = entity.Duration,
            };
        }

        public static AlbumEntity ToEntity(Album model)
        {
            return new AlbumEntity()
            {
                AlbumId = model.Id,
                Name = model.Name,
                Band = model.Band,
                TrackList = model.TrackList,
                Record = model.Record,
                ReleaseDate = model.ReleaseDate,
                Duration = model.Duration,
            };
        }
    }
}
