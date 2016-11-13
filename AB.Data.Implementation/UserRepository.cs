using AB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AB.Data.Implementation
{
    public class UserRepository : EntityBaseRepository<User>, IUserRepository
    {
        public UserRepository(ABContext context)
            : base(context)
        { }
    }
}
