using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using NaughtyAttributes;

public class RequestHandler : SingletonMonoBehaviour<RequestHandler>
{
    public RequestData[] requestPool;
    public UnityEvent OnDayEnd;
    [Space(10)]
    public RequestData activeRequest;
    public TextMeshProUGUI requestTextArea;
    public int index;

    private void Awake()
    {
        requestPool.ShufleRandom();

        activeRequest = requestPool[0];
        requestTextArea.text = activeRequest.linkedRequest;
    }

    [Button]
    public void NextRequest()
    {
        index++;

        if (index >= requestPool.Length)
        {
            OnDayEnd?.Invoke();
        }
        else
        {
            activeRequest = requestPool[index];
            requestTextArea.text = activeRequest.linkedRequest;
        }
    }
}