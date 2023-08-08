using System;
using System.Collections.Generic;

namespace Task2207.Model;

public partial class Client
{
    public int Id { get; set; }

    public string? LastName { get; set; }
    public string LastNameTrimmed { get { return (LastName ?? "").Trim(); } }

    public string? FirstName { get; set; } = null!;
    public string FirstNameTrimmed { get { return (FirstName ?? "").Trim(); } }

    public string? SecondName { get; set; } = null!;
    public string SecondNameTrimmed { get { return (SecondName ?? "").Trim(); } }

    public string? PhoneNumber { get; set; }
    public string PhoneNumberTrimmed { get { return (PhoneNumber ?? "").Trim(); } }

    public string? Email { get; set; }
    public string EmailTrimmed { get { return (Email ?? "").Trim(); } }

    public string FullName {
        get {
            return LastNameTrimmed + " " + FirstNameTrimmed + " " + SecondNameTrimmed;
        }
    }
}
