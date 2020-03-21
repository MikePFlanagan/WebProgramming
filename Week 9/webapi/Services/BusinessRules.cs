public static class BusinessRules
{public static int MaxStudentsAllowed = 500;

    public static string atSymbol = "@";
    public static bool isOverQuota(Student student) => 
        student.StudentId > MaxStudentsAllowed;

    public static bool isInvalidEmail(Student student) =>
        !student.EmailAddress.ToLower().Contains(atSymbol);

    public static bool isSpecial(Student student) =>
       student.StudentId > MaxStudentsAllowed || !student.EmailAddress.ToLower().Contains(atSymbol);
}

    
        


