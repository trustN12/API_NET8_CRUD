using System.ComponentModel.DataAnnotations;

namespace DOT_API_CRUD.Models;

public class Teacher
{
    [Key]
    public int TID { get; set; }

    public string Fname { get; set; }

    public string Lname { get; set; }

    public DateTime DOJ { get; set; }

    public string Subject { get; set; }

    public int Salary { get; set; }
}