﻿using System;

namespace CrystalSharpEventStorePostgreSqlIntegrationExample.Api.Dto
{
    public class ChangeProductInfoRequest
    {
        public Guid GlobalUId { get; set; }
        public string Sku { get; set; }
        public decimal Price { get; set; }
    }
}
