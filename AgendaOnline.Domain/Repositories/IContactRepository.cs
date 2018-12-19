﻿using AgendaOnline.Domain.Entities;
using AgendaOnline.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaOnline.Domain.Repositories
{
    public interface IContactRepository
    {
        Contact GetByName(Name name);
    }
}