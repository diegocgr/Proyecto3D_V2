using UnityEngine;

public class Ventana : MonoBehaviour
{

    private void OnMouseDown()

    { this.gameObject.transform.GetComponent<Animator>().SetBool("EstadoVentana", true); }

    private void OnMouseEnter()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
    }

    private void OnMouseExit()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
