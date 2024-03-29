﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;
namespace Entities.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)

        {
            builder.HasData(new Book{
                Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                Name = "A Game of Thrones",
                Year = 1996
                },
            new Book{
                Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                Name = "The Hedge Knight",
                Year = 1998
                }
                            );
        }
    }
}
