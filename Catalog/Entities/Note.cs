using System;

namespace Catalog.Entities
{
    public record Note
    {
        public Guid Id {get; init;}
        public string Content {get; init;} = string.Empty;
        public DateTimeOffset CreatedDate{get; init;}
    }
}