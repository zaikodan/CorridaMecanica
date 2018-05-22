using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : MonoBehaviour {

    bool rodou = false;
    int numero;

    public void Move()
    {
        NavMeshAgent Agent = GetComponent<NavMeshAgent>();
        
    }




    //Passa direto para o proximo trajeto
    private void Atalho()
    {

    }

    //Volta duas casas
    private void OleoNaPista()
    {

    }

    //Fica uma rodada sem jogar
    private void SaiuDaPista()
    {
        rodou = true;
    }

    //Avança 3 casas
    private void DriftKing()
    {

    }

    //Avança 2 casas
    private void BomTracado()
    {

    }

    //Ganha um item
    private void Item()
    {

    }

    //Anda metade das casas
    private void NeblinaNaPista()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {

        }
    }

}
