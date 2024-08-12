using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControllers : MonoBehaviour
{
    [SerializeField] private int min;  // Tiempo en minutos
    [SerializeField] private int seg;  // Tiempo en segundos
    [SerializeField] private Text tiempo;  // Referencia al componente Text para mostrar el tiempo
    [SerializeField] private GameObject panelPerder;  // Referencia al panel "Perder"
    [SerializeField] private GameObject panelGanar;  // Referencia al panel "Perder"

    private float restante;  // Tiempo restante en segundos
    private bool enMarcha;  // Indica si el cronómetro está en marcha

    private void Awake() 
    {
        restante = (min * 60) + seg;  // Convierte el tiempo a segundos
        enMarcha = true;  // Inicia el cronómetro
        panelPerder.SetActive(false);  // Asegura que el panel "Perder" esté desactivado al inicio
    }

    // Update es llamado una vez por frame
    void Update()
    {
        if (enMarcha) 
        {
            restante -= Time.deltaTime;  // Decrementa el tiempo restante

            if (restante <= 0)
            {
                restante = 0;
                enMarcha = false;  // Detiene el cronómetro cuando se llega a 0
                Time.timeScale = 0;  // Pausa el juego
                MostrarPanelPerder();  // Llama a la función para mostrar el panel "Perder"
            }

            // Calcula los minutos y segundos restantes
            int tempMin = Mathf.FloorToInt(restante / 60);
            int tempSeg = Mathf.FloorToInt(restante % 60);

            // Actualiza el texto del cronómetro en la interfaz de usuario
            tiempo.text = $"{tempMin:00}:{tempSeg:00}";
        }
        if (GameObject.FindWithTag("Player") == null){
            panelGanar.SetActive(true);
        }
    }

    // Función para mostrar el panel "Perder"
    private void MostrarPanelPerder()
    {
        panelPerder.SetActive(true);  // Activa el panel "Perder"
        Debug.Log("¡Tiempo agotado! Mostrando panel de derrota.");  // Muestra un mensaje en la consola
    }
}


