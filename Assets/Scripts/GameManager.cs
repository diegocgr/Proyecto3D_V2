using UnityEngine;
using UnityEngine.SceneManagement;
// using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    [Header("UI")]
    public GameObject panelMenu;

    [Header("Cámaras")]
    public Camera cameraRoom1;
    public Camera cameraRoom2;
    public Camera cameraKitchen;
    public Camera cameraBathroom;
    public Camera cameraExterior;

    [Header("Jugador (FPS Controller)")]
    public GameObject playerController;

    private Camera currentCamera;
    private bool isMenuOpen = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // El menú empieza oculto
        panelMenu.SetActive(false);

         // Forzar estado inicial de cámaras
        cameraRoom1.enabled = true;
        cameraRoom2.enabled = false;
        cameraKitchen.enabled = false;
        cameraBathroom.enabled = false;
        cameraExterior.enabled = false;
        playerController.SetActive(false);

        currentCamera = cameraRoom1;
    }

    // Update is called once per frame
    void Update()
    {
        // Al pulsar Escape, abrir/cerrar menú
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu();
        }
    }

    // ----------- MENÚ ----------
    private void ToggleMenu()
    {
        isMenuOpen = !isMenuOpen;
        panelMenu.SetActive(isMenuOpen);

        if (isMenuOpen)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            // Pausa movimiento del jugador (si está activo)
            if (playerController.activeSelf)
            {
                var controller = playerController.GetComponent<StarterAssets.FirstPersonController>();
                controller.enabled = false;
            }
        }
        else
        {
            // Reanuda si estás en vista FPS
            if (playerController.activeSelf)
            {
                var controller = playerController.GetComponent<StarterAssets.FirstPersonController>();
                controller.enabled = true;

                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }

    // ----------- CAMBIO DE CÁMARAS -----------
    private void SetActiveCamera(Camera newCamera)
    {
        if (currentCamera != null)
            currentCamera.enabled = false;

        newCamera.enabled = true;
        currentCamera = newCamera;

        // Desactiva jugador y su cámara
        playerController.SetActive(false);
    }
    
    public void ViewRoom1()   { Debug.Log("Cambiando a Room1");SetActiveCamera(cameraRoom1); }
    public void ViewRoom2() { Debug.Log("Cambiando a Room2");SetActiveCamera(cameraRoom2); }
    public void ViewKitchen()   { Debug.Log("Cambiando a Kitchen");SetActiveCamera(cameraKitchen); }
    public void ViewBathroom()  { Debug.Log("Cambiando a Bathroom");SetActiveCamera(cameraBathroom); }
    public void ViewExterior() { Debug.Log("Cambiando a Exterior"); SetActiveCamera(cameraExterior); }

    // ----------- ACTIVAR FPS MODE -----------
    public void ViewFirstPerson()
    {
        // Desactiva cámaras estáticas
        if (currentCamera != null)
            currentCamera.enabled = false;

        // Activa jugador y su cámara
        playerController.SetActive(true);

        // Bloquea ratón
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // ----------- VOLVER AL MENÚ PRINCIPAL -----------
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MenuPrincipalScene");
    }
}
