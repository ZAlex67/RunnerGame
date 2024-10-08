using UnityEngine;

public class Barrier : MonoBehaviour
{
    [SerializeField] private BricksEffect _bricksEffectPrefab;

    private void OnTriggerEnter(Collider other)
    {
        PlayerModifier playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();

        if (playerModifier)
        {
            playerModifier.HitBarrier();
            Destroy(gameObject);
            Instantiate(_bricksEffectPrefab, transform.position, transform.rotation);
        }
    }
}
