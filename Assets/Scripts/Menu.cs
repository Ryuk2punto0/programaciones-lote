using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Inicio;
    // Start is called before the first frame update
    void Start()
    {
        Inicio.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AbrirInicio()
    {
        Inicio.SetActive (true);
    }

    public void CambiareScena()
    {
        SceneManager.LoadScene("LOTE", LoadSceneMode.Single);
    }
}
