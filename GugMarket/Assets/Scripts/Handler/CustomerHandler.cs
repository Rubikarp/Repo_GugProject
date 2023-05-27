using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CustomerHandler : SingletonMonoBehaviour<CustomerHandler>
{
    public CustomerData[] customerPool;
    public List<Customer> customersList;
    public List<Transform> waitingPos;
    [Space(10)]
    public int activeCustomerIndex;

    void Start()
    {
        customerPool = customerPool.ShufleRandom();
        activeCustomerIndex = 0;
    }

    [Button]
    public void NextCustomer()
    {
        activeCustomerIndex++;

        if (activeCustomerIndex >= customerPool.Length) Start();

        for (int i = 1; i < customersList.Count; i++)
        {
            customersList[i].transform.DOMove(waitingPos[i].position, 0.5f).SetEase(Ease.InOutSine);
        }
        customersList[0].transform.position = waitingPos.Last().position;
        customersList[0].LoadRandomCharacter();

        var temp = customersList[0];
        customersList.RemoveAt(0);
        customersList.Add(temp);

    }

}
