using UnityEngine;

public class PatitaCursorFPS : MonoBehaviour
{
    private RectTransform rectTransform;
    public Canvas canvasFPS;   // FPS用CanvasをInspectorでアサイン

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        Cursor.visible = false; // デフォルトカーソルを非表示
    }

    void Update()
    {
        Vector2 localPoint;
        Camera cam = canvasFPS.renderMode == RenderMode.ScreenSpaceCamera ? canvasFPS.worldCamera : null;

        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvasFPS.transform as RectTransform,
            Input.mousePosition,
            cam,
            out localPoint
        );

        rectTransform.localPosition = localPoint; // クリックしてもここで強制追従
    }

}
