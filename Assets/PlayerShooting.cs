using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public float range = 100f;
    public float timeBetweenBullets = 0.15f;

    float timer;
    Ray shootRay;
    RaycastHit shootHit;
    int shootableMask;
    ParticleSystem gunParticles;
    LineRenderer guneLine;
    //AudioSource gunAudio;
    Light gunLight;
    float effectsDisplayTime = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        shootableMask = LayerMask.GetMask("Shootable");
        gunParticles = GetComponent<ParticleSystem>();
        guneLine = GetComponent<LineRenderer>();
        gunLight = GetComponent<Light>();

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetButton("Fire1") && timer >= timeBetweenBullets && Time.timeScale != 0)
        {
            Shoot();
        }
        if (timer >= timeBetweenBullets * effectsDisplayTime)
        {
            DisableEffects();
        }

        

    }

    public void DisableEffects()
    {
        guneLine.enabled = false;
        gunLight.enabled = false;
    }

    void Shoot()
    {

        timer = 0f;

        

        gunLight.enabled = true;


        gunParticles.Stop();
        gunParticles.Play();
        guneLine.enabled = true;

        guneLine.SetPosition(0, transform.position);
        shootRay.origin = transform.position;
        shootRay.direction = transform.forward;

        if (Physics.Raycast(shootRay, out shootHit, range, shootableMask))
        {
            //EnemyHealth enemyHealth = shootHit.collider.GetComponent<EnemyHealth>();

            //if (enemyHealth != null)
            //{
            //    enemyHealth.TakeDamage(damagePerShot, shootHit.point);
            //}
            guneLine.SetPosition(1, shootHit.point);
        }
        else
        {
            guneLine.SetPosition(1, shootRay.origin + shootRay.direction * range);
        }

    }
}
