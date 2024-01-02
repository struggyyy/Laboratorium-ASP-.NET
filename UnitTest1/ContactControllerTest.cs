using Lab3.Controllers;
using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactControllerTest
{
    public class ContactControllerTest
    {
        private ContactController _controller;
        private IContactService _service;
        private CurrentDateTimeProvider _dateTimeProvider;

        public ContactControllerTest()
        {
            _dateTimeProvider = new CurrentDateTimeProvider();
            _service = new MemoryContactService(_dateTimeProvider);
            _service.Add(new Contact() { Name = "Test1" });
            _service.Add(new Contact() { Name = "Test2" });
            _controller = new ContactController(_service);
        }

        [Fact]
        public void IndexTest()
        {
            var result = _controller.Index();
            Assert.IsType<ViewResult>(result);

            var view = result as ViewResult;
            Assert.IsType<List<Contact>>(view.Model);
            List<Contact>? list = view.Model as List<Contact>;
            Assert.NotNull(list);
            Assert.Equal(2, list.Count);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void DetailsTestForExistingContacts(int id)
        {
            var result = _controller.Details(id);
            Assert.IsType<ViewResult>(result);

            var view = result as ViewResult;
            Assert.IsType<Contact>(view.Model);
            Contact? model = view.Model as Contact;
            Assert.NotNull(model);
            Assert.Equal(id, model.Id);
        }

        [Fact]
        public void DetailsTestForNonExistingContacts()
        {
            var result = _controller.Details(3);
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void CreateTest()
        {
            Contact model = new Contact() { Name = "test", Email = "test@test.test", Phone = "123456789" };
            var prevCount = _service.FindAll().Count;
            var result = _controller.Create(model);
            Assert.Equal(prevCount + 1, _service.FindAll().Count);
        }
    }
}