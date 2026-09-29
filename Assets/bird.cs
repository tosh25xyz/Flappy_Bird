using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class bird : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D hisRigidbody;
    public float flapstrength;
    public logic mylogic;
    public bool birdalive = true;
    void Start()
    {
        gameObject.name="FLAPPY BIRD PROJECT";
        mylogic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdalive)
        {
            hisRigidbody.linearVelocity = Vector2.up * flapstrength;
        }
        Vector3 screenPosition = Camera.main.WorldToViewportPoint(transform.position);

        if (screenPosition.y > 1f || screenPosition.y < 0f)
        {
            mylogic.Gameover();
            birdalive = false;
        }

    }
    private void  OnCollisionEnter2D(Collision2D collision)
    {
        mylogic.Gameover();
        birdalive = false;
    }
}
