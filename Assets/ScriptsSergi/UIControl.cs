using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class UI : MonoBehaviour
{

    [SerializeField]
    private GameObject canvas;
    [SerializeField]
    private GameObject camaras;
    private int i;
    [SerializeField]
    private GameObject fps;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;

    }
    public void CambiarCamaras(int posCamara)
    {
        for (i=0; i< camaras.gameObject.transform.childCount; i++)
        {
            camaras.gameObject.transform.GetChild(i).gameObject.SetActive(false);
            camaras.gameObject.transform.GetChild(posCamara).gameObject.SetActive(true);
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))

        {
            if (canvas.gameObject.activeSelf)

            {
                fps.gameObject.GetComponent<FirstPersonController>().enabled = true;
                fps.gameObject.transform.GetChild(0).gameObject.GetComponent<Camera>().depth = 100;
               
                canvas.gameObject.SetActive(false); }

            else { canvas.gameObject.SetActive(true); 
                
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                fps.gameObject.GetComponent<FirstPersonController>().enabled = false;
                fps.gameObject.transform.GetChild(0).gameObject.GetComponent<Camera>().depth = -100;
            }
        }



    }
}
