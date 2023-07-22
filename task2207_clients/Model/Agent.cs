using System;
using System.Collections.Generic;

namespace task2207_clients.Model;

public partial class Agent
{
    public int Id { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string SecondName { get; set; } = null!;

    public byte? DealShare { get; set; }
}
