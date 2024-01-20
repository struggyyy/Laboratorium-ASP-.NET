using Data;
using Lab3.Controllers;
using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Test1;

public class AlbumControllerTest
{
    private AlbumController _controller;
    private IAlbumService _albumService;
    private CurrentDateTimeProvider _dateTimeProvider;


    public AlbumControllerTest()
    {
        _dateTimeProvider = new CurrentDateTimeProvider();
        _albumService = new MemoryAlbumService(_dateTimeProvider);

        _albumService.Add(new Album() { Name = "Test1", Band = "Test1", PublicationDate = _dateTimeProvider.dateNow(),});
        _albumService.Add(new Album() { Name = "Test2", Band = "Test2", PublicationDate = _dateTimeProvider.dateNow(),});
        _albumService.Add(new Album() { Name = "Test3", Band = "Test3", PublicationDate = _dateTimeProvider.dateNow(),});
        _albumService.Add(new Album() { Name = "Test4", Band = "Test4", PublicationDate = _dateTimeProvider.dateNow(),});
        _albumService.Add(new Album() { Name = "Test5", Band = "Test5", PublicationDate = _dateTimeProvider.dateNow(),});

        _controller = new AlbumController(_albumService, _dateTimeProvider);

    }

    [Fact]
    public void Create()
    {
        Album model = new Album() { Name = "Test", Band = "Test", PublicationDate = _dateTimeProvider.dateNow(),};
        var prevCount = _albumService.FindAll().Count;
        var result = _controller.Create(model);
        Assert.IsType<RedirectToActionResult>(result);
        Assert.Equal(prevCount +1, _albumService.FindAll().Count());
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void UpdateForExisingAlbum(int id)
    {
        var post = _albumService.FindById(id);
        Assert.NotNull(post);
        post.Name = "Update";
        post.Band = "Update";
        _controller.Update(post);
        var updatedPost = _albumService.FindById(id);
        Assert.NotNull(updatedPost);
        Assert.Equal("Update", updatedPost.Name);
        Assert.Equal("Update", updatedPost.Band);
    }

    [Fact]
    public void UpdateForNonExisingAlbum()
    {
        Album newPost = new Album() { Id = 6, Name = "Test" };
        var result = _controller.Update(newPost);
        Assert.IsType<RedirectToActionResult>(result);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void DetailsForExisingAlbum(int id)
    {
        var result = _controller.Details(id);
        Assert.IsType<ViewResult>(result);
        var view = result as ViewResult;
        Assert.NotNull(view);
        Assert.IsType<Album>(view.Model);
        Album? model = view.Model as Album;
        Assert.NotNull(model);
        Assert.Equal(id, model.Id);
    }
    
    [Fact]
    public void DetailsForNonExisingAlbum()
    {
        var result = _controller.Details(6);
        Assert.IsType<NotFoundResult>(result);
    }
    
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void DeleteForExisingAlbum(int id)
    {
        var oldCount = _albumService.FindAll().Count;
        _ = _albumService.FindById(id);
        Assert.Equal(oldCount - 1, _albumService.FindAll().Count());
    }

    [Fact]
    public void DeleteForNonExisingAlbum()
    {
        int oldCount = _albumService.FindAll().Count;
        Album album = new Album() { Id = 1000, Name = "Album", Band = "Album" };
        _controller.Delete(album);
        Assert.Equal(oldCount, _albumService.FindAll().Count());
    }
}