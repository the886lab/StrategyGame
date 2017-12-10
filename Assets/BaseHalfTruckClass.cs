using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHalfTruckClass : UnitManager
{

	public BaseHalfTruckClass(){
        UnitNameValue = "Half Truck";
        UnitDescriptionValue = "Mechanized infantry have faster movement and thin armor!";
        //参考：フィーツェンのステータス
        HPValue = 36;
        FirePowerValue = 19;
        ActualValue = 53;
        ArmorValue = 16;
        AvoidanceValue = 45;
        AAValue = 5;
        ScoutValue = 24;

        FireRangeValue = 8; //320m
        MovementValue = 16;
        //1ターン（実時間の2分で640m）、最高時速だと40マスも移動してしまうが、
        //それはやりすぎなので
        MoralValue = 100;
        FuelValue = 44;
        AmmoValue = 44;
	}
}
