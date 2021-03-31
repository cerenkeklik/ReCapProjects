﻿using Core.Entities.Concrete;
using Core.Utilities;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string Email);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int Id);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
