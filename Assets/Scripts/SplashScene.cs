using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("CambiarEscena", 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void CambiarEscena()
    {
        SceneManager.LoadScene("MenuPrincipalScene");
    }
}
