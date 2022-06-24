using UnityEngine;
using UnityEngine.Playables;

// A behaviour that is attached to a playable
public class SphereBehaviour : PlayableBehaviour
{
    public GameObject sphere;

    // Timeline自体が再生開始したとき
    public override void OnGraphStart(Playable playable)
    {

    }

    // Timeline自体が再生停止したとき
    public override void OnGraphStop(Playable playable)
    {

    }

    // Trackが始まったとき
    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {
        //if (sphere == null)
        //{
        //    return;
        //}

        Renderer renderer = sphere.GetComponent<Renderer>();
        Color c = renderer.material.color;

        c.r = 0;
        c.g = 1;
        c.b = 0;

        renderer.material.color = c;
    }

    // Trackが終わったとき、Track外にいるとき
    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
        //if (sphere == null)
        //{
        //    return;
        //}

        Renderer renderer = sphere.GetComponent<Renderer>();
        Color c = renderer.material.color;

        c.r = 1;
        c.g = 1;
        c.b = 1;

        renderer.material.color = c;
    }

    // Track再生中毎フレーム実行される
    public override void PrepareFrame(Playable playable, FrameData info)
    {

    }
}
