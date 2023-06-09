using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sspan : MonoBehaviour
{
    // Start is called before the first frame update
    public bool istrigger = false;
    // Start is called before the first frame update

    public Animator anim;
    public proMng st;

    private int[] span = new int[13] {0,0,1,1,1,1,0,0,0,0,2,2,1};
    private string[] fram = new string[3] {"ver","dog","mou"};

    public int play = 0;

    public GameObject violin;
    public GameObject ring;
    public GameObject letter;

    public GameObject[] frm = new GameObject[3];

    void Awake(){
        st = GameObject.Find("proMng").GetComponent<proMng>();
        anim = GameObject.Find("Canvas").GetComponent<Animator>();

        violin = GameObject.Find("violin");
        violin.SetActive(false);
        ring = GameObject.Find("ring");
        ring.SetActive(false);
        letter = GameObject.Find("letter");
        letter.SetActive(false);

        // for(int i=0;i<3;i++){
        //     frm[i] = GameObject.Find(fram[i]);
        // }

        frm[1].SetActive(false);
        frm[2].SetActive(false);
    }
    
    void Update()
    {
        // if(st.state <= 1){
        //     if(istrigger&&input.GetKey(KeyCode.Space)){
        //         st.state = 2;
        //         anim.SetInt("Dog",1);
        //     }
        // } elif(st.state <= 5){
        //     if(istrigger&&input.GetKey(KeyCode.Space)){
        //         st.state = 2;
        //         anim.SetInt("Dog",1);
        //     }

        // } elif(st.state <= 9){
        //     if(istrigger&&input.GetKey(KeyCode.Space)){
        //         st.state = 2;
        //         anim.SetInt("Dog",1);
        //     }

        // } elif(st.state <= 11){
        //     if(istrigger&&input.GetKey(KeyCode.Space)){
        //         st.state = 2;
        //         anim.SetInt("Dog",1);
        //     }

        // }

        if(istrigger&&Input.GetKey(KeyCode.Space)&&play==0){
            if(st.state == 1){
                violin.SetActive(true);
                st.state++;
            }
            if(st.state == 5){
                letter.SetActive(true);
                st.state++;
            }
            if(st.state == 9){
                ring.SetActive(true);
                st.state++;
            }
            if(st.state == 11){
                st.state+=2;
            }

            spam1();
            anim.SetInteger("click",0);
            anim.SetInteger(fram[span[st.state]],1);
            play = 1;
        }
        if(play == 1){
            if(Input.GetMouseButton(0)){
                spam2();
                play = 0;
                anim.SetInteger("click",1);
                anim.SetInteger(fram[span[st.state]],0);
            }
        }
    }

    private void spam1(){
        //reset position and structure
        for(int i=0;i<3;i++){
            frm[i].SetActive(false);
        }
        return;
    }

    private void spam2(){
        //reset position and structure
        frm[span[st.state]].SetActive(true);
        return;
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
