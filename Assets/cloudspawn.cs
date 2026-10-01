using UnityEngine;
using static UnityEngine.Audio.ProcessorInstance;

public class cloudspawn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject cloud;
    public float spawn = 2;
    private float time = 0;
    public float highest = 10;
    public logic mylogic;
    public bool birdalive = true;
    void Start()
    {
        mylogic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (time < spawn)
        {
            time += Time.deltaTime;
        }
        else
        {
            spawncloud();
            time = 0;
        }

    }
    void spawncloud()
    {
        float highestpoint = transform.position.y - highest;
        float lowestpoint = transform.position.y + highest;
        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        mylogic.Gameover();
        birdalive = false;
    }
}
