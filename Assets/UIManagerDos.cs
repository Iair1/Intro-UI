using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagerDos : MonoBehaviour
{
    public TMP_InputField inputClave;
    public TextMeshProUGUI txtMensaje;
    string clave = "shakshuka";
    // Start is called before the first frame update
    void Start()
    {
        txtMensaje.text = string.Empty;

    }
    public void ComprobarClave()
    {
        string claveIngresada = inputClave.text;
        if(claveIngresada != clave)
        {
            txtMensaje.text = "Acceso denegado";
            inputClave.text = "";
        }
        else
        {
            txtMensaje.text = "Bienvenido.";
        }
    }
}
