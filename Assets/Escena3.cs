using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escena3 : MonoBehaviour
{
    public GameObject escena4Panel;

    void Start()
    {
        // Asegúrate de que el panel Escena3 esté desactivado al inicio
        escena4Panel.SetActive(false);
    }

    void Update()
    {
        // Detectar si se ha hecho clic en la pantalla
        if (Input.GetMouseButtonDown(0)) // 0 es el botón izquierdo del ratón
        {
            MostrarPanelEscena4();
        }
    }

    void MostrarPanelEscena4()
    {
        // Activa el panel Escena3
        escena4Panel.SetActive(true);
    }
}
