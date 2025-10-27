using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using System.Collections;

public class Player3D : MonoBehaviour
{
    [SerializeField]
    private DialogController dialogController; // メッセージ管理用

    private DialogMessage triggerMessage;
    private Coroutine hideCoroutine;

    [SerializeField]
    private Texture2D manoGato;


    private void Start()
    {
        Cursor.SetCursor(manoGato, Vector2.zero, CursorMode.Auto);

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Entrance")
        {
            if (other.gameObject.transform.GetChild(2).GetComponent<Animator>())
            {
                other.gameObject.transform.GetChild(2).GetComponent<Animator>().Play("CerrarEntrada");
            }
        }
        /*
        if (triggerMessage != null)
        {
            dialogController.HideDialog();
            triggerMessage = null;
        }
        */

        if (other.gameObject.tag == "Skull")
        {


           
            if (hideCoroutine != null)
            {
                StopCoroutine(hideCoroutine);
            }
            hideCoroutine = StartCoroutine(HideDialogAfterSeconds(3f));
            

        }

    }



    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter: " + other.gameObject.name + " / Tag: " + other.gameObject.tag);

        if (other.gameObject.tag == "Entrance")
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

        if (other.gameObject.tag == "Pumpkin")
        {
            triggerMessage = other.GetComponent<DialogMessage>();

            if (triggerMessage == null)
                Debug.LogWarning("DialogMessage がついていません: " + other.gameObject.name);

            if (triggerMessage != null && dialogController != null)
            {
                // メッセージ表示
                dialogController.ShowDialog(triggerMessage.CharacterName, triggerMessage.Message);

                // 既に消去コルーチンがあれば停止
                if (hideCoroutine != null)
                {
                    StopCoroutine(hideCoroutine);
                }

                // 3秒後に自動でメッセージを消すコルーチンを開始
                hideCoroutine = StartCoroutine(HideDialogAfterSeconds(3f));
            }
        }

        if (other.gameObject.tag == "Skull")
        {


            if (dialogController != null)
            {
                dialogController.ShowDialog("Skull", "Alright, today’s unlucky victim is… oh, it’s you! Little Mortal, my bones can’t stop chuckling!"); // トグル表示
            }
            // triggerMessage = other.GetComponent<DialogMessage>();
            //triggerMessage.Message = "texto de skull";
            /*if (triggerMessage == null)
                Debug.LogWarning("DialogMessage がついていません: " + other.gameObject.name);

            if (triggerMessage != null && dialogController != null)
            {
                // メッセージ表示
                dialogController.ShowDialog(triggerMessage.CharacterName, triggerMessage.Message);*/

            // 既に消去コルーチンがあれば停止
            /* if (hideCoroutine != null)
            {
                StopCoroutine(hideCoroutine);
            }

            // 3秒後に自動でメッセージを消すコルーチンを開始
            hideCoroutine = StartCoroutine(HideDialogAfterSeconds(3f));
            */
        
        }



    }

    // コルーチンで一定時間後にメッセージを消す
    private IEnumerator HideDialogAfterSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        if (dialogController != null)
        {
            dialogController.HideDialog();
        }

        triggerMessage = null;
        hideCoroutine = null;

    }
}

    /*
    // コライダーが "MessageTrigger" タグを持っていた場合に表示
    if (other.gameObject.tag == "Pumpkin")
    {
        // トリガーにメッセージ情報を持たせておく
        triggerMessage = other.gameObject.GetComponent<DialogMessage>();
        if (triggerMessage != null)
        {
            // DialogController にメッセージを表示させる
            dialogController.ShowDialog(triggerMessage.CharacterName, triggerMessage.Message);
        }
    }
    */




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

