using System;
using CefSharp;

namespace CefSharpSample
{
    public class CustomSchemeHandlerfactory : ISchemeHandlerFactory
    {
        public IResourceHandler Create(IBrowser browser, IFrame frame, string schemeName, IRequest request)
        {
            if (schemeName == "local")
                return new LocalFileResourceHandler();

            throw new Exception($"Requested scheme '{schemeName}' is not known.");
        }
    }
}
