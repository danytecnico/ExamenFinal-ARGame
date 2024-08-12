using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escena1 : MonoBehaviour
{
    // Start is called before the first frame update
   // Referencia al panel Escena2
    public GameObject escena2Panel;

    void Start()
    {
        // Asegúrate de que el panel Escena2 esté desactivado al inicio
        escena2Panel.SetActive(false);
    }

    void Update()
    {
        // Detectar si se ha hecho clic en la pantalla
        if (Input.GetMouseButtonDown(0)) // 0 es el botón izquierdo del ratón
        {
            MostrarPanelEscena2();
        }
    }

    void MostrarPanelEscena2()
    {
        // Activa el panel Escena2 sin desactivar el panel Escena1
        escena2Panel.SetActive(true);
    }
}
