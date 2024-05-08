using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Profiling;
/// <summary>
/// For debugging: FPS Counter
/// �f�o�b�O�p: FPS �J�E���^
/// </summary>
public class FPSCounter : MonoBehaviour
{
    [SerializeField, Range(0.1f, 1.0f)]
    float EveryCalcurationTime = 0.5f;
    public Text fpsText;
    public float Fps
    {
        get; private set;
    }

    int frameCount;
    float prevTime;

    void Start()
    {
        Application.targetFrameRate = 60;
        frameCount = 0;
        prevTime = 0.0f;
        Fps = 0.0f;
    }
    void Update()
    {
        frameCount++;
        float time = Time.realtimeSinceStartup - prevTime;

        // n�b���ƂɌv��
        if (time >= EveryCalcurationTime)
        {
            Fps = frameCount / time;

            frameCount = 0;
            prevTime = Time.realtimeSinceStartup;
            fpsText.text = Fps.ToString();
        }
    }
}