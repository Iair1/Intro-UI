using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagerDos : MonoBehaviour
{
    public TMP_InputField inputClave;
    public TMP_InputField inputUsuario;
    public TextMeshProUGUI txtMensaje;
    string clave = "shakshuka";
    string usuario = "comida";
    // Start is called before the first frame update
    void Start()
    {
        txtMensaje.text = string.Empty;

    }
    public void ComprobarClave()
    {
        string claveIngresada = inputClave.text;
        string usuarioIngresado = inputUsuario.text;
        if(claveIngresada != clave || usuarioIngresado != usuario)
        {
            txtMensaje.text = "Usuario o contraseña incorrectos";
            inputClave.text = "";
        }
        else
        {
            txtMensaje.text = "Bienvenido.";
        }
    }
}
