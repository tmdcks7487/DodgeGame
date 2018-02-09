using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateemeny : MonoBehaviour
{
    

   
    // Update is called once per frame
    void Update()
    {
       
        if (Time.timeSinceLevelLoad > 30.0f)
        {
            transform.Rotate(new Vector3(0, 1, 0), 10.0f);

        }
    }
}
