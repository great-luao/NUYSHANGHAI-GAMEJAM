using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    static Camera_Controller m_instance;
    public static Camera_Controller Instance = m_instance;

    public List<GameObject> Cameras;

    private GameObject last_camera;


    private void Awake()
    {
        last_camera = Cameras[0];
        CreateSingleton();
    }

    void CreateSingleton()
    {
        if (m_instance == null)
        {
            m_instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void SwitchCamera(int room_id)
    {
        last_camera.SetActive(false);
        Cameras[room_id].SetActive(true);
        //last_camera.GetComponent<Camera>().enabled = false;
        //Cameras[room_id].GetComponent<Camera>().enabled = true;
        last_camera = Cameras[room_id];
    }
}
