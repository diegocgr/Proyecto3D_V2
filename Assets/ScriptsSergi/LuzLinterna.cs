using System;
using UnityEngine;

public class LuzLinterna : MonoBehaviour
{
    
    [SerializeField]
    private GameObject luzlinterna;
    private int i;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ApagarEncenderLuces()
    {
        for (i=0; i< luzlinterna.gameObject.transform.childCount; i++)
        {
            luzlinterna.gameObject.transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    public void ToggleActive()
    {
        if (luzlinterna != null)
        {
            // Cambia el estado de activación
            luzlinterna.SetActive(!luzlinterna.activeSelf);
        }
    }

}

