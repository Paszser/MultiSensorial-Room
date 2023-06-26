using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeFisheSys : MonoBehaviour
{
    public float _positionX;
    public float _randomY;
    public const float _randomZ = 4.788996f;
    public float _fisheSpeed = Random.Range(0.003f, 0.008f);
    public static int _counterfishe;
    public Text _countertxt;
    // Start is called before the first frame update
    void Start()
    {
        _positionX = transform.position.x;
        _randomY = Random.Range(0.85f, 1.6f);
        gameObject.transform.position = new Vector3(_positionX, _randomY, _randomZ);

    }

    // Update is called once per frame
    void Update()
    {
        _countertxt.text = _counterfishe.ToString("00");
        transform.position = new Vector3 (transform.position.x + _fisheSpeed, transform.position.y, _randomZ);
        if(transform.position.x > _positionX + 3) 
        {
            GenerateFishe();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            GenerateFishe();
            _counterfishe++;
        }
    }

    private void GenerateFishe()
    {
        _randomY = Random.Range(0.85f, 1.6f);
        _fisheSpeed = Random.Range(0.003f, 0.008f);
        transform.position = new Vector3(_positionX, _randomY, _randomZ);
    }


}
