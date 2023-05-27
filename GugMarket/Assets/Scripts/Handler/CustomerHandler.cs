using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        //TODO : Movement
        //TODO : Generate New BG character
    }

}
