using UnityEngine;
using System.Collections;

public class LightFlickerController : MonoBehaviour
{
    public enum FlickerType { Candle, Lantern }

    public FlickerType flickerType = FlickerType.Candle;

    private Light targetLight;
    private float baseIntensity;

    [Header("Candle Settings")]
    public float candleFlickerSpeed = 2.0f;
    public float candleIntensityRange = 0.2f;
    public float candleUpdateInterval = 0.05f; // 更新間隔

    [Header("Lantern Settings")]
    public float minBlinkDelay = 0.1f;
    public float maxBlinkDelay = 0.5f;
    public float flickerIntensity = 0.7f;

    private bool isBlinking;

    void Start()
    {
        targetLight = GetComponent<Light>() ?? GetComponentInChildren<Light>();
        if (targetLight == null)
        {
            Debug.LogWarning($"[{name}] Light が見つかりません。");
            enabled = false;
            return;
        }

        baseIntensity = targetLight.intensity;

        // コルーチン開始
        if (flickerType == FlickerType.Candle)
            StartCoroutine(CandleFlickerCoroutine());
        else
            StartCoroutine(LanternBlinkCoroutine());
    }

    IEnumerator CandleFlickerCoroutine()
    {
        while (true)
        {
            float noise = Mathf.PerlinNoise(Time.time * candleFlickerSpeed, 0f);
            targetLight.intensity = baseIntensity + (noise - 0.5f) * candleIntensityRange;
            yield return new WaitForSeconds(candleUpdateInterval);
        }
    }

    IEnumerator LanternBlinkCoroutine()
    {
        while (true)
        {
            isBlinking = !isBlinking;
            targetLight.intensity = isBlinking ? baseIntensity * flickerIntensity : baseIntensity;
            float delay = Random.Range(minBlinkDelay, maxBlinkDelay);
            yield return new WaitForSeconds(delay);
        }
    }
}


/*
 * using UnityEngine;

public class LightFlickerController : MonoBehaviour
{
    public enum FlickerType
    {
        Candle,     // ろうそく風
        Lantern     // 電球風
    }

    [Header("General Settings")]
    [Tooltip("ゆらめき or 点滅のタイプを選択")]
    public FlickerType flickerType = FlickerType.Candle;

    private Light targetLight;
    private float baseIntensity;
    private float timer;
    private bool isBlinking;

    [Header("Candle Settings (ゆらめき)")]
    [Tooltip("ゆらめきの速さ (1〜5くらい)")]
    public float candleFlickerSpeed = 2.0f;
    [Tooltip("明るさの変化幅 (0.1〜0.4くらい)")]
    public float candleIntensityRange = 0.2f;

    [Header("Lantern Settings (点滅)")]
    [Tooltip("最小の点滅間隔 (秒)")]
    public float minBlinkDelay = 0.1f;
    [Tooltip("最大の点滅間隔 (秒)")]
    public float maxBlinkDelay = 0.5f;
    [Tooltip("点滅時の明るさの比率 (0〜1)")]
    public float flickerIntensity = 0.7f;

    private float nextBlinkTime;

    void Start()
    {
        // 同じオブジェクト、または子オブジェクトからLightを探す
        targetLight = GetComponent<Light>();
        if (targetLight == null)
        {
            targetLight = GetComponentInChildren<Light>();
        }

        if (targetLight == null)
        {
            Debug.LogWarning($"[{name}] LightFlickerController: Light コンポーネントが見つかりません。");
            enabled = false;
            return;
        }

        baseIntensity = targetLight.intensity;
        ScheduleNextBlink();
    }

    void Update()
    {
        Debug.Log("estado de ligth");
        switch (flickerType)
        {
            case FlickerType.Candle:
                CandleFlicker();
                break;
            case FlickerType.Lantern:
                LanternBlink();
                break;
        }
    }

    // 🕯 ろうそく風ゆらめき
    void CandleFlicker()
    {
        float noise = Mathf.PerlinNoise(Time.time * candleFlickerSpeed, 0.0f);
        targetLight.intensity = baseIntensity + (noise - 0.5f) * candleIntensityRange;
    }

    // 🔦 ランタン風点滅
    void LanternBlink()
    {
        timer += Time.deltaTime;

        if (timer >= nextBlinkTime)
        {
            isBlinking = !isBlinking;
            targetLight.intensity = isBlinking ? baseIntensity * flickerIntensity : baseIntensity;
            ScheduleNextBlink();
        }
    }

    void ScheduleNextBlink()
    {
        timer = 0f;
        nextBlinkTime = Random.Range(minBlinkDelay, maxBlinkDelay);
    }
}
*/
