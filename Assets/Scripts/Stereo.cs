using UnityEngine;

public class Stereo : MonoBehaviour
{

    private AudioSource audioSource;
    private bool isPaused = false;
    private MeshRenderer mr;
    private Color originalColor;
    public Texture2D handCursor;
    private CursorMode cursorMode = CursorMode.Auto;
    private Vector2 hotSpot = Vector2.zero;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        mr = GetComponent<MeshRenderer>();
        originalColor = mr.material.color;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        Debug.Log("He pulsado Stereo");

        if (!audioSource.isPlaying && !isPaused)
        {
            // Primera vez que se hace clic: reproducir
            audioSource.Play();
        }
        else if (audioSource.isPlaying)
        {
            // Si está sonando: pausarla
            audioSource.Pause();
            isPaused = true;
        }
        else if (isPaused)
        {
            // Si estaba pausada: reanudar
            audioSource.UnPause();
            isPaused = false;
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
