using UnityEngine;
using TMPro;

public class Luz : MonoBehaviour
{

    [SerializeField]
    private GameObject textoApagarLuz;
    private bool estaLuzActiva;
    
    public GameObject objeto;
    [SerializeField]
    private GameObject sliderIntensidadLuz;

    public void CambiarIntensidad()
    {


    }

    public void CambiarColores(string color)
    {
        
    }
    public void ToggleActive()
    {
        
        if (objeto != null)
        {
            estaLuzActiva = true;
            objeto.SetActive(!objeto.activeSelf);
        }
        if (estaLuzActiva)
        { 
            textoApagarLuz.gameObject.GetComponent<TMP_Text>().text = "Encender Luces"; 
        }
        
        else 
        { 
            textoApagarLuz.gameObject.GetComponent<TMP_Text>().text = "Apagar Luces";
        }
    }
}