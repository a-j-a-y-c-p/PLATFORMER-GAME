using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScenes : MonoBehaviour
{
    public GameObject completeLevelUI;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            completeLevelUI.SetActive(true);
            GetComponent<AudioSource>().Play();
        }
    }
}
