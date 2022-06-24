using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[System.Serializable]
public class SpherePlayableAsset : PlayableAsset
{
    public ExposedReference<GameObject> sphere;

    // Factory method that generates a playable based on this asset
    public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
    { 
        SphereBehaviour sphereBehaviour = new SphereBehaviour();
        sphereBehaviour.sphere = sphere.Resolve(graph.GetResolver());

        ScriptPlayable<SphereBehaviour> playable = ScriptPlayable<SphereBehaviour>.Create(graph, sphereBehaviour);

        return playable;
    }
}
