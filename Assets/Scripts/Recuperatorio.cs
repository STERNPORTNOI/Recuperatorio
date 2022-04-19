using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recuperatorio : MonoBehaviour
{
    public string Codigo_Helado;
    public int Cantidad_Gramos;

    // Start is called before the first frame update
    void Start()
    {
        float precio = Cantidad_Gramos * 0.5f;
        float descuento = precio / 10;
        float precio_descuento = precio - descuento ;

        if (Cantidad_Gramos < 250 || Cantidad_Gramos > 3000)
        {
            Debug.Log("Hubo un error con alguno de los datos ingresados, rebice las condiciones solicitadas.");
        }

        else
        {
            if (Codigo_Helado == "CHO")
            {
                Debug.Log("El precio por " + Cantidad_Gramos + " gramos de chocolate es de $" + precio);
            }

            else if (Codigo_Helado == "DDL")
            {
                Debug.Log("El precio por " + Cantidad_Gramos + " gramos de dulce de leche es de $" + precio);
            }

            else if (Codigo_Helado == "FRU")
            {
                Debug.Log("El precio por " + Cantidad_Gramos + " gramos de frtutilla es de $" + precio_descuento);
            }

            else
            {
                Debug.Log("El codigo del helado no exciste, seleccione uno válido.");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
