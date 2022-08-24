using System;
using System.Collections.Generic;
using System.Text;
using Users.Data;

namespace Users.Services
{
    public interface IUsers
    {
        Users GetUser(int? Id);

    }
}
