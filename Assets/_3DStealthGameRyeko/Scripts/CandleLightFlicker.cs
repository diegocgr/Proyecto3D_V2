using UnityEngine;
// ChatGTP
public class CandleLightFlicker : MonoBehaviour
{
    private Light candleLight;
    private float baseIntensity;

    [Header("Candle Flicker Settings")]
    public float flickerSpeed = 2.0f;        // ゆらめきの速さ
    public float intensityRange = 0.2f;      // 明るさの変化幅

    void Start()
    {
        candleLight = GetComponent<Light>();
        baseIntensity = candleLight.intensity;
    }

    void Update()
    {
        // PerlinNoiseで滑らかなゆらめきを再現
        float noise = Mathf.PerlinNoise(Time.time * flickerSpeed, 0.0f);
        candleLight.intensity = baseIntensity + (noise - 0.5f) * intensityRange;
    }
}
