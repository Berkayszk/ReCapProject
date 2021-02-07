﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess

{
    //generic constraint
    //class = referans tip
    //IEntity= IEntity olabilir yada onu implamante eden bir nesne olabilir
    //new() new'lenebilir olmalı 
    public interface IEntityRepositoryBase<T> where T: class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool >>filter = null);
        T Get();
        void Add(T entity);
        void Update(T entity);

        void Delete(T entity);
        
    }
}
