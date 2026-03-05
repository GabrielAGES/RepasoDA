using System.Collections;
using UnityEngine;

public class Corrutina : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Spawn(2, 5f));

    }

    void InsatantiteEsfera()
    {
        Instantiate(prefab, new Vector3(2, 2, 0), Quaternion.identity);
    }
    IEnumerator Spawn(int tiempo, float cantidad)
    {
        InsatantiteEsfera();
        yield return new WaitForSeconds(5f);
        InsatantiteEsfera();
        yield return new WaitForSeconds(5f);
        InsatantiteEsfera();
        yield return new WaitForSeconds(5f);
    }
}
