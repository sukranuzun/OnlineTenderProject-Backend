using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        public AuthManager(IUserService userService)
        {
            _userService = userService;
        }
        public Core.Utilities.Results.IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            throw new NotImplementedException();
        }

        public Core.Utilities.Results.IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            if (_userService.GetByMail(email).Data != null)
            {
                return new ErrorResult(Messages.UserExists);
            }
            return new SuccessResult();
        }

        public IResult UserExists(string email)
        {
            throw new NotImplementedException();
        }

        object IAuthService.Login(UserForLoginDto userForLoginDto)
        {
            throw new NotImplementedException();
        }
    }
}
