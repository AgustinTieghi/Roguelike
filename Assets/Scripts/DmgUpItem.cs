using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgUpItem : MonoBehaviour, Itemizable
{
    public int dmgBuff;   

    public void ApplyItemEffect()
    {
        PlayerStats.instance.GetDmgBuffed(dmgBuff);
        Destroy(gameObject);
    }
}
