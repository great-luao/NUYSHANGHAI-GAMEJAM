using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField]
    float speed;



    CharacterController characterController;
    
    // Start is called before the first frame update
    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            transform.Rotate(Vector3.down * 90);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 90);
        }
        if (Input.GetKey(KeyCode.W))
        {
            characterController.Move(transform.forward * Time.deltaTime * speed * -1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            characterController.Move(transform.forward * Time.deltaTime * speed);
        }
    }

}
