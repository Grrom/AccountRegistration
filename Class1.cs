using System;


public delegate long DelegateNumber(long number);
public delegate long DelegateText(string text);

public class StudentInfoClass
{
	string FirstName = "";
	string LastName = "";
	string MiddleName = "";
	string Address = "";
	string Program = "";

	long Age = 0;
	long ContactNo = 0;
	long StudentNo = 0;

	public StudentInfoClass()
	{
	}

    public static string GetFirstName(string Firstname)
    {
		return Firstname;
    }
    public static string GetLastName(string Firstname)
    {
		return Firstname;
    }
    public static string GetMiddleName(string Firstname)
    {
		return Firstname;
    }
    public static string GetAddress(string Firstname)
    {
		return Firstname;
    }
    public static string GetProgram(string Firstname)
    {
		return Firstname;
    }
    public static string GetAge(string Firstname)
    {
		return Firstname;
    }
    public static string GetContactNo(string Firstname)
    {
		return Firstname;
    }
    public static string GetStudentNo(string Firstname)
    {
		return Firstname;
    }
}
