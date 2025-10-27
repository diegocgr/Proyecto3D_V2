using UnityEngine;

public class ClickToggleLight : MonoBehaviour
{
    [Header("クリックで切り替えたいライト")]
    [Tooltip("オブジェクト自身または子にある Light を自動で取得")]
    public Light targetLight;

    [Header("ハイライト用のレンダラー (任意)")]
    public Renderer highlightRenderer;
    public Color highlightColor = Color.yellow;
    private Color originalColor;

    private void Start()
    {
        // targetLight が未設定なら自分か子を検索
        if (targetLight == null)
            targetLight = GetComponent<Light>() ?? GetComponentInChildren<Light>();

        if (highlightRenderer != null)
            originalColor = highlightRenderer.material.color;
    }

    private void OnMouseEnter()
    {
        if (highlightRenderer != null)
            highlightRenderer.material.color = highlightColor;
    }

    private void OnMouseExit()
    {
        if (highlightRenderer != null)
            highlightRenderer.material.color = originalColor;
    }

    private void OnMouseDown()
    {
        if (targetLight != null)
        {
            targetLight.enabled = !targetLight.enabled;
            Debug.Log($"{name} light toggled to {targetLight.enabled}");
        }
    }
}
