using UnityEngine;

public class BallAudio : MonoBehaviour
{

    private AudioSource audioSource;
    private Rigidbody rb;
    public float maxSpeed = 2.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb != null && audioSource != null)
        {

            //gets speed
            float speed = rb.linearVelocity.magnitude;

            //scales volume
            float targetVolume = Mathf.Clamp01(speed / maxSpeed);
            audioSource.volume = targetVolume;

            //if moving at all slightly
            if (targetVolume > 0.01f)
            {//if not already playing
                if (!audioSource.isPlaying)
                {
                    audioSource.Play();
                }
            }
            else
            {
                if (audioSource.isPlaying)
                {
                    audioSource.Pause();

                }

            }
        }
    }

}