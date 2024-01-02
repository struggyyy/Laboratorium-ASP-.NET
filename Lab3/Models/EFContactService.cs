﻿using Data;
using Data.Entities;
using System.Diagnostics.CodeAnalysis;
using System.Security.AccessControl;
using Lab3.Models;

namespace Lab3.Models

{
    public class EFContactService : IContactService
    {
        private readonly AppDbContext _context;

        public EFContactService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Contact model)
        {
            var e = _context.Contacts.Add(ContactMapper.ToEntity(model));
            _context.SaveChanges();
            return e.Entity.ContactId;
        }

        public void DeleteById(int id)
        {
            var find = _context.Contacts.Find(id);
            if (find is not null)
            {
                _context.Contacts.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<Contact> FindAll()
        {
            return _context
                .Contacts
                .Select(e => ContactMapper.FromEntity(e))
                .ToList();
        }

        public List<OrganizationEntity> FindAllOrganizations()
        {
            return _context.Organizations.ToList();
        }

        public PagingList<Contact> FindPage(int page, int size)
        {
            return PagingList<Contact>.Create(
                (p, s) => _context.Contacts
                    .OrderBy(c => c.Name)
                    .Skip((p - 1) * s)
                    .Take(s)
                    .Select(ContactMapper.FromEntity)
                    .ToList()
                , page, size, _context.Contacts.Count()
            );
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