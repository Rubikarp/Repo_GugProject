using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
public class Ingredient : MonoBehaviour,
    IPointerClickHandler,
    IBeginDragHandler,
    IEndDragHandler,
    IDragHandler
{

    public SpriteRenderer sprite;
    public Rigidbody2D body;
    public IngredientData data;

    public InteractArea playArea;
    private Vector3 StartGrabPos;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        body = GetComponent<Rigidbody2D>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        StartGrabPos = InteractArea.Instance.GetMousePos();
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
