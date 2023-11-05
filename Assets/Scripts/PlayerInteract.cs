using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private float raycastMaxRange;
    [SerializeField] private LayerMask itemLayer;
   
    void Start()
    {

    }


    void Update()
    {
        RaycastHit hit;
        Ray raycast = new Ray(this.transform.position, this.transform.forward);
        if (Physics.Raycast(raycast, out hit, raycastMaxRange, itemLayer))
        {
            if (StarterAssetsInputs.instace.interact)
            {
                hit.collider.gameObject.GetComponent<Itemizable>().ApplyItemEffect();
            }
        }           
    }


    private void OnDrawGizmos()
    {
       Gizmos.color = Color.green;
       Gizmos.DrawRay(this.transform.position,this.transform.forward);
    }
}
