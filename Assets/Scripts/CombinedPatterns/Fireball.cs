using UnityEngine;

namespace Combined
{
    public class Fireball : MonoBehaviour, IProjectile
    {
        [SerializeField] private GameEvent _gameEvent;

        public void OnHit()
        {
            _gameEvent.Raise();
            Destroy(gameObject);
        }

        public void Shoot()
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * 10f, ForceMode.Impulse);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Wall"))
                OnHit();
        }
    }
}
