using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour
{
    [SerializeField]
    private GameObject canvasPanel;
    [SerializeField]
    private GameObject textName;
    [SerializeField]
    private GameObject textMessage;

    private bool dialogActive;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvasPanel.gameObject.SetActive(false);
    }

    // ダイアログを表示する関数
    public void ShowDialog(string characterName, string message){
        if (canvasPanel.gameObject.activeSelf)
            {
            // パネルが表示されていれば非表示にする
            canvasPanel.SetActive(false);
            dialogActive = false;
            }
            else
            {

            // パネルが非表示なら表示して文字をセット
            textName.gameObject.GetComponent<TMP_Text>().text = characterName;
            textMessage.gameObject.GetComponent<TMP_Text>().text = message;
            canvasPanel.gameObject.SetActive(true);
            dialogActive = true;

            /*
             * textName.gameObject.GetComponent<TMP_Text>().text = characterName;
            textMessage.gameObject.GetComponent<TMP_Text>().text = message;
            canvasPanel.SetActive(true);

            dialogActive = true;
            canvasPanel.gameObject.SetActive(false);

            dialogActive = true;
                canvasPanel.gameObject.SetActive(false);
            */
            }
    }





    // Update is called once per frame
    void Update()
    {

    }
}




