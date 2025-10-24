using UnityEngine;
using TMPro;  // TextMeshProを使うときに必要！

public class GargoyleController : MonoBehaviour
{
    [Header("UI設定")]
    [SerializeField] private GameObject messagePanel;
    [SerializeField] private TMP_Text textName;      // 名前表示用
    [SerializeField] private TMP_Text textMessage;   // メッセージ表示用

    [Header("メッセージ内容")]
    [SerializeField] private string characterName = "Gargoyle";
    [SerializeField, TextArea] private string message = "The gargoyle awakens...";

    [Header("タグ設定")]
    [SerializeField] private string playerTag = "Player"; // プレイヤーのタグ

    private bool messageShown = false;



    void Start()
    {
        if (messagePanel != null)
            messagePanel.SetActive(false);
    }

    // 🎯 Animation Event から呼ばれる関数
    public void OnGargoyleAnimationEnd()
    {
        Debug.Log("OnGargoyleAnimationEnd が呼ばれました！");

        if (messagePanel != null)
            messagePanel.SetActive(true);

        if (textName != null)
            textName.text = characterName;

        if (textMessage != null)
            textMessage.text = message;
        // ✅ フラグを立てる（これが抜けていました！）
        messageShown = true;
    }

    // 🧭 プレイヤーがコライダー範囲から離れたときに呼ばれる
    private void OnTriggerExit(Collider other)
    {
        if (!messageShown) return;

        if (other.CompareTag("Player"))
        {
            Debug.Log("プレイヤーが範囲外に出ました。メッセージを非表示にします。");
            if (messagePanel != null)
                messagePanel.SetActive(false);

            messageShown = false;
        }
    }
}
