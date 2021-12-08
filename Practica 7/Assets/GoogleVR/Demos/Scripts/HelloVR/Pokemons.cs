namespace GoogleVR.HelloVR
{
    using UnityEngine.EventSystems;
    using UnityEngine;

    public class Pokemons : ObjectController
    {
        [SerializeField] private GameObject modelo1;
        [SerializeField] private GameObject modelo2;
        [SerializeField] private GameObject modelo3;
        private int _selector = 1;

        public override void Interact()
        {
            base.Interact();
            if (_selector == 0)
            {
                modelo1.SetActive(true);
                modelo3.SetActive(false);
                _selector += 1;
            }
            else if (_selector == 1)
            {
                modelo1.SetActive(false);
                modelo2.SetActive(true);
                _selector += 1;
            }
            else
            {
                modelo2.SetActive(false);
                modelo3.SetActive(true);
                _selector = 0;
            }
            _timer = 0f;
        }
    }
}