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
        int num1 = int.Parse(inputNumero.text);
        if(num1 < 1)
        {
            txtResult.text = "PON UN NÚMERO MAYOR A 0";
        }else if(num1 % 2 == 1)
        {
            txtResult.text = $"El número {num1} es impar";
        }
        else
        {
            txtResult.text = $"El número {num1} es par";
        }
    }
}
