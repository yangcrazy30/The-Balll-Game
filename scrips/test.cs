using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class test : MonoBehaviour
{
    private float allthetime=25;
    private float Counttime;
    public AudioSource ding;
    public float speed;
    public GameObject p1;
    public GameObject p2;
    private Rigidbody rb;
    public Text Counttext;
    public Text Timermb;
    private int Count;
    public AudioSource warn;
    // Use this for initialization
    void Start()
    {
        Count = 0;
        allthetime = allthetime + Time.time;
        rb = GetComponent<Rigidbody>();
        //speed = 3;
        SetCountText2();
        p1.SetActive(false);
        p2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }
    void FixedUpdate()
    {
        SetTimeText();
        Sportset();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pick"))
        {

            ding.Play();
            other.gameObject.SetActive(false);
            Count += 1;
            SetCountText2();

        }
    }
    void SetCountText2()
    {

        Counttext.text = "Count:" + Count.ToString();
        if (Count >= 9)
            //Wintext.text = "You Win";
            p1.SetActive(true);


    }
    void Sportset()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        if (Count == 9)
            movement = new Vector3(0, 0, 0);
        rb.AddForce(movement * speed);
    }
    void SetTimeText()
    {
        if (Count < 9)
        {
            Counttime = allthetime - Time.time;
            if (Counttime <= 0)
            {
                Counttime = 0;
                p2.SetActive(true);
            }
            if (Counttime > 5)
                warn.Play();
                Timermb.text = "Time:" + Counttime.ToString();
        }
    }
}