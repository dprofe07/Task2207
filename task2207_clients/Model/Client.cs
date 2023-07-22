using System;
using System.Collections.Generic;

namespace task2207_clients.Model;

public partial class Client
{
    public int Id { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? SecondName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string FullName { get {
            return (LastName ?? "").Trim() + " " + (FirstName ?? "").Trim() + " " + (SecondName ?? "").Trim();
        } }
}
