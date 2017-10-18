using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playercontrol : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
    private int count;
    private float alltime=15;
    private float counttime;
    public Text Counttext;
    public Text Wintext;
    public GameObject clearpanel;
    public GameObject overpanel;
    public Text CountTime;
    public AudioSource Musicding;
    public AudioSource Warning;
    void Start()
		{
            count = 0;
            alltime = alltime + Time.time;
            rb = GetComponent<Rigidbody>();     
            SetCountText();
           // SetTimeText();
            Wintext.text = "";
           clearpanel.SetActive(false);
           overpanel.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }
    void FixedUpdate ()
		{
        
            SetTimeText();
        /*float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
    if (count >= 8||counttime==0)
        movement = new Vector3(0, 0, 0);
    rb.AddForce (movement*speed);*/
        Sportset();
		}
    void OnTriggerEnter(Collider other)
            {
                if(other.gameObject.CompareTag("pick"))
                    {

                         Musicding.Play();
                         other.gameObject.SetActive(false);
                         count += 1;
                         SetCountText();

                    }
            }
    void SetCountText()
    {
        
        Counttext.text ="Count:" + count.ToString();
        if (count >= 8)
            //Wintext.text = "You Win";
            clearpanel.SetActive(true);
            
           
    }
    void SetTimeText()
    {
        if (count < 8)
        {
            counttime = alltime - Time.time;
            if (counttime <= 0)
            {
                counttime = 0;
                overpanel.SetActive(true);
            }
            if (counttime > 5)
                Warning.Play();

            CountTime.text = "Time:" + counttime.ToString();
        }
    }
    void Sportset()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        if (count >= 8 || counttime == 0)
            movement = new Vector3(0, 0, 0);
        rb.AddForce(movement * speed);
    }

}


