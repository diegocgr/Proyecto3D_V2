using UnityEngine;

public class DialogMessage : MonoBehaviour
{
    [SerializeField]
    private GameObject acumulador;
    [SerializeField]
    private string characterName;
    [SerializeField]
    [TextArea(2, 5)]
    private string message;

    private DialogController dialogController;

    // 内部の private 変数を安全に外部へ公開するための方法 Player3D からCharacterNameとMessageを読み取るため
    public string CharacterName => characterName;
    public string Message => message;

    private void Start()
    {

        // シーン内のDialogControllerを探す
        dialogController = acumulador.gameObject.GetComponent<DialogController>();
        if (dialogController == null)
            Debug.LogError("DialogControllerがシーンに存在しません！");

        /*
        // レンダラーと元の色を取得
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        if (rend != null)
            originalColor = rend.material.color;
        */
    }

    private void OnMouseEnter()
    {
        // MeshRenderer を探す
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer != null)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            return;
        }

        SkinnedMeshRenderer skinnedRenderer = GetComponentInChildren<SkinnedMeshRenderer>();
        if (skinnedRenderer != null)
        {
            skinnedRenderer.material.color = Color.grey;
            return;
        }

    }
    private void OnMouseExit()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer != null)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            return;
        }

        SkinnedMeshRenderer skinnedRenderer = GetComponentInChildren<SkinnedMeshRenderer>();
        if (skinnedRenderer != null)
        {
            skinnedRenderer.material.color = Color.white;
            return;
        }

    }


    private void OnMouseDown()
    {
        if (dialogController != null)
        {
            dialogController.ShowDialog(characterName, message); // トグル表示
        }
    }
    
}

