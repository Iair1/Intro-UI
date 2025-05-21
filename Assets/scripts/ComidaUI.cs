using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ComidaUI : MonoBehaviour
{
    public TextMeshProUGUI txtResultado;
    public TMP_InputField inputCodigo;
    public TMP_InputField inputDias;
    string gatoCod = "G";
    string perroPCod = "PP";
    string perroGCod = "PG";
    int gatoGramos = 300;
    int perroPeqGramo = 400;
    int perroGranGramo = 700;
    float precioGramo = 80;
    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = string.Empty;
    }
    public void calcuG()
    {
        if(inputCodigo.text == string.Empty || inputDias.text == string.Empty)
        {
            txtResultado.text = "Debe rellear todos los campos.";
            return;
        }
        string codUs = inputCodigo.text;
        int dias = int.Parse(inputDias.text);
        int gramPorDia;
        int resultadoGram;
        float resultadoPre;
        if (dias < 3)
        {
            txtResultado.text = "Debe ingresar una cantidad de dias mayor a 3";
            return;
        }
        if(codUs == "G")
        {
            gramPorDia = gatoGramos;
        } else if(codUs == "PP")
        {
            gramPorDia = perroPeqGramo;
        } else if(codUs == "PG")
        {
            gramPorDia = perroGranGramo;
        } else
        {
            txtResultado.text = "Código no válido";
            return;
        }
        resultadoGram = gramPorDia * dias;
        resultadoPre = resultadoGram / 100 * precioGramo;
        txtResultado.text = $"Se usaran en total {resultadoGram} gramos para alimentar a su mascota. Eso equivale a un total de {resultadoPre} pesos a pagar.";
    }
}
