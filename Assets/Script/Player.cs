using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Entity entity;

    [Header("Player Regen System")]
    public bool regenHPEnable = true;
    public float regenHPTime = 5f;
    public int regenHPValue = 5;

    public bool regenMPEnable = true;
    public float regenMPTime = 10f;
    public int regenMPValue = 5;

    [Header("Game Manager")]
    public GameManager manager;

    [Header("Player UI")]
    public Slider health;
    public Slider mana;
    public Slider stamina;
    public Slider exp;

    void Start()
    {
        if (manager == null)
        {
            Debug.Log("Você precisa anexar o Game Manager no player");
            return;
        }

        entity.maxHealth = manager.CalculateHealth(entity);
        entity.maxMana = manager.CalculateMana(entity);
        entity.maxStamina = manager.CalculateStamina(entity);

        entity.currentHealth = entity.maxHealth;
        entity.currentHealth = entity.maxHealth;

        entity.currentMana = entity.maxMana;
        entity.currentStamina = entity.maxStamina;

        health.maxValue = entity.maxHealth;
        health.value = health.maxValue;

        mana.maxValue = entity.maxMana;
        mana.value = mana.maxValue;

        stamina.maxValue = entity.maxStamina;
        stamina.value = stamina.maxValue;

        exp.value = 0;

        // inicar regenHealth
        StartCoroutine(RegenHealth());
        StartCoroutine(RegenMana());
    }

    private void Update()
    {
        health.value = entity.currentHealth;
        mana.value = entity.currentMana;
        stamina.value = entity.currentStamina;
    }

    IEnumerator RegenHealth()
    {
        while(true) // loop infinito
        {
            if (regenHPEnable)
            {
                if (entity.currentHealth < entity.maxHealth)
                {
                    Debug.LogFormat("Recuperando HP do Jogador");
                    entity.currentHealth += regenHPValue;
                    yield return new WaitForSeconds(regenHPTime);
                }
                else
                {
                    yield return null;
                }
            }
        }
    }


    IEnumerator RegenMana()
    {
        while (true) // loop infinito
        {
            if (regenMPEnable)
            {
                if (entity.currentMana < entity.maxMana)
                {
                    Debug.LogFormat("Recuperando MP do Jogador");
                    entity.currentMana += regenMPValue;
                    yield return new WaitForSeconds(regenMPTime);
                }
                else
                {
                    yield return null;
                }
            }
        }
    }
}