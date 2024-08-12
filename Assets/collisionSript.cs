using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionScript : MonoBehaviour {
    public int inc;

  // Use this for initialization
    void Start () {
      inc = 0;
    }

    // Update is called once per frame
    void Update () {

    }

    // Para que esto funcione, ambos necesitan colisionadores, 
    // uno debe tener un cuerpo rígido (nave espacial) y el otro debe tener un gatillo activado.
    void OnTriggerEnter (Collider col)
    {
        GameObject explosion = Instantiate(Resources.Load("FlareMobile", typeof(GameObject))) as GameObject;
        explosion.transform.position = transform.position;
        Destroy(col.gameObject);
        Destroy(explosion, 2);
        inc = inc + 1;
        Debug.Log(inc);

        if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            // Instanciar enemigos
            GameObject enemy = Instantiate(Resources.Load("enemy", typeof(GameObject))) as GameObject;
            GameObject enemy1 = Instantiate(Resources.Load("enemy1", typeof(GameObject))) as GameObject;
            GameObject enemy2 = Instantiate(Resources.Load("enemy2", typeof(GameObject))) as GameObject;
            GameObject enemy3 = Instantiate(Resources.Load("enemy3", typeof(GameObject))) as GameObject;

            // Llamar a la función para mostrar el mensaje
            ShowCompletionMessage();
        }

        Destroy(gameObject);



    }

    void ShowCompletionMessage()
    {
        Debug.Log("¡Has superado la prueba!");
    }

}
