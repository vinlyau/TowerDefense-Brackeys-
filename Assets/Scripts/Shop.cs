﻿using UnityEngine;

public class Shop : MonoBehaviour {

    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLauncher;
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret()
    {
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectMissileLauncher()
    {
        buildManager.SelectTurretToBuild(missileLauncher);
    }
}
