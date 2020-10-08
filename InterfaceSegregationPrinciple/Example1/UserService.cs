namespace InterfaceSegregationPrinciple.Example1
{
    public class UserService : IUserService
    {
        public void AddUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
