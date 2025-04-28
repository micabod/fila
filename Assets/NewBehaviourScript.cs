using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string codigoEntrada;
    public int cant;
    int precio;
    int precio_final;

    // Start is called before the first frame update
    void Start()
    {

        if(codigoEntrada!="b" && codigoEntrada!="n" && codigoEntrada != "p"){
            Debug.Log("codigo invalido");
            return;
        }
        if (codigoEntrada=="b" && cant>4 || codigoEntrada == "n" && cant>6){
            Debug.Log("Ingresar menor cantidad");
            return;
        }
        if (codigoEntrada=="b"){
            codigoEntrada="basico";
            precio=800;
        }
        if (codigoEntrada=="n"){
            codigoEntrada="normal";
            precio=1200;
        }
        if (codigoEntrada=="p"){
            codigoEntrada="premium";
            precio=2000;
        }
        precio_final=precio * cant;
        Debug.Log("La entrada es "+ codigoEntrada);
        Debug.Log("la cantidad es de"+ cant);
        Debug.Log("el precio es de"+precio_final);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
