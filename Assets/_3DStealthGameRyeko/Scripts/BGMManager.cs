using UnityEngine;

public class BGMController: MonoBehaviour
{
    void Awake()
    {
        transform.SetParent(null); // 親から切り離す
        DontDestroyOnLoad(gameObject); // シーン切り替えでも破棄されない
    }

    void Start()
    {
        // 例: 自動再生
        GetComponent<AudioSource>().Play();
    }
}
