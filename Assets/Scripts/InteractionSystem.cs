using UnityEngine;

namespace KID
{
    public class InteractionSystem : MonoBehaviour
    {
        [Header("�i���ʪ���ϼh"), SerializeField]
        private LayerMask layer;
        [Header("�`���I"), SerializeField]
        private Transform point;

        private void Update()
        {
            CheckObject();
        }

        private void CheckObject()
        {
            RaycastHit hit;
            if (Physics.Raycast(point.position, point.forward, out hit, 1000, layer))
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    hit.collider.GetComponent<InteractionObject>()?.CheckInteraction();
                }
            }
        }
    }
}
