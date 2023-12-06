using Lab3.Controllers;
using Lab3.Models;

namespace ContactControllerTest
{
    public class ContactControllerTest
    {
        private ContactController _controller;
        private IContactService _service;
        public ContactControllerTest()
        {
            _service = new MemoryContactService(new TimeProvider);
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
            List<Contact> list = view.Model as List<Contact>();
            Assert.NotNull(list);
            Assert.Equal(2, list.Count);
        }

        [Fact]
        [InlineData(1)]
        [InlineData(2)]
        public void DetailsTestForExistingContacts(int id)
        {
            var result = _controller.Details();
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            Assert.IsType<List<Contact>>(view.Model);
            List<Contact> list = view.Model as Contact;
            Assert.NotNull(model);
            Assert.Equal(id, Model.Id);
        }

        [Fact]
        public void DetailsTestForNonExistingContact()
        {
            var result = _controller.Details(3);
            Assert.IsType<NonFoundResult>(result);
        }

        [Fact]
        public void CreateTest()
        {
            Contact model = new Contact { Name = "Test", Email = "test@gmail.com", Phone = "123233232" };
            var prevCount = _service.FindAll().Count;
            var result = _controller.Create(model);
            Assert.Equal(prevCount + 1, _service.FindAll().Count);
        }
    }
}