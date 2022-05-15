using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;
    public AudioClip soundFile;
    public AudioSource anon;
    private bool coltd = false;


    private void OnTriggerEnter2D(Collider2D other) {
        if(!coltd){
        // print(other);
        if(other.gameObject.CompareTag("Player")){
            anon.PlayOneShot(soundFile);
            Destroy(gameObject);
            ScoreManager.instance.ChangeScore(coinValue);
        }
        }
    }
}
