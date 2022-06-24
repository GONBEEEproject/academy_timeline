using UnityEngine;
using UnityEngine.Playables;

// A behaviour that is attached to a playable
public class SphereBehaviour : PlayableBehaviour
{
    public GameObject sphere;

    // Timeline���̂��Đ��J�n�����Ƃ�
    public override void OnGraphStart(Playable playable)
    {

    }

    // Timeline���̂��Đ���~�����Ƃ�
    public override void OnGraphStop(Playable playable)
    {

    }

    // Track���n�܂����Ƃ�
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

    // Track���I������Ƃ��ATrack�O�ɂ���Ƃ�
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

    // Track�Đ������t���[�����s�����
    public override void PrepareFrame(Playable playable, FrameData info)
    {

    }
}
