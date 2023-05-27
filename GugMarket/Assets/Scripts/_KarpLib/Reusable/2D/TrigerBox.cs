using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class TrigerBox : MonoBehaviour
{
    public UnityEvent<Collider2D> OnTriggerEnter;
    public UnityEvent<Collider2D> OnTriggerStay;
    public UnityEvent<Collider2D> OnTriggerExit;

    private void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D collision) => OnTriggerEnter?.Invoke(collision);
    private void OnTriggerStay2D(Collider2D collision) => OnTriggerStay?.Invoke(collision);
    private void OnTriggerExit2D(Collider2D collision) => OnTriggerExit?.Invoke(collision);

}
