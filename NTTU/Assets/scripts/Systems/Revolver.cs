using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolver : MonoBehaviour
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
        ammoMag = 6;
        ammoTotal = ammoMag*6;
        ammoUse = 1;
        damage = 20;
        // Time it takes to fire another shot
        firingDelay = 0.5f;
        reloadTime = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        // When this weapons swap key is pressed, set all the variables in PlayerWeapon to equal the weapon stats
        // This is so that PlayerWeapon can handle ammo, reloading, shooting etc.
        if (Input.GetKeyDown(KeyCode.Alpha2) && PWeapon.currentWeapon != "Revolver")
        {
            PWeapon.PlayerWeaponSwap("Revolver");
            PWeapon.weaponAmmoMag = ammoMag;
            PWeapon.weaponAmmoCurrent = ammoMag;
            PWeapon.weaponAmmoTotal = ammoTotal;
            PWeapon.weaponAmmoUse = ammoUse;
            PWeapon.weaponDamage = damage;
            PWeapon.weaponFiringDelay = firingDelay;
            PWeapon.weaponReloadTime = reloadTime;
        }

        if(PWeapon.currentWeapon == "Revolver")
        {
            ammoTotal = PWeapon.weaponAmmoTotal;
        }
        
    }
}
