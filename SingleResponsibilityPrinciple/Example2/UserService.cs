namespace SingleResponsibilityPrinciple.Example2
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        private readonly IMapper<User> _mapper;

        public UserService()
        {
            // We could use DI, but for simplicity I have skipped it.

            _userRepository = new UserRepository();
            _mapper = new UserMapper();
        }

        public bool AddUser(UserViewModel userVm)
        {
            var user = _mapper.Map(userVm);

            return _userRepository.Add(user);
        }
    }
}
