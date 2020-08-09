using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Concrete;
using WizardSoftwareGroupsFramework.Core.Utilities.Security;
using WizardSoftwareGroupsFramework.Core.Utilities.Security.Hashing;
using WizardSoftwareGroupsFramework.Core.Utilities.Security.Jwt;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Business.Constants;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
        private IUserTitleService _userTitleService;
        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }
        public AuthManager(IUserService userService)
        {
            _userService = userService;
        }
        public AuthManager(IUserService userService, IUserTitleService userTitleService, bool form)
        {
            _userTitleService = userTitleService;
            _userService = userService;
        }
        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, "Access token created!");
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByUserName(userForLoginDto.UserName);
            if (userToCheck == null)
                return new ErrorDataResult<User>(UserMessages.UserNotFound);
            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
                return new ErrorDataResult<User>(UserMessages.PasswordError);
            return new SuccessDataResult<User>(userToCheck, UserMessages.SuccessfulLogin);
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto)
        {
            byte[] passwordSalt, passwordHash;
            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordHash, out passwordSalt);
            var user = new User
            {
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                UserName = userForRegisterDto.UserName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, "User is saved!");
        }

        public IResult UserExists(string userName)
        {
            if (_userService.GetByUserName(userName) != null)
                return new ErrorResult("This user is exists!");
            return new SuccessResult();
        }

        public IDataResult<User> CardLogin(UserTitle userTitle)
        {
            var user = _userTitleService.GetByCartPass(userTitle.CartPass).Data;

            if (user != null)
            {
                return new SuccessDataResult<User>(_userService.GetByID(user.UserID).Data, UserMessages.SuccessfulLogin);
            }
            else
            {
                return new ErrorDataResult<User>(UserMessages.PasswordError);
            }
        }
    }
}
