using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum NPC_State
{
    Sleep,
    Chase,
    Attack,
    Patrol
}


public abstract class NPC_logic: MonoBehaviour
{
    UI_Manager uI_Manager;


    [SerializeField]
    GameObject tip_Block;

    protected Dialog total_Dialog;

    protected string m_name;
    protected List<string> dialogue;
    protected int dia_index = 0;
    public event EventHandler OnPress;

    protected int state;

    private void Awake()
    {
        uI_Manager = FindObjectOfType<UI_Manager>();
        total_Dialog = FindObjectOfType<Dialog>();
        print(total_Dialog);
        Init();
    }

    private void Update()
    {
        if(OnPress != null) OnPress.Invoke(this, EventArgs.Empty);
        ChangeState();
    }
   

    public abstract void Init();


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            InitDialog();
            tip_Block.SetActive(true);
            OnPress += BeginDialog;
            //OnPress.Invoke(this, EventArgs.Empty);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            tip_Block.SetActive(false);
            OnPress -= BeginDialog;
            uI_Manager.CloseDialog();
        }
    }

    public virtual void InitDialog() {}

    private void BeginDialog(object sender, System.EventArgs e)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("dia_index is" + dia_index);
            print(dialogue[dia_index]);
            uI_Manager.ShowDialog(m_name, dialogue[dia_index]);
            UpdateDialog();
        }
    }


    public void UpdateDialog()
    {
        if (dia_index < dialogue.Count - 1) dia_index++;
    }

    // Change State
    private void ChangeState()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            state += 1;
            print(state);
        }
    }


}
