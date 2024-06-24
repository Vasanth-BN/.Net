namespace CarSpecs.Services.Auth
{
    public interface IAuthService
    {
        Task<string> Authenticate(string username, string password);
    }
}
