using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Senha
{
    static string password = "";

    public static void IncrementToPassword(string number)
    {
        password = password + number;
        if (password.Length > 10)
            Clear();
        Debug.Log(password);
    }

    public static bool IsRight()
    {
        return password == "1612120115" ? true : false;
    }

    public static void Clear()
    {
        password = "";
    }

}
