using EonixEF;
using EonixEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EonixAPI.Services
{
    public class PersonneService
    {
        private readonly PersonneContext _context;

        public PersonneService(PersonneContext context)
        {
            _context = context;
        }
        //récupérer toutes les personnes
        public IEnumerable<Personnes> GetAllPersonnes()
        {
            return _context.Personnes.ToList().Select(i => new Personnes
            {
                Id = i.Id,
                Name = i.Name,
                FirstName = i.FirstName
            });
        }
        //récupérer une personne par son ID
        public Personnes GetPersonneById(int id)
        {
            Personnes i = _context.Personnes.Find(id);
            return new Personnes
            {
                Id = i.Id,
                Name = i.Name,
                FirstName = i.FirstName
            };
        }
        // récupérer une ou plusieurs personnes selon le prénom
        public IEnumerable<Personnes> GetByFirstName(string firstname)
        {
            return _context.Personnes.ToList().Select(i => new Personnes
            {
                Id = i.Id,
                Name = i.Name,
                FirstName = i.FirstName
                //permet de récupérer le prénom selon la saisie
            }).Where(i => i.FirstName.Contains(firstname.Substring(0, 1).ToUpper() + firstname.Substring(1).ToLower()) || i.FirstName.Contains(firstname.ToLower()));

        }
        // récupérer une ou plusieurs personnes selon le nom
        public IEnumerable<Personnes> GetByName(string name)
        {
            return _context.Personnes.ToList().Select(i => new Personnes
            {
                Id = i.Id,
                Name = i.Name,
                FirstName = i.FirstName
            }).Where(i => i.Name.Contains(name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower()) || i.Name.Contains(name.ToLower()));

        }
        //ajout d'une personne
        public void AddPersonne(Personnes personne)
        {
            _context.Add(new Personnes
            {
                Id = personne.Id,
                Name = personne.Name.Substring(0, 1).ToUpper() + personne.Name.Substring(1).ToLower(),
                FirstName = personne.FirstName.Substring(0,1).ToUpper() + personne.FirstName.Substring(1).ToLower()
            });

            _context.SaveChanges();
        }
        //mise à jour d'une personne
        public void UpdatePersonne(Personnes personne)
        {
            Personnes p = _context.Personnes.Find(personne.Id);

            p.Id = personne.Id;
            p.Name = personne.Name.Substring(0, 1).ToUpper() + personne.Name.Substring(1).ToLower();
            p.FirstName = personne.FirstName.Substring(0, 1).ToUpper() + personne.FirstName.Substring(1).ToLower();
            _context.SaveChanges();
        }
        //suppresion d'une personne
        public void DeletePersonne(int id)
        {
            Personnes p = _context.Personnes.Find(id);
            _context.Remove(p);
            _context.SaveChanges();
        }
    }
}
