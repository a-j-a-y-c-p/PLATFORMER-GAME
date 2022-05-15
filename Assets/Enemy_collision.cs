using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy_collision : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(WaitForSceneLoad());
            GetComponent<AudioSource>().Play();
        }
    }

    private IEnumerator WaitForSceneLoad() {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
