using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.Events;

public class TimelineControl : MonoBehaviour
{

    public PlayableDirector director;

    public UnityEvent OnTimelinePlay=new UnityEvent();
    public UnityEvent OnTimelinePause=new UnityEvent();

    public void PauseTimeLine()
    {
        director.Pause();
        OnTimelinePause.Invoke();
    }

    public void PlayTimeline()
    {
        director.Play();
        OnTimelinePlay.Invoke();
    }


}
