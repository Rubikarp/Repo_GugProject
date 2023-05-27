using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WinLoose : MonoBehaviour
{
    public RequestHandler request;
    public KitchenHandler kitchen;

    public UnityEvent OnHappy;
    public UnityEvent OnAngry;

    public void Evaluate()
    {
        if (request.activeRequest.aimedRecipe.GetDistance(kitchen.currentDish) < 5f)
        {
            OnHappy?.Invoke();
        }
        else
        {
            OnAngry?.Invoke();
        }
    }
}
