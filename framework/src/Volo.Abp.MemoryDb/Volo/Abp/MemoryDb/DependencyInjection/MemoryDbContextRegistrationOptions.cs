using System;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.MemoryDb.DependencyInjection
{
    public class MemoryDbContextRegistrationOptions : AbpCommonDbContextRegistrationOptions, IMemoryDbContextRegistrationOptionsBuilder
    {
        public MemoryDbContextRegistrationOptions(Type originalDbContextType, IServiceCollection services) 
            : base(originalDbContextType, services)
        {
        }
    }
}