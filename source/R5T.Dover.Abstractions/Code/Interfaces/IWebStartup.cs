using System;

using Microsoft.AspNetCore.Builder;

using R5T.Richmond;


namespace R5T.Dover
{
    public interface IWebStartup : IStartup
    {
        void Configure(IApplicationBuilder applicationBuilder);
    }
}
