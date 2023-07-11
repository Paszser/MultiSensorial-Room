using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendToGoogle : MonoBehaviour
{
    private string _name = "TestUser";
    private string _scoreBalloon;
    private string _scoreLeFishe;

    [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLScDnrVuUqnbq-Sz5KsBFKMr9PkDbPmxlMupo13oxLYS-144WA/formResponse";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    public void Send()
    {
        _name = "TestUser";
        _scoreBalloon = BalloonSys._counter.ToString("00");
        _scoreLeFishe = LeFisheSys._counterfishe.ToString("00");
        StartCoroutine(Post(_name, _scoreBalloon, _scoreLeFishe));
    }

    IEnumerator Post(string _name, string _scoreBalloon, string _scoreLeFishe)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1173650026", _name);
        form.AddField("entry.503633397", _scoreBalloon);
        form.AddField("entry.415344785", _scoreLeFishe);
        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;
    }
}
