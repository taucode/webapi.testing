﻿using System;
using TauCode.Mq.Abstractions;

namespace TauCode.WebApi.Testing.Tests.Client.Messages
{
    public class BidMessage : IMessage
    {
        public BidMessage()
        {
        }

        public BidMessage(string name, decimal price, string correlationId, DateTimeOffset createdAt)
        {
            this.Name = name;
            this.Price = price;
            this.CorrelationId = correlationId;
            this.CreatedAt = createdAt;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Topic { get; set; }
        public string CorrelationId { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
