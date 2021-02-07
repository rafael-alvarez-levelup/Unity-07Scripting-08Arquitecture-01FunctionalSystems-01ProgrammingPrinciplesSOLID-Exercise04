using UnityEngine;

public class WeaponLaser : WeaponBase
{
    [SerializeField] private LaserBehaviour laserPrefab;

    public override void Fire(Transform firePoint)
    {
        LaserBehaviour laserBehaviour = Instantiate(laserPrefab, firePoint.position, firePoint.rotation);
        laserBehaviour.AddVelocityChangeForce(transform.up);
    }
}