using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int randomNumber = 0 ; // befault value
        while (randomNumber != 15 ) {
            randomNumber = Random.Range(1, 21) ;
            if (randomNumber == 5 )continue ;
            Debug.Log(randomNumber);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

