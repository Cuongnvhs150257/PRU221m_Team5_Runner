using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFactory : ItemAbstractFactory
{
    // Start is called before the first frame update
    private GameObject prefab;

    private List<string> itemNames;


    public override GameObject CreateItem()
    {
        itemNames = new List<string>();

        itemNames.Add("Apple");
        itemNames.Add("Ice");
        itemNames.Add("Heart");
        itemNames.Add("Shield");

        for (int i = 0; i < itemNames.Count; i++)
        {
            prefab = Resources.Load<GameObject>(itemNames[Random.Range(0, itemNames.Count)]);
        }
        GameObject item = Instantiate(prefab);
        //item item = itemGO.GetComponent<item>();
        return item;
    }
}
