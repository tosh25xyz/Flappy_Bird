using UnityEngine;

public class pipemiddle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public logic mylogic;
    void Start()
    {
        mylogic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer==3)
        {
            mylogic.Addscore(1);
        }
        
    }
}
