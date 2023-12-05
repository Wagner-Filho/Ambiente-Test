using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste2D : MonoBehaviour
{
    [SerializeField] string _nome;
    [SerializeField] bool _vivo;
    [SerializeField] int _vida;
    [SerializeField] float _velocidade;
    [SerializeField] bool _Hit;
    [SerializeField] bool _voar;
    [SerializeField] int _velocidadeAndando;
    [SerializeField] int _fase;
    [SerializeField] bool _andar;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void Checknome()
    {
        if (_nome == "player")
        {
            Debug.Log("jogador tem o nome player");
        }
        else
        {
            Debug.Log("jogador N�o tem o nome player");
        }
    }
    void CheckMorto()
    {
        if (_vida >= 3)
        {
            Debug.Log("jogador est� forte");
        }
        else if (_vida >= 1)
        {
            Debug.Log("jogador est� fraco");
        }
        else
        {
            Debug.Log("jogador est� morto");
        }
    }
    void Checkvida()
    {
        if (_vida == 1)
        {
            Debug.Log("jogador tem 1 de vida");
        }
        else
        {
            Debug.Log("jogador N�o tem 1 de vida");
        }
    }
    void CheckVelocidade()
    {
        if (_velocidade > 1)
        {
            Debug.Log("jogador est� rapido");
        }
        else
        {
            Debug.Log("jogador est� lento");
        }
    }
    void CheckHit()
    {
        if (_Hit == true)
        {
            Debug.Log("perde ponto de vida");
        }
        else
        {
            Debug.Log("n�o perde ponto de vida");
        }
    }

    void checkVoarAndar()
    {
        if (_voar)
        {
            Debug.Log("N�o pode Pular");
        }
        else if (_velocidadeAndando > 0)
        {
            Debug.Log("N�o pode voar");
        }
    }

    void checkFase()
    {
        if (_fase == 3)
        {
            Debug.Log("Fase Final");
        }
        else if (!_andar)
        {
            Debug.Log("Movimente-se");
        }
        else
        {
            Debug.Log("Aguardando...");
        }
    }
}
