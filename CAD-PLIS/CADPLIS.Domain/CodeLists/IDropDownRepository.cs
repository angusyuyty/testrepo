﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.CodeLists
{
    public interface IDropDownRepository
    {
        Task<List<DropDownList>> GetListByType(string type);
    }
}
