using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactApplication.Data
{
    public class ContactService
    {
        private readonly ApplicationDbContext _db;

        public ContactService(ApplicationDbContext db)
        {
            _db = db;
        }

        // for CRUD operation

        //Get all contacts
        //public Contact[] GetContacts()
        public List<Contact> GetContacts()
        {
            var contList = _db.Contacts.ToList();
            //var contList = _db.Contacts.ToArray();
            return contList;
        }

        //Insert Contact info
        public string Create(Contact objContact)
        {
            _db.Contacts.Add(objContact);
            _db.SaveChanges();
            return "Saved Successfully";
        }

        //Get Contact by ID
        public Contact GetContactById(int id)
        {
            Contact contact = _db.Contacts.FirstOrDefault(s => s.Id == id);
            return contact;
        }

        //Update Contact
        public string UpdateContact(Contact objContact)
        {
            _db.Contacts.Update(objContact);
            _db.SaveChanges();
            return "Updated Successfully";
        }

        //Delete Contact
        public string DeleteContact(Contact objContact)
        {
            _db.Remove(objContact);
            _db.SaveChanges();
            return "Deleted Successfully";
        }
    }
}
