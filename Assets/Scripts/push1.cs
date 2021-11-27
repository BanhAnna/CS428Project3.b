using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class push1 : MonoBehaviour
{
    private Animation anim;
    public AudioSource jackpot;
    public AudioSource jackpot2;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        jackpot = gameObject.GetComponent<AudioSource>();
        jackpot2 = gameObject.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) /*|| Input.GetRightControllerInput.Button.ButtonOne(1)*/)
        {
            jackpot2.Play();
            jackpot.Play();
            anim.Play("pushed");
            Debug.Log("Button Pressed");
        }
    }
}
