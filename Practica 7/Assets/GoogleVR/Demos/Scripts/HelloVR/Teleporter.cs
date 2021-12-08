namespace GoogleVR.HelloVR
{
    using UnityEngine.EventSystems;
    using UnityEngine;

    public class Teleporter : ObjectController
    {

        public override void Interact()
        {
            base.Interact();
            Transform player = GameObject.FindWithTag("Player").transform;
            player.position = transform.position + new Vector3(0, 1.6f, 0);
        }
    }
}