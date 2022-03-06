using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);

    bool hasPackage;
    [SerializeField] float destroyTime = 0.3f;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Crush...!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyTime);
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }

}
