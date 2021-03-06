﻿using System;
using Webshop.Data;

namespace WebShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        WebshopDbContext Init();
    }
}