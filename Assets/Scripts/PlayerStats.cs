using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int dmg;
    [SerializeField] private int hp;
    [SerializeField] private int maxHP;
    public static PlayerStats instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    void Start()
    {
        hp = maxHP;
    }


    void Update()
    {

    }

    public void GetDmgBuffed(int dmgAmount)
    {
        dmg += dmgAmount;
    }

    public void RegenerateHP(int hpAmount)
    {
        float hpLeft = maxHP - hp;
        float hpToRegen = Mathf.Clamp(hpAmount, 0, hpLeft);
        hp += (int)hpToRegen;
    }

}
