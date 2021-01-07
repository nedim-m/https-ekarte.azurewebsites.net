﻿using eKarte.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace eKarte.DataAccess.Data.Repository.IRepository
{
    public interface IGradRepository : IRepository<Grad>
    {
        IEnumerable<SelectListItem> GetListForDropdown();
        void Update(Grad grad);
    }
}
