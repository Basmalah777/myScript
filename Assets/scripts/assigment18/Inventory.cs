using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{

    public class Inventory
    {
        private List<string> items;
        public Inventory()
        {
            items = new List<string>();
        }
        public void AddItem(string item)
        {
            items.Add(item);
        }

        public void ShowItems()
        {
            foreach (var item in items)
            {
                Debug.Log(item);
            }
        }

        public static Inventory operator +(Inventory inv1, Inventory inv2)
        {
            Inventory combinedInventory = new Inventory();

            // إضافة العناصر من المخزون الأول
            foreach (var item in inv1.items)
            {
                combinedInventory.AddItem(item);
            }

            // إضافة العناصر من المخزون الثاني
            foreach (var item in inv2.items)
            {
                combinedInventory.AddItem(item);
            }

            return combinedInventory;
        }

    }
}
