﻿using Festival.Data.Models;
using System.Collections.Generic;

namespace Festival.Data.Repositories
{
    public interface IAccommodationRepository
    {
        List<Accommodation> GetAll();
    }
}