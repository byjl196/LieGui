using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimelineEvent : MonoBehaviour
{
  public   UnityEvent OntimeLineTrigger=new UnityEvent();


    public void OntimelineTrigger()
    {
        OntimeLineTrigger.Invoke();
    }

}
