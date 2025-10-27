using UnityEngine;

public class LanternLightBlink : MonoBehaviour
{
    private Light lanternLight;
    private float baseIntensity;
    private float timer;

    [Header("Lantern Blink Settings")]
    public float minBlinkDelay = 0.1f;   // 点滅間隔（最小）
    public float maxBlinkDelay = 0.5f;   // 点滅間隔（最大）
    public float flickerIntensity = 0.8f; // 点滅時の明るさの比率

    private float nextBlinkTime;
    private bool isBlinking = false;

    void Start()
    {
        lanternLight = GetComponent<Light>();
        baseIntensity = lanternLight.intensity;
        ScheduleNextBlink();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= nextBlinkTime)
        {
            // 点滅ON/OFFをランダムに切り替え
            isBlinking = !isBlinking;
            lanternLight.intensity = isBlinking ? baseIntensity * flickerIntensity : baseIntensity;

            ScheduleNextBlink();
        }
    }

    void ScheduleNextBlink()
    {
        timer = 0f;
        nextBlinkTime = Random.Range(minBlinkDelay, maxBlinkDelay);
    }
}
