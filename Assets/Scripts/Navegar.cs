using UnityEngine;
using UnityEngine.SceneManagement;

public class Navegar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NavegarMenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipalScene");
    }

    public void NavegarRyeko()
    {
        SceneManager.LoadScene("Scene3Ryeko");
    }

    public void NavegarSergi()
    {
        SceneManager.LoadScene("Scene2Sergi");
    }

    public void NavegarDiego()
    {
        SceneManager.LoadScene("SceneDiego");
    }
    
    public void NavegarSalir()
    {
        Application.Quit();
    }
}
