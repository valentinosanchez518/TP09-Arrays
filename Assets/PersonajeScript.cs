using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeScript : MonoBehaviour
{
    public int nivelHambre;
    public AlimentoScript alimento;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TomarAlimento(int valorAlimentario)
    {
        nivelHambre -= valorAlimentario;
        if (nivelHambre <= 0)
        {
            nivelHambre = 0;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        AlimentoScript alimento;
        alimento = other.GetComponent<AlimentoScript>();
        TomarAlimento(alimento.valorAlimentario);

    }
}

