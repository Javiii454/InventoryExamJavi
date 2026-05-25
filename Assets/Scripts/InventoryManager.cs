using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{

    public static InventoryManager Instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if(Instance != this && Instance != null)
        {
            Destroy(gameObject);

        }
        else
        {
            Instance = this;
        }
    }

    public ScriptableItem[] items;
    
    public Text[] itemNames;

    public Image[] itemImages;

    
    public void AddItem(ScriptableItem item)
    {
        for(int i = 0; i < items.Length; i++)
        {
            if(items[i] == null)
            {
                items[i] = item;
                itemNames[i].text = item.itemName;
                itemImages[i].sprite = item.itemSprite;

                return;
            }
            

            
        }

    }
}
