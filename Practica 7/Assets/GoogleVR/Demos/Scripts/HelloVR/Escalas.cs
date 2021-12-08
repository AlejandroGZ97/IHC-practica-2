namespace GoogleVR.HelloVR
{
    using UnityEngine.EventSystems;
    using UnityEngine;

    public class Escalas : ObjectController
    {
        [SerializeField] private GameObject modelo1;
        [SerializeField] private GameObject modelo2;
        [SerializeField] private GameObject modelo3;
        private int _selector = 1;
        private Vector3 _size;

        public override void Interact()
        {
            base.Interact();
            _size = new Vector3(Random.Range(0.5f,2f),Random.Range(0.5f,2f),Random.Range(0.5f,2f));
            if (modelo1.activeSelf)
            {
                modelo1.transform.localScale = _size;
            }
            else if (modelo2.activeSelf)
            {
                modelo2.transform.localScale = _size;
            }
            else
            {
                modelo3.transform.localScale = _size;
            }
            _timer = 0f;
        }
    }
}