using MVCWithTDD.Data;
using System;

namespace MVCWithTDD.Data.Infraestructure.Interfaces
{
    public interface IDatabaseFactory : IDisposable
    {
        MVCWithTDDContext Get();
    }
}
