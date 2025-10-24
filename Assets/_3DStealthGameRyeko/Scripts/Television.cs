using UnityEngine;

public class Television : MonoBehaviour
{
    [SerializeField]
    private GameObject acumulador;
    [SerializeField]
    private string characterName;
    [SerializeField]
    [TextArea(2, 5)]
    private string message;

    private DialogController dialogController;

    // private bool tvActiv;

    private void OnMouseEnter()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.clear;
    }
    private void OnMouseExit()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
    }
    private void OnMouseDown()
    {
        Debug.Log("he tocado TV");

            if (this.gameObject.transform.GetChild(0).gameObject.activeSelf)
            {
                this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            }
            else
            {
                this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            }
            if (dialogController != null)
            {
                dialogController.ShowDialog(characterName, message); // トグル表示
        }

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameObject.transform.GetChild(0).gameObject.SetActive(false);

        // シーン内のDialogControllerを探す
        dialogController = acumulador.gameObject.GetComponent<DialogController>();
            if (dialogController == null)
                Debug.LogError("DialogControllerがシーンに存在しません！");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
