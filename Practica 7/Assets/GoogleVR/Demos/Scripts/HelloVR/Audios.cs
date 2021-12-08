namespace GoogleVR.HelloVR
{
    using UnityEngine.EventSystems;
    using UnityEngine;

    public class Audios : ObjectController
    {
        private AudioSource audioSource;
        private int audioSelector = 0;
        public AudioClip [] clips;
        private Color color;

        void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }

        public override void Interact()
        {
            base.Interact();
            if (audioSource != null)
            {
                if (!audioSource.isPlaying)
                {
                    audioSource.clip = clips[audioSelector];
                    audioSource.Play();
                    _timer = 0f;
                    color = new Color(Random.value, Random.value, Random.value);
                    GetComponent<Renderer>().material.color = color;
                }
                else
                {
                    audioSource.Stop();
                    audioSelector += 1;
                    if(audioSelector > 2)
                        audioSelector = 0;
                }
            }
        }
    }
}