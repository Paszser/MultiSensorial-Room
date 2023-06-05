using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalloonSys : MonoBehaviour
{
    public int _randomX;
    public float _randomY;
    public const float _randomZ = 4.788996f;
    public static int _counter;
    public Text _countertxt;
    // Start is called before the first frame update
    void Start()
    {
        _randomX = Random.Range(-4, -1);
        _randomY = Random.Range(0.85f, 1.6f);
        gameObject.transform.position = new Vector3(_randomX, _randomY, _randomZ);

    }

    // Update is called once per frame
    void Update()
    {
        _countertxt.text = _counter.ToString("00");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 9)
        {
            GenerateBalloon();
            _counter++;
        }
    }

    private void GenerateBalloon()
    {
        _randomX = Random.Range(-4, -1);
        _randomY = Random.Range(0.85f, 1.6f);
        gameObject.transform.position = new Vector3(_randomX, _randomY, _randomZ);
    }
}
