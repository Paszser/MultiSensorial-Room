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
                GetComponent<Animator>().Play("PressState");
            }
            else
            {
                _parentBaldosa.GetComponent<BaldosasController>().SelectOtherBaldosa();
                gameObject.SetActive(false);
            }

            

        }
    }

    IEnumerator WinkBaldosa()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        yield return new WaitForSeconds(1.0f);
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }
}
