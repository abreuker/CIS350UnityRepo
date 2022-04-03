using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
/*
 * Anna Breuker
 * Assignment 6
 * A class for an inventory that showcases [SerializeField] objects.
 */
public class Inventory : MonoBehaviour
{

    [SerializeField] private InventoryItem item;
    public List<InventoryItem> inventory;

    // Start is called before the first frame update
    void Start()
    {
        item = new InventoryItem();
        inventory = new List<InventoryItem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
