using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.Events;

public class TimelineControl : MonoBehaviour
{

    public PlayableDirector director;

    [Header("��ʼ����timnelineʱ������������awakeplay�ݲ����á���")]
    public UnityEvent OnTimelineStart = new UnityEvent();


    [Header("�ָ�����timnelineʱ����")]
    public UnityEvent OnTimelinePlay=new UnityEvent();
    [Header("��ͣtimnelineʱ����")]
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
