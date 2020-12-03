
namespace Patterns.Facade.Subsystem
{
    public class SecurityCodeCheck
    {
        private readonly int securityCode = 1234;

        public int GetSecurityCode() { return securityCode; }

        public bool IsSecurityCodeCorrect(int secCodeToCheck)
        {
            return secCodeToCheck == GetSecurityCode();
        }

    }
}
