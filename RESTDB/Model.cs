using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class Deceased
{
	public int ClientID { get; set; }
	public required string FirstName { get; set; }
	public required string LastName { get; set; }
	public string MiddleName { get; set; }
	public required DateTime DoD { get; set; }

}
