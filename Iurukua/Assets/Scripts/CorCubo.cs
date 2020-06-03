using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorCubo : MonoBehaviour
{
    public Color corInicial = Color.white;
    Material materialObjeto;

    // Start is called before the first frame update
    void Start()
    {
        materialObjeto = GetComponent<MeshRenderer>().material;
        materialObjeto.color = corInicial;
    }

    public void Azul()
    {
        corInicial = Color.blue;

        materialObjeto = GetComponent<MeshRenderer>().material;
        materialObjeto.color = corInicial;
    }

    public void Vermelho()
    {
        corInicial = Color.red;

        materialObjeto = GetComponent<MeshRenderer>().material;
        materialObjeto.color = corInicial;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
