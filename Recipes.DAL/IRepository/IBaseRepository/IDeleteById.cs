﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.DAL.IRepository.IBaseRepository
{
    public interface IDeleteById<TKey>
    {
        int Delete(TKey id);
    }
}