using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject canvasScene; // ← Canvasをインスペクターで指定

    private bool isMenuActive = true; // 初期状態を true にしておく

    // メインメニューに戻る
    public void GoToMenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipalScene");
    }

    // FPSカメラのシーンへ
    public void GoToFPSCamera()
    {
        SceneManager.LoadScene("Scene3RyekoFPS");
    }

    // CambiarCamaraのシーンへ
    public void GoToCambiarCamara()
    {
        SceneManager.LoadScene("Scene3RyekoCameras");
    }

    /*
  // SinInteractivoのシーンへ
  public void GoToSinInteractivo()
  {
      SceneManager.LoadScene("SinInteractivoScene");
  }


  // ゲーム終了ボタン（任意）
  public void QuitGame()
  {
      Debug.Log("Juego cerrado.");
      Application.Quit();
  }
  */


    // Canvas のオンオフを切り替える
    public void ToggleMenu()
    {
        if (isMenuActive)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (canvasScene == null) return;

        isMenuActive = !isMenuActive;
        canvasScene.SetActive(isMenuActive);
        Debug.Log("Canvas " + (isMenuActive ? "表示中" : "非表示"));
    }


    // Update is called once per frame
    void Update()
    {
        // ESCキーでCanvasのオンオフ
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleMenu();
        }
    }
}
