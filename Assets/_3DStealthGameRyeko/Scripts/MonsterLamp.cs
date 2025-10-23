using UnityEngine;

public class MonsterLamp : MonoBehaviour
{
    private void OnMouseEnter()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.clear;
    }
    private void OnMouseExit()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
    }
    private void OnMouseDown()
    {
        Debug.Log("he pulsado la lampara");
        if (this.gameObject.transform.GetChild(0).gameObject.activeSelf)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }

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
