using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.Events;

public class TimelineControl : MonoBehaviour
{

    public PlayableDirector director;

    [Header("开始播放timneline时触发（“设置awakeplay暂不可用”）")]
    public UnityEvent OnTimelineStart = new UnityEvent();


    [Header("恢复播放timneline时触发")]
    public UnityEvent OnTimelinePlay=new UnityEvent();
    [Header("暂停timneline时触发")]
    public UnityEvent OnTimelinePause=new UnityEvent();


    bool isFirstPlay = true;

    public void PauseTimeLine()
    {
        director.Pause();
        OnTimelinePause.Invoke();
    }

    public void PlayTimeline()
    {
        if (isFirstPlay)
        {
            isFirstPlay = false;
            OnTimelineStart.Invoke();
        }

        director.Play();
        OnTimelinePlay.Invoke();
    }


}
