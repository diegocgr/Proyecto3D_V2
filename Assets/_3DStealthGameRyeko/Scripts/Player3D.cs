using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player3D : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Entrance")
        {
            if (other.gameObject.transform.GetChild(2).GetComponent<Animator>())
            {
                other.gameObject.transform.GetChild(2).GetComponent<Animator>().Play("CerrarEntrada");
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Entrance")
        {
            if (other.gameObject.transform.GetChild(2).GetComponent<Animator>()) 
            {
                other.gameObject.transform.GetChild(2).GetComponent<Animator>().Play("AbrirEntrada");
            }
        }
        if (other.gameObject.tag == "Gargoyle")
        {
            if (other.gameObject.GetComponent<Animator>())
            {
                other.gameObject.GetComponent<Animator>().Play("ZombieAttack");
            }
        }

    }
    //Accion o evento al conseguir o recoger una moneda
    //public static Action<int> OnConseguirMoneda;

    //public static Func<int, int> OnConseguirMoneda;


    /*
    private int misMonedas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        misMonedas = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnControllerColliderHit(ControllerColliderHit other)
    {
        if (other.gameObject.tag == "Cubo")
        {
            Debug.Log("Detecto cubo");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Moneda")
        {
            //Action
            //OnConseguirMoneda?.Invoke(10,"hola");

            //Func
            //misMonedas =  (int) OnConseguirMoneda?.Invoke(10);
            //Debug.Log("Cantidad de monedas que tengo: " + misMonedas);


            ControladorEventos.OnConseguirMoneda?.Invoke(10);

        }
        if (other.gameObject.tag == "MonedaGrande")
        {
            //misMonedas = (int)OnConseguirMoneda?.Invoke(100);
            //Debug.Log("Cantidad de monedas que tengo: " + misMonedas);

            ControladorEventos.OnConseguirMoneda?.Invoke(100);
        }

        if (other.gameObject.tag == "Vida")
        {
            //misMonedas = (int)OnConseguirMoneda?.Invoke(100);
            //Debug.Log("Cantidad de monedas que tengo: " + misMonedas);

            ControladorEventos.LanzarConseguirVida(5);
        }
    }
    */
}
    