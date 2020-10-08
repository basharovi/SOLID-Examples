using System;

namespace SingleResponsibilityPrinciple.Example2
{
    public class UserMapper : IMapper<User>
    {
        public User Map(object sourceModel)
        {
            var userVm = (UserViewModel)sourceModel;

            return new User()
            {
                Name = userVm.Name,
                Age = userVm.Age,
                PhotoPath = $"/wwwroot/Image-{Guid.NewGuid()}.jpg" // Used Dummy Data for simplicity
            };
        }
    }
}
