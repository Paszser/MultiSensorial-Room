using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaldosasController : MonoBehaviour
{
    public int _num;
    public List<GameObject> _baldosas;
    int _prevnum;

    // Start is called before the first frame update
    void Start()
    {
        _num = Random.Range(0, 3);
        _baldosas[_num].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelectOtherBaldosa()
    {
        
            _baldosas[0].SetActive(false);
            _baldosas[1].SetActive(false);
            _baldosas[2].SetActive(false);
            _baldosas[3].SetActive(false);
            _prevnum = _num;
            _num = Random.Range(0, 3);
            if(_prevnum == _num)
            {
                _num = (++_num) % _baldosas.Count;

            }
            _baldosas[_num].SetActive(true);
    }
}
