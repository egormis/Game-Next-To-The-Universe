using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultRifle : MonoBehaviour
{
    public PlayerWeapon PWeapon;
    private float ammoMag;
    private float ammoTotal;
    private float ammoUse;
    private float damage;
    private float firingDelay;
    private float reloadTime;
    // Start calls the weapons stats
    void Start()
    {
        ammoMag = 30;
        ammoTotal = ammoMag * 6;
        ammoUse = 1;
        damage = 10;
        // Time it takes to fire another shot
        firingDelay = 0.05f;
        reloadTime = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        // When this weapons swap key is pressed, set all the variables in PlayerWeapon to equal the weapon stats
        // This is so that PlayerWeapon can handle ammo, reloading, shooting etc.
        if (Input.GetKeyDown(KeyCode.Alpha1) && PWeapon.currentWeapon != "Assault Rifle")
        {
            PWeapon.PlayerWeaponSwap("Assault Rifle");
            PWeapon.weaponAmmoMag = ammoMag;
            PWeapon.weaponAmmoCurrent = ammoMag;
            PWeapon.weaponAmmoTotal = ammoTotal;
            PWeapon.weaponAmmoUse = ammoUse;
            PWeapon.weaponDamage = damage;
            PWeapon.weaponFiringDelay = firingDelay;
            PWeapon.weaponReloadTime = reloadTime;
        }

        if (PWeapon.currentWeapon == "Assault Rifle")
        {
            ammoTotal = PWeapon.weaponAmmoTotal;
        }

    }
}
