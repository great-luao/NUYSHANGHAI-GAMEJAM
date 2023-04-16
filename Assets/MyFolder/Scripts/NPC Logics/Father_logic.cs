using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Father_logic : NPC_logic
{
    // Maybe useful
    public override void Init()
    {

    }

    public override void InitDialog()
    {
        base.InitDialog();
        dialogue = total_Dialog.father_dic[st.state];
        dia_index = 0;
        m_name = "father";
        //dialogue = new List<string> {"test first","test second","test third" };
    }

    public override void ChangeState()
    {
        base.ChangeState();
        if (st.state == 4) st.state = 5;
        else if (st.state == 7) st.state = 8;

    }
}
