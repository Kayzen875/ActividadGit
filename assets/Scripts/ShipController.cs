using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    private ShootingSystem launcher;

    public Transform[] shootPoint;

    private void Awake()
    {
        InputSystemKeyboard sk;
        if (TryGetComponent<InputSystemKeyboard>(out sk))
        {
            sk.OnFire += Shoot;
        }
    }

    private void Start()
    {
        launcher = GetComponent<ShootingSystem>();

        ShootingSystemData sh = Resources.Load<ShootingSystemData>("ShootData");
        ShootSystem b = gameObject.AddComponent<ShootSystem>();
        b.shootingdata = sh;
        b.shootPoint = shootPoint[0];
        launcher = b;
    }
    void Shoot()
    {
        launcher.Shoot();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            ShootingSystemData sh = Resources.Load<ShootingSystemData>("ShootData");
            Destroy(gameObject.GetComponent<ShootingSystem>());
            ShootSystem b = gameObject.AddComponent<ShootSystem>();
            b.shootingdata = sh;
            b.shootPoint = shootPoint[0];
            launcher = b;
            
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            ShootingSystemData sh = Resources.Load<ShootingSystemData>("MissileData");
            Destroy(gameObject.GetComponent<ShootingSystem>());
            MissileSystem v = gameObject.AddComponent<MissileSystem>();
            v.shootingdata = sh;
            v.shootPoint = shootPoint[0];
            launcher = v;
            
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {

            ShootingSystemData sh = Resources.Load<ShootingSystemData>("ExpansiveData");
            Destroy(gameObject.GetComponent<ShootingSystem>());
            ShieldSystem s = gameObject.AddComponent<ShieldSystem>();
            s.shootingdata = sh;
            s.shootPoint = shootPoint[1];
            launcher = s;
            
        }
    }

    public void missileUP()
    {
        ShootingSystemData sh = Resources.Load<ShootingSystemData>("MissileData");
        Destroy(gameObject.GetComponent<ShootingSystem>());
        MissileSystem v = gameObject.AddComponent<MissileSystem>();
        v.shootingdata = sh;
        v.shootPoint = shootPoint[0];
        launcher = v;
    }

    public void shootUP()
    {
        ShootingSystemData sh = Resources.Load<ShootingSystemData>("ShootData");
        Destroy(gameObject.GetComponent<ShootingSystem>());
        ShootSystem b = gameObject.AddComponent<ShootSystem>();
        b.shootingdata = sh;
        b.shootPoint = shootPoint[0];
        launcher = b;
    }

    public void expansiveUP()
    {
        ShootingSystemData sh = Resources.Load<ShootingSystemData>("ExpansiveData");
        Destroy(gameObject.GetComponent<ShootingSystem>());
        ShieldSystem s = gameObject.AddComponent<ShieldSystem>();
        s.shootingdata = sh;
        s.shootPoint = shootPoint[1];
        launcher = s;
    }
}
