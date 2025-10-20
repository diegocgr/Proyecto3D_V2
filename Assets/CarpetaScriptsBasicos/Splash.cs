using UnityEngine;
using UnityEngine.SceneManagement;
public class Splash : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //CambiarEscena();
        Invoke("CambiarEscena", 3.0f);
    }


    public void CambiarEscena()
    {
        //Debug.Log("Voy a cambiar de escena");
        SceneManager.LoadScene("MenuPrincipal"); //Aquí hay que tener que revisar el nombre del Menu Principal
    }

    // Update is called once per frame
    void Update()
    {

    }
}
