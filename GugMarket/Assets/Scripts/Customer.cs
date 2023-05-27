using System.Collections;
using UnityEngine;
using NaughtyAttributes;


public class Customer : MonoBehaviour
{
    [Expandable] public CustomerData data;

    public SpriteRenderer hair;
    public SpriteRenderer head;
    public SpriteRenderer body;

    void Start()
    {

    }

    [Button]
    public void LoadCharacter()
    {
        if(data is null) return;
        LoadCharacter(data);
    }
    public void LoadCharacter(CustomerData customer)
    {
        hair.sprite = data.HairOrHat;
        head.sprite = data.Head;
        body.sprite = data.Body;
    }
}
