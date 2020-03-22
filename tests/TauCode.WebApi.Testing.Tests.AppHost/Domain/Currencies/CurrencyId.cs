﻿using System;
using TauCode.Domain.Identities;

namespace TauCode.WebApi.Testing.Tests.AppHost.Domain.Currencies
{
    [Serializable]
    public class CurrencyId : IdBase
    {
        public CurrencyId()
        {
        }
        public CurrencyId(Guid id)
            : base(id)
        {
        }
        public CurrencyId(string id)
            : base(id)
        {
        }
    }
}
