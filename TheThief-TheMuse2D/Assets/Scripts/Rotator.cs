using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
        //Script to make objects rotate in a circle
        void Update()
        {
            transform.Rotate(new Vector3(0, 45, 0) * 3 * Time.deltaTime);
        }

    
}
