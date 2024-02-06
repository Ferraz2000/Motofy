using Motofy.Common.Models;
using Motofy.Users.Domain.Enums;

namespace Motofy.Users.Domain.Models
{
    public class User : Entity
    {
        public User(Guid id) : base(id)
        {

        }
        public User(Guid id, Name name, Cnpj cnpj, BirthDate birthDate, Guid idCnh, Cnh cnh, Email email) : base(id)
        {
            Name = name;
            Cnpj = cnpj;
            BirthDate = birthDate;
            IdCnh = idCnh;
            Cnh = cnh;
            Email = email;
        }

        public User(Guid id, Email email, Name name, Cnpj cnpj, BirthDate birthDate) : base(id)
        {
            Name = name;
            Cnpj = cnpj;
            BirthDate = birthDate;
            Email = email;
        }
        public Name Name { get; private set; }
        public Cnpj Cnpj { get; private set; }
        public BirthDate BirthDate { get; private set; }
        public Guid IdCnh { get; private set; }
        public Cnh Cnh { get; private set; }
        public UserRole Role { get; private set; }//TODO: ver depois
        public Email Email { get; private set; }
        //TODO: soft delete


        public static User CreateUser(Email email, Name name, Cnpj cnpj, BirthDate birthDate)
        {
            var user = new User(id: Guid.NewGuid(), email: email, name: name, cnpj: cnpj, birthDate: birthDate);

            return user;
        }

        public static User CreateDelivery(Name name, Cnpj cnpj, BirthDate birthDate, Guid idCnh, Cnh cnh, Email email)
        {
            return new User(id: Guid.NewGuid(), name, cnpj, birthDate, idCnh, cnh, email);
        }

        //TODO: UPDATE
    }
}
