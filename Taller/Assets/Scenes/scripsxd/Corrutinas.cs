using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class Corrutinas : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] public float _time;
    [SerializeField] public int _cantidad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

     
        
            StartCoroutine(Spawn(2, 3f));
         
        
        
    }

    // Update is called once per frame
    void InstantineEsfera()
    {
        Instantiate(prefab, new Vector3(2, 2, 0), Quaternion.identity);
    }
     IEnumerator Spawn(int _cantidad, float _time)
    {

       
        InstantineEsfera();
        yield return new WaitForSeconds(5f);
        InstantineEsfera();
        yield return new WaitForSeconds(5f);
        InstantineEsfera();
        yield return new WaitForSeconds(5f);
    }
}
