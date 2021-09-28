using System;


public delegate long DelegateNumber(long number);
public delegate long DelegateText(string text);

public class StudentInfoClass
{
    public static string FirstName = " ";
    public static string LastName = " ";
    public static string MiddleName = " ";
    public static string Address = " ";
    public static string Program = " ";

    public static long Age = 0;
    public static long ContactNo = 0;
    public static long StudentNo = 0;

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
