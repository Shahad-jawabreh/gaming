using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class second : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int index ;
        string[] array ={"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
        int count = 7;

        while(count > 0) {
            count--;
            index = Random.Range(0, array.Length -1 ) ;
            Debug.Log(array[index]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
