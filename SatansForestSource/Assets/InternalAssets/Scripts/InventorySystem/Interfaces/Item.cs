using System;
using UnityEngine;

namespace VioletHell.InventorySystem
{
    public abstract class Item : ScriptableObject
    {
        [field: SerializeField] public Sprite ItemSprite { get; private set; }
        
        [field: SerializeField] public string ItemName { get; private set; }
        [field: SerializeField] public string ItemDescription { get; private set; }
        
        [field: SerializeField] public GameObject ItemPrefab { get; private set; }

        public abstract Type GetItemType();
    }
}