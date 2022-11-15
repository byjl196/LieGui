using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Events;

[Serializable]
public class ShotEventBehaviour : PlayableBehaviour
{
    public string info = "NULL";
    public UnityEvent timelineEvent = new UnityEvent();


    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {
        base.OnBehaviourPlay(playable, info);        

        bool isFirst = playable.GetTime() < info.deltaTime;
        //֤���Ѿ��������ǵ�һ֡�� ע�� ��Ϊ��ʱû��ʹ���ź�ϵͳ ��Ҫȥ�϶� �϶������� 
        if (!isFirst)
        {
            //��ʹ�ÿ�ܴ�ӡ
            timelineEvent.Invoke();
            Debug.LogWarning("��δ���"+ info + "  "+ playable.GetTime() + "  "+ info.deltaTime);
            return;
        }       
        //UnityGameFramework.Runtime.Log.Debug("OnBehaviourPlay{0}" , eventPara);
        if (Application.isPlaying)
        {
            //GameEntry.GameEventManager.TriggerGameEvents(eventPara,33);
        }
    }
}
