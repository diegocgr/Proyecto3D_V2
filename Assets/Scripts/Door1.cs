using UnityEngine;

public class Door1 : MonoBehaviour
{
    private MeshRenderer mr;
    private Color originalColor;
    public Texture2D handCursor;
    private CursorMode cursorMode = CursorMode.Auto;
    private Vector2 hotSpot = Vector2.zero;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        originalColor = mr.material.color;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void OnMouseDown()
    {
        Debug.Log("He pulsado Door1");

        if (this.gameObject.GetComponent<Animator>().GetBool("estadoPuerta") == true)
        {
            this.gameObject.GetComponent<Animator>().SetBool("estadoPuerta", false);
        }
        else
        {
            this.gameObject.GetComponent<Animator>().SetBool("estadoPuerta", true);
        }
    }
    
    private void OnMouseEnter()
    {
        Cursor.SetCursor(handCursor, hotSpot, cursorMode);
        
        mr.material.color = Color.yellow;
        mr.material.EnableKeyword("_EMISSION");
        mr.material.SetColor("_EmissionColor", Color.yellow * 0.5f);
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
        
        mr.material.color = originalColor;
        mr.material.DisableKeyword("_EMISSION");
    }
}
