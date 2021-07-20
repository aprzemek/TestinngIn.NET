namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }
        /// <summary>
        /// Rezerwacja
        /// może zostać odwołana jedynie przez admina i osobę która ją złożyła
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool CanBeCancelledBy(User user)
        {
            return (user.IsAdmin || MadeBy == user);
        }
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}