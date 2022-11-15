using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class ShotEventClip : PlayableAsset, ITimelineClipAsset
{
    public ShotEventBehaviour template = new ShotEventBehaviour();



    public ClipCaps clipCaps
    {
        get { return ClipCaps.Extrapolation | ClipCaps.Blending; }
    }

    public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<ShotEventBehaviour>.Create (graph, template);
        return playable;
    }
}
