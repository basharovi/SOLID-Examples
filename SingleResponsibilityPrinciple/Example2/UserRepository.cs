namespace SingleResponsibilityPrinciple.Example2
{
    public class UserRepository
    {
        public bool Add(User user)
        {
            // Suppose Added To Database
            return user != null;
        }
    }
}
