﻿using DotNetCoreTemplate.Dapper.Interfaces;
using DotNetCoreTemplate.Dapper.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreTemplate.Repository.MsSql.Interface
{
    public interface IMsSqlGenericRepository<T> where T : class
    {
    }
}