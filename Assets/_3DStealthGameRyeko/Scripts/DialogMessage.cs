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
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }
    private void OnMouseExit()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
    }


    private void OnMouseDown()
    {
        if (dialogController != null)
        {
            dialogController.ShowDialog(characterName, message); // トグル表示
        }
    }
}

