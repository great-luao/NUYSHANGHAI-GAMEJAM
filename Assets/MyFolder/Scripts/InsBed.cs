using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsBed : MonoBehaviour
{
    public float speed = 3f;
    private int epoch = 0;
    public int on = 5;
    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }
 
    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.parent.GetComponent<sspan>().istrigger){ 
            GetComponent<MeshRenderer>().enabled = true;
            transform.Translate(new Vector3(0,speed,0)*Time.deltaTime);
            epoch++;
            if(epoch%5==0){
                speed *= -1;
            }
            
        }else{
            GetComponent<MeshRenderer>().enabled = false;
            transform.position = (transform.parent.position+new Vector3(0,on,0));
        }
    }
}
