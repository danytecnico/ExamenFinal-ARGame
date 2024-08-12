using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escena2 : MonoBehaviour
{
    // Referencia al panel Escena3
    public GameObject escena3Panel;

    void Start()
    {
        // Asegúrate de que el panel Escena3 esté desactivado al inicio
        escena3Panel.SetActive(false);
    }

    void Update()
    {
        // Detectar si se ha hecho clic en la pantalla
        if (Input.GetMouseButtonDown(0)) // 0 es el botón izquierdo del ratón
        {
            MostrarPanelEscena3();
        }
    }

    void MostrarPanelEscena3()
    {
        // Activa el panel Escena3
        escena3Panel.SetActive(true);
    }
}
