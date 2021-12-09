using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public GameObject bumi;
    public GameObject tataSurya;
    public GameObject infoAplikasi;
    public Animator rotasiTataSurya;
    public Transform rotasiBumi;
    public int x;
    public bool rotasi = false;

    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        bumi.SetActive(true);
        tataSurya.SetActive(false);
        infoAplikasi.SetActive(false);
        rotasiTataSurya = tataSurya.GetComponent<Animator>();
        rotasiBumi = bumi.GetComponent<Transform>();
        audio.Stop();
    }

    public void earth()
    {
        bumi.SetActive(true);
        tataSurya.SetActive(false);
        infoAplikasi.SetActive(false);
        x = 0;
    }

    public void solsystem ()
    {
        tataSurya.SetActive(true);
        bumi.SetActive(false);
        infoAplikasi.SetActive(false);
    }

    public void animasiTataSurya()
    {
        rotasiTataSurya.Play("Scene", -1, 0f);
        rotasiTataSurya.speed = 1;
    }

    public void animasiBumi()
    {
        rotasi = true;
        x = 1;
    }

    public void displayinfoAplikasi()
    {
        infoAplikasi.SetActive(true);
        bumi.SetActive(false);
        tataSurya.SetActive(false);
    }

    public void closeInfoAplikasi()
    {
        infoAplikasi.SetActive(false);
    }

    public void playAudio()
    {
        audio.PlayOneShot(audio.clip);
    }

    void Update()
    {
        if(rotasiBumi){
            rotasiBumi.Rotate(0, 100 * Time.deltaTime * x, 0, Space.Self);
        }
    }
}
