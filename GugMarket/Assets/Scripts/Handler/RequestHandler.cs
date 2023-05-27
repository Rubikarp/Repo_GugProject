using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RequestHandler : SingletonMonoBehaviour<RequestHandler>
{
    public List<RequestData> requestPool;
    [Space(10)]
    public RequestData activeRequest;
    public TextMeshProUGUI requestTextArea;

    void Start()
    {

    }

    void Update()
    {

    }
}