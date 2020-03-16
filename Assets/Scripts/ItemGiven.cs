using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGiven : MonoBehaviour
{
    [SerializeField] private Item itemToGive = null;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
            other.gameObject.GetComponent<Inventory>().AddItem(itemToGive);
    }
}
