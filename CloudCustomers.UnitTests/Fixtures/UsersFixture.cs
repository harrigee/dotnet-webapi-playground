using System;
using System.Collections.Generic;
using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() =>
            new()
            {
                new User
                {
                    Id = 1,
                    Name = "Test User 1",
                    Address = new Address()
                    {
                        Street = "123 Main St",
                        City = "Madison",
                        ZipCode = "34567"
                    },
                    Email = "testuser1@example.com"
                },
                new User
                {
                    Id = 2,
                    Name = "Test User 2",
                    Address = new Address()
                    {
                        Street = "456 Main St",
                        City = "Square",
                        ZipCode = "23456"
                    },
                    Email = "testuser2@example.com"
                },
                new User
                {
                    Id = 3,
                    Name = "Test User 3",
                    Address = new Address()
                    {
                        Street = "789 Main St",
                        City = "Gardne",
                        ZipCode = "12345"
                    },
                    Email = "testuser3@example.com"
                }
            };
    }
}

