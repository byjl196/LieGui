using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class TimeLineDialog : DialogBase
{




    public override List<DialogData> SetContent()
    {
        var dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("����timeline�����ĶԻ�", "Default"));
        dialogTexts.Add(new DialogData("���ŶԻ���ʱ�����ͣ��", "Default"));
        return dialogTexts;
    }


}
