using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class parOImparManager : MonoBehaviour
    
{
    public TextMeshProUGUI txtResult;
    public TMP_InputField inputNumero;
    // Start is called before the first frame update
    void Start()
    {
        txtResult.text = string.Empty;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void paroimpar()
    {
        int numero = int.Parse(inputNumero.text);
        if(numero < 1)
        {
            txtResult.text = "PON UN NÚMERO MAYOR A 0";
        }else if(numero % 2 == 1)
        {
            txtResult.text = "El número es impar";
        }
        else
        {
            txtResult.text = "El numero es par";
        }
    }
}
