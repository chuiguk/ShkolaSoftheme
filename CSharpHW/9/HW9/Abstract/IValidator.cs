using System.Collections.Generic;

namespace HW9.Abstract
{
    interface IValidator
    {
        bool ValidateUser(IUser user, IEnumerable<IUser> _users);
    }
}
