namespace Lab3.Models.Album;

public class MemoryAlbumService : IAlbumService
{
    private Dictionary<int, Album> _items = new Dictionary<int, Album>();

    private IDateTimeProvider _dateTimeProvider;

    public MemoryAlbumService(IDateTimeProvider dateTimeProvider)
    {
        _dateTimeProvider = dateTimeProvider;
    }

    public int Add(Album item)
    {
        int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
        item.Id = id + 1;
        item.PublicationDate = _dateTimeProvider.dateNow();
        _items.Add(item.Id, item);
        return item.Id;
    }

    public void Delete(int id)
    {
        _items.Remove(id);
    }

    public List<Album> FindAll()
    {
        return _items.Values.ToList();
    }

    public Album? FindById(int id)
    {
        return _items[id];
    }

    public void Update(Album item)
    {
        item.PublicationDate = _items[item.Id].PublicationDate;
        _items[item.Id] = item;
    }
}
