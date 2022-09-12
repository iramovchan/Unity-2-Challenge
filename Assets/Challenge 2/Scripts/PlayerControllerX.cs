using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    float timer = 1;
    bool timerreached = false;

    // Update is called once per frame
    void Update()
    {
        // wait 1 second before you are able to create dog again
        if (!timerreached)
        {
            timer += Time.deltaTime;
        }

        if (timer > 1)
        {
            timerreached = true;
        }

        // On spacebar press, send dog
        if (timerreached)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timerreached = false;
                timer = 0;
            }
        }
    }
}
