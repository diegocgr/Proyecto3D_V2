using UnityEngine;

public class LanternLightFlicker : MonoBehaviour
{
    private Light lanternLight;
    private float baseIntensity;

    [Header("Flicker Settings")]
    public float flickerSpeed = 0.1f;      // 点滅の速さ
    public float intensityRange = 0.3f;    // 明るさの変化幅
    public bool smooth = true;             // スムーズなゆらぎにするか

    void Start()
    {
        lanternLight = GetComponent<Light>();
        baseIntensity = lanternLight.intensity;
    }

    void Update()
    {
        if (smooth)
        {
            // スムーズなゆらめき
            float noise = Mathf.PerlinNoise(Time.time * flickerSpeed, 0.0f);
            lanternLight.intensity = baseIntensity + (noise - 0.5f) * intensityRange;
        }
        else
        {
            // ランダムな点滅
            if (Random.value > 0.9f)
                lanternLight.intensity = baseIntensity + Random.Range(-intensityRange, intensityRange);
        }
    }
}
