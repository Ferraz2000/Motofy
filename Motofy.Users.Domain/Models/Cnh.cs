using Motofy.Common.Models;
using Motofy.Users.Domain.Enums;

namespace Motofy.Users.Domain.Models
{
    public class Cnh : Entity
    {
        public Cnh(Guid id) : base(id)
        {

        }

        public Cnh(Guid id, CnhEnum type, string cnpj, byte[] image) : base(id)
        {
            Type = type;
            Cnpj = cnpj;
            Image = image;
        }

        public CnhEnum Type { get; private set; }
        public string Cnpj { get; private set; }
        public byte[] Image { get; private set; }

        public static Cnh Create(CnhEnum type, string cnpj, byte[] image)
        {
            return new Cnh(id: Guid.NewGuid(), type, cnpj, image);
        }

        //TODO: fazer update

    }
}
