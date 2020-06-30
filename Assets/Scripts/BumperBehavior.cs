using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperBehavior : MonoBehaviour
{

    public GameObject bumperPrefab;
    public int secondToWait;
    public GameObject instance;
    bool create = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine( BumperRespawn());
    }


    IEnumerator BumperRespawn()
    {
        yield return new WaitForSeconds(secondToWait);
        RespawnBumper();
    }

    public void RespawnBumper()
    {
        if (instance == null)
        {
            instance = Instantiate(bumperPrefab, this.transform.position,Quaternion.identity, this.transform);
            Debug.Log("Done");
            create = false;
        }
    }

    private void Update()
    {
        if (instance == null & create== false)
        {
            create = true;
            StartCoroutine(BumperRespawn());
        }
    }
}
