using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mother_logic : NPC_logic
{
    // Maybe useful
    public override void Init()
    {

    }

    public override void InitDialog()
    {
        base.InitDialog();
        dialogue = total_Dialog.mother_dic[st.state];
        dia_index = 0;
        m_name = "mother";
        //dialogue = new List<string> {"test first","test second","test third" };
    }

    public override void ChangeState()
    {
        base.ChangeState();
        if (st.state == 8) st.state = 9;
        else if (st.state == 11) st.state = 12;
        else if (st.state == 13) st.state = 14;
    }

}
