using UnityEngine;
using UnityEngine.Rendering.RenderGraphModule;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColorLuz : MonoBehaviour
{
    [SerializeField]
    private GameObject canvas;
    [SerializeField]
    private GameObject camaras;
    [SerializeField]
    private GameObject iluminacion;

    [SerializeField]
    private GameObject textApagarLuces;

    [SerializeField]
    private GameObject sliderIntencidadLuz;


    private bool estaLuzActiva;
    private int i;

    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void CambiarColor(string color)
    {
        for (i = 0; i < iluminacion.gameObject.transform.childCount; i++)
        {
            if (color == "rojo")
            {
                iluminacion.gameObject.transform.GetChild(i).gameObject.GetComponent<Light>().color = Color.red;
            }
            else if (color == "amarillo")
            {
                iluminacion.gameObject.transform.GetChild(i).gameObject.GetComponent<Light>().color = Color.yellow;
            }
            else if (color == "verde")
            {
                iluminacion.gameObject.transform.GetChild(i).gameObject.GetComponent<Light>().color = Color.green;
            }
            else
            {
                iluminacion.gameObject.transform.GetChild(i).gameObject.GetComponent<Light>().color = Color.white;
            }
        }
    }

    public void CambiarIntencidad()
    {
        for (i = 0; i < iluminacion.gameObject.transform.childCount; i++)
        {
            iluminacion.gameObject.transform.GetChild(i).gameObject.GetComponent<Light>().intensity = sliderIntencidadLuz.gameObject.GetComponent<Slider>().value;
        }

    }

    

    public void ApagarEncenderLuces()
    {
        estaLuzActiva = false;

        for (i = 0; i < iluminacion.gameObject.transform.childCount; i++)
        {
            if (iluminacion.gameObject.transform.GetChild(i).gameObject.activeSelf)
            {
                estaLuzActiva = true;
                iluminacion.gameObject.transform.GetChild(i).gameObject.SetActive(false);
            }
            else
            {
                estaLuzActiva = false;
                iluminacion.gameObject.transform.GetChild(i).gameObject.SetActive(true);
            }
        }

        if (estaLuzActiva)
        {
            textApagarLuces.gameObject.GetComponent<TMP_Text>().text = "Encender Luz";
            for (i = 1; i < canvas.gameObject.transform.GetChild(0).gameObject.transform.childCount; i++)
            {
                canvas.gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        else
        {
            textApagarLuces.gameObject.GetComponent<TMP_Text>().text = "Apagar Luz";
            for (i = 1; i < canvas.gameObject.transform.GetChild(0).gameObject.transform.childCount; i++)
            {
                canvas.gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.SetActive(true);
            }

        }

    }


    


    
   
}