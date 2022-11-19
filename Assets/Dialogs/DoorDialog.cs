using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class DoorDialog : DialogBase
{
    public override List<DialogData> SetContent()
    {
        base.SetContent();
        var dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("ÐèÒªÁ­µ¶", "Default"));
        return dialogTexts; 
    }
}
