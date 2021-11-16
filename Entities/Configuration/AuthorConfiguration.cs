using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Entities.Configuration
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData
            (
            new Author
            {
                Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                Surname = "George Raymond Richard Martin",
                BookId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
            }
            );
        }
    }
}
