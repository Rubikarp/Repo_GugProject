using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class Blender : MonoBehaviour
{
    public UnityEvent OnAddedElement;
    private void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Ingredient>())
        {
            KitchenHandler.Instance.currentDish.AddIngredients(collision.GetComponent<Ingredient>().data);
            Destroy(collision.gameObject);
            OnAddedElement?.Invoke();
        }
    }
}
