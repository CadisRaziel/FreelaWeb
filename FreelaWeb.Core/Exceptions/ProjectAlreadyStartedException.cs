namespace FreelaWeb.Core.Exceptions
{
    public class ProjectAlreadyStartedException : Exception
    {
        public ProjectAlreadyStartedException()
            : base("Este projeto já foi iniciado")
        {

        }
    }
}
