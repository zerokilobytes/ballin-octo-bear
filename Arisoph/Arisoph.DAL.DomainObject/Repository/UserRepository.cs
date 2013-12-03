using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using Arisoph.DAL.DomainObject.Domain;

namespace Arisoph.DAL.DomainObject
{
    public class UserRepository
    {
        public void Add(User newCharacter)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(newCharacter);
                    transaction.Commit();
                }
            }
        }

        public User GetUserName(string name)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var result = session.QueryOver<User>().Where(x => x.UserName == name).SingleOrDefault();
                return result ?? new User();
            }
        }

        public User GetUser(string name, string password)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var result = session.QueryOver<User>().Where(x => x.UserName == name && x.Password == password).SingleOrDefault();
                return result;
            }
        }

        public void Update(User newCharacter)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(newCharacter);
                    transaction.Commit();
                }
            }
        }

        public void Delete(User newCharacter)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(newCharacter);
                    transaction.Commit();
                }
            }
        }

    }
}