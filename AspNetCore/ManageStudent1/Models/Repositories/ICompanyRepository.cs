﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace ManageStudent1.Models.Repositories
{
    public interface ICompanyRepository<TEntity>
    {


        IEnumerable<TEntity>  GetList();
        TEntity Get(int cin);
        void Add(TEntity entity);
        TEntity Delete(int cin);
        TEntity Update(TEntity entityChanges);


    }
}
