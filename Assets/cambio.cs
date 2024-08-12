using UnityEngine;
using UnityEngine.SceneManagement;

public class cambio : MonoBehaviour
{
    // Start is called before the first frame update
    public void regresarmenup(){
        SceneManager.LoadSceneAsync(0);
    }

    public void Quit(){
        Application.Quit();
    }

  
}