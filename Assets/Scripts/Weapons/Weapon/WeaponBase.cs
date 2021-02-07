using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    [SerializeField] private float fireRate;

    private float nextFireTime;

    public abstract void Fire(Transform firePoint);

    public virtual bool CanFire()
    {
        return Time.time >= nextFireTime;
    }

    public virtual void SetNextFireTime()
    {
        nextFireTime = Time.time + fireRate;
    }
}