﻿using Incubadora.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incubadora.Business.Interface
{
    public interface IAspNetUsersBusiness
    {
        List<AspNetUsersDomainModel> GetUsers();
    }
}
