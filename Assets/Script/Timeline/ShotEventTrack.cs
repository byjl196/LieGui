using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[TrackColor(0.855f, 0.8623f, 0.87f)]
[TrackClipType(typeof(ShotEventClip))]
public class ShotEventTrack : TrackAsset
{
    //����Ҫ���
    //public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    //{
    //    return ScriptPlayable<ShotEventMixerBehaviour>.Create (graph, inputCount);
    //}
}
