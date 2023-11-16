﻿using Data.Entities;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Models
{
    public class EFContactService : IContactService
    {
        private readonly AppDbContext _context;

        public EFContactService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Contact contact)
        {
            var e = _context.Contacts.Add(ContactMapper.ToEntity(contact));
            _context.SaveChanges();
            return e.Entity.ContactId;
        }

        public void Delete(int id)
        {
            ContactEntity? find = _context.Contacts.Find(id);
            if (find != null)
            {
                _context.Contacts.Remove(find);
            }
        }

        public List<Contact> FindAll()
        {
            return _context.Contacts.Select(e => ContactMapper.FromEntity(e)).ToList();
        }

        public List<OrganizationEntity> FindAllOrganizations()
        {
            return _context.Organizations.ToList();
        }

        public Contact? FindById(int id)
        {
            var find = _context.Contacts.Find(id);
            return find is null ? null : ContactMapper.FromEntity(find);
        }

        public void Update(Contact model)
        {
            var entity = ContactMapper.ToEntity(model);
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
