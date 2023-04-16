using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dataoverlay : MonoBehaviour
{
    // Start is called before the first frame update

    public proMng st;
    public TextMeshProUGUI txt;
    void Awake(){
        st = GameObject.Find("proMng").GetComponent<proMng>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = st.state.ToString("f3");
    }
}
