using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeDrop : MonoBehaviour, Droppable
{
    [SerializeField] private int regenAmount;
    public void ApplyDropEffect()
    {
        PlayerStats.instance.RegenerateHP(regenAmount);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 6)
        {
            ApplyDropEffect();
            Destroy(gameObject);
        }      
    }
}
