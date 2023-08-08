using System;
using System.Collections.Generic;

namespace Task2207.Model;

public partial class Agent
{
    public int Id { get; set; }

    public string LastName { get; set; } = null!;
    public string LastNameTrimmed { get { return LastName.Trim(); } }

    public string FirstName { get; set; } = null!;
    public string FirstNameTrimmed { get { return FirstName.Trim(); } }

    public string SecondName { get; set; } = null!;
    public string SecondNameTrimmed { get { return SecondName.Trim(); } }

    public byte? DealShare { get; set; }

    public string FullName {
        get {
            return (LastNameTrimmed ?? "") + " " + (FirstNameTrimmed ?? "") + " " + (SecondNameTrimmed ?? "");
        }
    }
}
