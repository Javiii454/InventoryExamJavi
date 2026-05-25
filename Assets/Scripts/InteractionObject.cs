using UnityEngine;

public class InteractionObject : MonoBehaviour
{

    public ScriptableItem item;

    public SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer.sprite = item.itemSprite;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Item Recogido");
      InventoryManager.Instance.AddItem(item);
      Destroy(gameObject);
    }
}
