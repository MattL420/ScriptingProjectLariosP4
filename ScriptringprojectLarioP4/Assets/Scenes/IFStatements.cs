using System.Collections.Generic;
using UnityEngine;

public class ForeachLoop : MonoBehavior
{
    void Start()
    {
        string[] string = new string[3];

        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";


        foreach (string item in strings)
        {
            print(item);
        }
    }
}