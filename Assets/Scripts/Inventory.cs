using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> _equipment = new List<Item>();

    public void AddItem(Item itemToReceive)
    {
        if (_equipment.Count < 3)
        {
            _equipment.Add(itemToReceive);
        }
        else
        {
            Notifications.Current.Create("Inventory is full!");
        }
    }
}

[CreateAssetMenu]
public class Item : ScriptableObject
{
    public new string name;
    public Sprite sprite;
    public GameObject mesh;
}