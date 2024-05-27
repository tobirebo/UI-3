using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogInManager : MonoBehaviour
{
    public string contrasenia = "matoso246";
    public InputField contraseniauser;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BotonPresionado()
    {
        if (contrasenia == contraseniauser.text)
        {
            Debug.Log("entraste");
        }
        else
        {
            Debug.Log("no entraste");
        }
    }
}
