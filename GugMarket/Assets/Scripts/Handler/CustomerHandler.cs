using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CustomerHandler : SingletonMonoBehaviour<CustomerHandler>
{
    public List<Customer> customersList;
    public List<Transform> waitingPos;

    [Button]
    public void NextCustomer()
    {
        customersList[0].LoadRandomCharacter();
        customersList[0].transform.position = waitingPos.Last().position;
        for (int i = 1; i < customersList.Count; i++)
        {
            customersList[i].transform.DOMove(waitingPos[i].position, 0.5f).SetEase(Ease.InOutSine);
        }

        var temp = customersList[0];
        customersList.RemoveAt(0);
        customersList.Add(temp);

    }

}
