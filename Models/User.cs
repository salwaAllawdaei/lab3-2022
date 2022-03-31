
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3.Models;


public class User
{
    public int UserId { get; set; }
    public string? Name { get; set; }
    [RegularExpression(@"^[a-zA-Z0-9_.-]+@@[a-zA-Z0-9]+[a-zA-Z0-9.-]+[a-zA-Z0-9]+.[a-z]{0,4}$", ErrorMessage = "please enter the correct form of email example@aaaa.com")]

    public string? Email { get; set; }

    public int? StreetNumber { get; set; }
    public string? StreetName { get; set; }

    [RegularExpression(@"^[A-Za-z][0-9][A-Za-z][ ]*[0-9][A-Za-z][0-9]$", ErrorMessage = "Please enter postal code in A1A 1A1 format")]
    public string? PostalCode { get; set; }
    public string? City { get; set; }

    public string? Province { get; set; }
    public string? Phone { get; set; }

}