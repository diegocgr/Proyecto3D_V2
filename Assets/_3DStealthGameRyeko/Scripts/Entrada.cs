using UnityEngine;

public class Entrada : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (this.gameObject.GetComponent<Animator>().GetBool("EstadoEntrada")==true)
        {
            this.gameObject.GetComponent<Animator>().SetBool("EstadoEntrada",false);
        }
        else
        {
            this.gameObject.GetComponent<Animator>().SetBool("EstadoEntrada", true);
        }
    }


    private void OnMouseEnter()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.clear;
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
