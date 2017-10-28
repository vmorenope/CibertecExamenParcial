using Examen.Models;
using Microsoft.IdentityModel.Tokens;
using System;


namespace Examen.WebApi.Authentication
{
    public interface ITokenProvider
    {
        string CreateToken(User user, DateTime Expiry);
        TokenValidationParameters GetValidationParameters();
    }
}
