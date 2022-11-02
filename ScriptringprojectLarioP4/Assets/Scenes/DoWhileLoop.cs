using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoop : MonoBehavior
{

    void Start()
    {
        bool shouldContinue = false;

        do
        {
            print("Hello World");

        } while (shouldContinue == true);
    }
}
