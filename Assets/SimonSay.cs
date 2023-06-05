using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSay : MonoBehaviour
{
    public static List<int> _order = new List<int>(4); 
    public List<GameObject> _colors;
    public float _intervalo;
    public BaldosasController _clearprevgame;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SimonStart()
    {
        _clearprevgame.ClearPreviousGame();

        for( int i = 0; i < 4; ++i)
        {
            _order.Add(Random.Range(0, 4)); // se genera una solución aleatoria
        }

        StartCoroutine(Sequence());

    }

   
    IEnumerator Sequence()
    {
        for (int i = 0; i < 4; ++i) //se muestra la sucesión de baldosas aleatoria
        {
            _colors[_order[i]].SetActive(true);
            yield return new WaitForSeconds(_intervalo);
            _colors[_order[i]].SetActive(false);
            yield return new WaitForSeconds(_intervalo/2);
        }

        _clearprevgame.ActivateAllTiles();
        BaldosasController._game = true;
    }
}
