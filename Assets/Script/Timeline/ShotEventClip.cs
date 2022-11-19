using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.Events;

[Serializable]
public class ShotEventClip : PlayableAsset, ITimelineClipAsset
{
    [SerializeField]
    public ShotEventBehaviour template = new ShotEventBehaviour();


    public ExposedReference<TimelineEvent> timelineevent;

    public ClipCaps clipCaps
    {
        get { return ClipCaps.Extrapolation | ClipCaps.Blending; }
    }

    public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<ShotEventBehaviour>.Create (graph, template);
        ShotEventBehaviour clone = playable.GetBehaviour();
        clone.timelineevent= timelineevent.Resolve(graph.GetResolver());


        return playable;
    }
}
