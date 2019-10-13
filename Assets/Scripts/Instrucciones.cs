using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instrucciones : MonoBehaviour
{
    public GameObject LetsBattle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

   

    public void CambiareScena()
    {
        SceneManager.LoadScene("LOTE", LoadSceneMode.Single);
    }
}

