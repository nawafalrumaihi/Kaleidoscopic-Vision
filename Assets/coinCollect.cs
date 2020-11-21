using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

    public class coinCollect : MonoBehaviour
    {
    public AudioClip coinSFX;
    private void OnCollisionEnter(Collision collision)

    {
        if (collision.collider.tag == "coin")
        {
            Destroy(collision.gameObject);
            AudioSource.PlayClipAtPoint(coinSFX,new Vector3(0,0,0));

        }
    }
}