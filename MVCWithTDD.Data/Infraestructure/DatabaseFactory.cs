using System;
using MVCWithTDD.Data;
using MVCWithTDD.Data.Infraestructure.Interfaces;

namespace MVCWithTDD.Data.Infraestructure
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
