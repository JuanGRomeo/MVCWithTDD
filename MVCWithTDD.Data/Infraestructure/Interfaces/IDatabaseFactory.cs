using MVCWithTDD.Data;
using System;

namespace EnjoyMyTown.Data.Infraestructure.Interfaces
{
    public interface IDatabaseFactory : IDisposable
    {
        MVCWithTDDContext Get();
    }
}
