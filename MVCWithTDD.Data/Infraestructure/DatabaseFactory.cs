using System;
using EnjoyMyTown.Data.Infraestructure.Interfaces;
using MVCWithTDD.Data;

namespace EnjoyMyTown.Data.Infraestructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private MVCWithTDDContext dataContext;

        public MVCWithTDDContext Get()
        {
            return dataContext ?? (dataContext = new MVCWithTDDContext());
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
