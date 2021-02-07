using UnityEngine;

public class WeaponMissile : WeaponBase
{
    [SerializeField] private MissileController missilePrefab;

    public override void Fire(Transform firePoint)
    {
        MissileController missileController = Instantiate(missilePrefab, firePoint.position, firePoint.rotation);
        missileController.SearchAndDestroy();
    }
}