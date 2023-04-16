using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    // [SerializeField] private float speed;
    // private Animator anim;
    public float moveSpeed = 50f; // 控制角色移动速度的变量

    private CharacterController characterController; // 用于控制角色运动的刚体组件

    void Start()
    {
        // 获取角色对象的刚体组件
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // 获取WASD键的输入值
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // 计算角色的移动向量
        Vector3 movement = new Vector3(-vertical, 0f, horizontal) * moveSpeed * Time.deltaTime;
        //print(movement);


        // 将角色的移动向量应用到刚体组件上
        characterController.Move(movement);

        // 如果角色有移动输入，则将角色的朝向设置为移动方向
        if (movement.magnitude > 0)
        {
            movement = new Vector3(horizontal, 0f, vertical);
            transform.rotation = Quaternion.LookRotation(movement);
        }


    }
}

