using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tip_Logic : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * 50);       
    }
}
