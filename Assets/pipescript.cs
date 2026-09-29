using System.Threading;
using UnityEngine;

public class pipescript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject pipe;
    public float spawnrate = 2;
    private float time = 0;
    public float highest = 10;
    void Start()
    {

        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(time<spawnrate)
        {
            time += Time.deltaTime;
        }
        else
        {
            spawnpipe();
            time = 0;
        }
        
    }
    void spawnpipe()
    {
        float highestpoint = transform.position.y - highest;
        float lowestpoint = transform.position.y + highest;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestpoint,highestpoint),0), transform.rotation);
    }
}
