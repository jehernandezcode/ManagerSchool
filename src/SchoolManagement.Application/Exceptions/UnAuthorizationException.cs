namespace ManagerSchool.Exceptions
{
    public class UnAuthorizationException : Exception

    {
        public UnAuthorizationException(string message) : base(message)
        {
        }
    }
}
