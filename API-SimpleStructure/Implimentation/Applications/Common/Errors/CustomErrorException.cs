using Contracts.Custom;
using System.Net;


namespace Implimentation.Applications.Common.Errors
{
    public class CustomErrorException : Exception, IServiceException
    {
        HttpStatusCode IServiceException.StatusCode => HttpStatusCode.NonAuthoritativeInformation;
        string IServiceException.ErrorMessage => "Custom Error description";
    }

}

