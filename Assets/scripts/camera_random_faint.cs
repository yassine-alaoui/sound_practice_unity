using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_random_faint : MonoBehaviour
{
    // Update is called once per frame
    public GameObject black_screen;

    void Update()
    {
        if (Random.Range(1, 10) >= 9 && !black_screen.activeSelf)
        {
            StartCoroutine(small_animation());
        }
    }

    IEnumerator small_animation()
    {
        black_screen.SetActive(true);
        for(int i = 0; i < 100; i++)
            yield return 0;
        black_screen.SetActive(false);
        //yield return 0;
        //black_screen.SetActive(true);
        //yield return 0;
        //black_screen.SetActive(false);
    }
}
