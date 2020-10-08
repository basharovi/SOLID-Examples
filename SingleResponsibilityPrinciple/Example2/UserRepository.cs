namespace SingleResponsibilityPrinciple.Example2
{
    class UserRepository
    {
        public bool Add(User user)
        {
            // Suppose Added To Database
            return user != null;
        }
    }
}
