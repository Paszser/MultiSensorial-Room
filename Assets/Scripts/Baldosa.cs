using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baldosa : MonoBehaviour
{
    public GameObject _parentBaldosa;
    public int _baldosaValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            if (BaldosasController._game)
            {
                BaldosasController._colorBaldosas.Add(_baldosaValue); //se añade el valor de la baldosa al pisarla
            }
            else
            {
                _parentBaldosa.GetComponent<BaldosasController>().SelectOtherBaldosa();
                gameObject.SetActive(false);
            }
            
        }
    }
}
