using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sister_logic : NPC_logic
{
    // Maybe useful
    public override void Init()
    {

    }

    public override void InitDialog()
    {
        base.InitDialog();
        dialogue = total_Dialog.sister_dic[st.state];
        dia_index = 0;
        m_name = "sister";
        if (st.state >= 3) m_name = "Sister";
        //dialogue = new List<string> {"test first","test second","test third" };
    }

    public override void ChangeState()
    {
        base.ChangeState();
        if (st.state == 0) { st.state = 1;}
        else if (st.state == 3) st.state = 4;
    }

}
