using UnityEngine;

public class Interacciones : MonoBehaviour
{

    private void OnMouseDown()
    {
        if (this.gameObject.transform.GetChild(0).gameObject.activeSelf)
        
        { this.gameObject.transform.GetChild(0).gameObject.SetActive(false); }
        
        else
        { this.gameObject.transform.GetChild(0).gameObject.SetActive(true); }

    }

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
