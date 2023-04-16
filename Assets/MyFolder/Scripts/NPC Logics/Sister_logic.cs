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
        dialogue = total_Dialog.sister_dic[state];
        dia_index = 0;
        m_name = "sister";
        //dialogue = new List<string> {"test first","test second","test third" };
    }



}
