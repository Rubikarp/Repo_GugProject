using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PolygonCollider2D))]
public class Ingredient : MonoBehaviour,
    IPointerClickHandler,
    IBeginDragHandler,
    IEndDragHandler,
    IDragHandler
{

    public Rigidbody2D body;
    public SpriteRenderer sprite;
    public PolygonCollider2D collider;
    [Space(10)]
    [Expandable] public IngredientData data;
    [Space(10)]
    public InteractArea playArea;

    void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        body = GetComponent<Rigidbody2D>();
    }

    public void OnPointerClick(PointerEventData eventData)  { }
    public void OnBeginDrag(PointerEventData eventData)
    {
        body.constraints = RigidbodyConstraints2D.FreezeAll;
    }
    public void OnDrag(PointerEventData eventData)
    {
        body.position = InteractArea.Instance.GetMousePos();
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        body.position = InteractArea.Instance.GetMousePos();
        body.constraints = RigidbodyConstraints2D.None;
        body.velocity = eventData.delta / 10;
    }


    void Update()
    {
        
    }

}
