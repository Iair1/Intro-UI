using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI txtNombre;
    public TMP_InputField inputNombre;
    string nombreIngresado;
    void Start()
    {
        txtNombre.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Saludar()
    {
        //obtener el input
        nombreIngresado = inputNombre.text;
        //concatenar nombre y saludo
        txtNombre.text = "Hola " + nombreIngresado + "!";
        //mostrar saludo
    }
}
