﻿using OtoServisSatis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Data.Abstract
{
    public interface ICarRepository:IRepository<Arac>
    {
        Task<List<Arac>> GetCustomCarList();//Araç listesi döndürüyor
        Task<List<Arac>> GetCustomCarList(Expression<Func<Arac,bool>> expression);
        Task<Arac> GetCustomCar(int id);//Bir tane Araç kaydını döndürüyor
    }
}
