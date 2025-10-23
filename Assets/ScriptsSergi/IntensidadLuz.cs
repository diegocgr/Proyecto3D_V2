using UnityEngine;
using UnityEngine.UI;

public class IntensidadLuz : MonoBehaviour
{
    public Light luz;
    public Slider barra;

    void Update()
    {
        luz.intensity = barra.value;
    }
}
