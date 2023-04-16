using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Transpanrent_Door : MonoBehaviour
{
    [SerializeField]
    int last_room;
    [SerializeField]
    Transform out_pos;

    Camera_Controller camera_Controller;
    Transform change_trans;


    private void Awake()
    {
        //camera_Controller = GetComponent<Camera_Controller>();
        camera_Controller = FindObjectOfType<Camera_Controller>();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            camera_Controller.SwitchCamera(last_room);
            other.gameObject.SetActive(false);
            other.transform.position = out_pos.position;
            other.gameObject.SetActive(true);
            print(other.transform.position);
        }
    }
}
