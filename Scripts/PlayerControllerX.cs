using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    [SerializeField]
    private float cooldownTimer= 2.0f;
    private bool isCooldown= false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !isCooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            isCooldown= true;
            StartCoroutine("ResetCooldown");
        }
    }

    IEnumerator ResetCooldown()
    {
        yield return new WaitForSeconds(cooldownTimer);
        isCooldown= false;
    }
}
