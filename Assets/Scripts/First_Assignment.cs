using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First_Assignment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num = 10;
        PrintNumber(num);
        IfStatement(num);
    }

    static void PrintNumber (int num)
        {
        Debug.Log($"This is your number {num}");
        }
    static void IfStatement (int num)
    {
        if(num > 0)
        {
            Debug.Log($"The number {num} is bigger than 0");
        }
        else if (num < 0)
        {
            Debug.Log($"The number {num} is lower than 0");
        }
        else if (num == 0)
        {
            Debug.Log($"The number is {num}, perfect balance");
        }
    }
     

       
}
