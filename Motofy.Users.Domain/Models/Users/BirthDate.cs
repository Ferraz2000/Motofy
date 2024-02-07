namespace Motofy.Users.Domain.Models.User
{
    public record BirthDate
    {
        private BirthDate()
        {

        }
       

        public DateOnly Date { get; init; }

        public static BirthDate Create(DateOnly dateOnly)
        {
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.UtcNow);

            int age = currentDate.Year - dateOnly.Year;

            if (currentDate.DayNumber < dateOnly.DayNumber)
            {
                age--;
            }

            if (age >= 18)
            {
                return new BirthDate
                {
                    Date = dateOnly
                };
            }
            else
            {
                throw new ApplicationException("User must be has more than 18 years.");
            }
        }

    }

}