namespace Motofy.Users.Domain.Models.User
{
    public record Cnpj
    {
        public string Value { get; init; }

        private Cnpj()
        {

        }

        public static Cnpj Create(string cnpj)
        {
            string cleanedCnpj = new string(cnpj.Where(char.IsDigit).ToArray());

            if (cleanedCnpj.Length != 14)
            {
                throw new ApplicationException("CNPJ must contain exactly 14 numeric digits.");
            }

            if (!IsCnpjValid(cleanedCnpj))
            {
                throw new ApplicationException("Invalid CNPJ.");
            }
            return new Cnpj { Value = cleanedCnpj };
        }

        private static bool IsCnpjValid(string cnpj)
        {
            int[] multiplier1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplier2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < 12; i++)
            {
                sum1 += int.Parse(cnpj[i].ToString()) * multiplier1[i];
                sum2 += int.Parse(cnpj[i].ToString()) * multiplier2[i];
            }

            int digit1 = sum1 % 11 < 2 ? 0 : 11 - sum1 % 11;
            int digit2 = sum2 % 11 < 2 ? 0 : 11 - sum2 % 11;

            return digit1 == int.Parse(cnpj[12].ToString()) && digit2 == int.Parse(cnpj[13].ToString());
        }
    }
}
