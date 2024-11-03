using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       for( int i = 1; i <= 10;i++) {
        Debug.Log( i + "*" + "5" + " = " + multipleNumber(i , 5));
       }
    }
    int multipleNumber(int firstNumber , int secondNumber) {
        return firstNumber*secondNumber;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
