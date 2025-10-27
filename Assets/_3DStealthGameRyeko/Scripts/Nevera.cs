using UnityEngine;

public class Never : MonoBehaviour
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
        Debug.Log("estoy en la Nevera");
        if (this.gameObject.transform.parent.GetComponent<Animator>().GetBool("estadoNevera") == true)
        {
            this.gameObject.transform.parent.GetComponent<Animator>().SetBool("estadoNevera", false);
        }
        else
        {
            this.gameObject.transform.parent.GetComponent<Animator>().SetBool("estadoNevera", true);

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
