using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public bool istrigger = false;
    public int itemNum;
    public int[] item = new int[4] {1, 5, 9, 0};
    // Start is called before the first frame update

    public proMng st;
    void Awake(){
        st = GameObject.Find("proMng").GetComponent<proMng>();
    }
    
    void Update()
    {
        // Debug.Log(st.state);
        // Debug.Log(item[itemNum]+1);
        if(st.state==item[itemNum]+1){
            if(istrigger&&Input.GetKey(KeyCode.Space)){
                st.state++;
                gameObject.SetActive(false);
            }
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            istrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            istrigger = false;
        }
    }
}
