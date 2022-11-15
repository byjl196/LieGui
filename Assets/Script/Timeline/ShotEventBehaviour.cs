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
        //证明已经超过不是第一帧了 注意 因为暂时没有使用信号系统 不要去拖动 拖动有问题 
        if (!isFirst)
        {
            //不使用框架打印
            timelineEvent.Invoke();
            Debug.LogWarning("多次触发"+ info + "  "+ playable.GetTime() + "  "+ info.deltaTime);
            return;
        }       
        //UnityGameFramework.Runtime.Log.Debug("OnBehaviourPlay{0}" , eventPara);
        if (Application.isPlaying)
        {
            //GameEntry.GameEventManager.TriggerGameEvents(eventPara,33);
        }
    }
}
