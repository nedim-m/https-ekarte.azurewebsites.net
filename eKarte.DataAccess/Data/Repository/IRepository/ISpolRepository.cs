﻿using eKarte.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace eKarte.DataAccess.Data.Repository.IRepository
{
   public interface ISpolRepository:IRepository<Spol>
    {
        IEnumerable<SelectListItem> GetSpolListForDropDown();
    }
}
