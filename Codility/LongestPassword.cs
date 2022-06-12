using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{

    public int solution(string S)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int maxPassword = -1;
        var passwords = S.Split(' ');
        for (int i = 0; i < passwords.Length; i++)
        {
            var n = PasswordLength(passwords[i]);
            if (n > maxPassword) maxPassword = n;
        }

        return maxPassword;
    }
    public int PasswordLength(string s)
    {
        var arr = s.ToCharArray();
        int letters = 0, numbers = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (!Char.IsLetterOrDigit(arr[i]))
                return -1;
            if (Char.IsLetter(arr[i]))
            {
                letters++;
                continue;
            }
            numbers++;
        }
        if (letters % 2 == 0 && numbers % 2 == 1)
            return numbers + letters;
        return -1;
    }
}