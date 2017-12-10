using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseInfantryClass : UnitManager
{

	public BaseInfantryClass(){
		UnitNameValue = "Infantry";
        UnitDescriptionValue = "A minimum unit in battlefield, but they're most valuable class.";
        //参考：カッツァーゴのステータス
        HPValue = 24;
        FirePowerValue = 17;
        ActualValue = 56;
        ArmorValue = 7;
        AvoidanceValue = 53;
        AAValue = 0;
        ScoutValue = 36;

        FireRangeValue = 7; //280m
        MovementValue = 4; //1ターン（実時間の2分で160m）
        MoralValue = 100;
        FuelValue = 35;
        AmmoValue = 35;
	}

}
