using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class TimeLineDialog : DialogBase
{




    public override List<DialogData> SetContent()
    {
        var dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("这是timeline触发的对话", "Default"));
        dialogTexts.Add(new DialogData("播放对话的时候给暂停了", "Default"));
        return dialogTexts;
    }


}
