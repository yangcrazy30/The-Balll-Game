using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class level3playercontrol : MonoBehaviour {
    private float allthetime = 300;
    private float Counttimel3;
    public AudioSource cl3;
    public float speed;
    public GameObject p13;
    public GameObject p23;
    private Rigidbody rb;
    public Text Counttextl3;
    public Text Timermbl3;
    private int Countl3;
    public AudioSource warnl3;
    private float Xmovel3;
    private float Zmovel3;
    private Vector3 v;
    private float z;
    void Start () {
        Screen.SetResolution(Screen.width, Screen.height, true);
        Countl3 = 0;
        allthetime = allthetime + Time.time;
        rb = GetComponent<Rigidbody>();
        SetCountText3();
        p13.SetActive(false);
        p23.SetActive(false);
    }
    void FixedUpdate()
    {
        SetTimeText();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pick"))
        {

            cl3.Play();
            other.gameObject.SetActive(false);
            Countl3 += 1;
            SetCountText3();

        }
    }
    void SetCountText3()
    {

        Counttextl3.text = "Count:" + Countl3.ToString();
        if (Countl3 >= 9)
            p13.SetActive(true);
    }
    void SetTimeText()
    {
        if (Countl3 < 9)
        {
            Counttimel3 = allthetime - Time.time;
            if (Counttimel3 <= 0)
            {
                Counttimel3 = 0;
                p23.SetActive(true);
            }
            if (Counttimel3 > 5)
                warnl3.Play();
            Timermbl3.text = "Time:" + Counttimel3.ToString();
        }
    }
    void OnEnable()
    {
        EasyJoystick.On_JoystickMove += On_JoystickMove;
    }
    void OnDisable()
    {
        EasyJoystick.On_JoystickMove -= On_JoystickMove;
    }
    void On_JoystickMove(MovingJoystick move)
    {
        if (move.joystickName != "New joystick")
            return;
        Xmovel3 = move.joystickAxis.x;
        Zmovel3 = move.joystickAxis.y;
        Vector3 movement = new Vector3(Xmovel3, 0, Zmovel3);
        if (Countl3 == 9 || Counttimel3 <= 0)
            movement = new Vector3(0, 0, 0);
        rb.AddForce(movement * speed);
    }
    void Jump()
    {
        v = GetComponent<Rigidbody>().velocity;
        z = Mathf.Abs(v.y);
        if (z <= 0)
            rb.AddForce(0, 300, 0);
    }
}
