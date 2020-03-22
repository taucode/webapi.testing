﻿using System.Collections.Generic;

namespace TauCode.WebApi.Testing.Tests.AppHost.Domain.Currencies
{
    public interface ICurrencyRepository
    {
        Currency GetById(CurrencyId id);
        Currency GetByCode(string code);
        IList<Currency> GetAll();
        void Save(Currency currency);
        bool Delete(CurrencyId id);
    }
}
