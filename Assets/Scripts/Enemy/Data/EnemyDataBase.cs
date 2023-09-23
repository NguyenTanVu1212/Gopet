using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public abstract class EnemyDataBase : MonoBehaviour
{
    #region variable
    private float maxHP;
    private float maxMana;
    private float currentHp;
    private float currentMana;
    private float baseDamage;
    private float currentDamage;

    public float MaxHP { get => maxHP; set => maxHP = value; }
    public float MaxMana { get => maxMana; set => maxMana = value; }
    public float CurrentHp { get => currentHp; set => currentHp = value; }
    public float CurrentMana { get => currentMana; set => currentMana = value; }
    public float BaseDamage { get => baseDamage; set => baseDamage = value; }
    public float CurrentDamage { get => currentDamage; set => currentDamage = value; }
    #endregion
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnDamage(float hp ,Action callback = null )
    {
        callback?.Invoke();
        this.currentHp -= hp;
    }
}
