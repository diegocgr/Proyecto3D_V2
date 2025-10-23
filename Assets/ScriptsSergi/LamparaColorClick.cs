using UnityEngine;

public class LamparaColorClick : MonoBehaviour
{
    public Light targetLight; // Asigna la luz en el inspector

    // Este método lo llamará el botón
    

    // También podrías crear versiones fijas:
    public void SetColorRed() => targetLight.color = Color.red;
    public void SetColorBlue() => targetLight.color = Color.blue;
    public void SetColorGreen() => targetLight.color = Color.green;
}
