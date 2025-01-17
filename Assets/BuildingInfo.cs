using UnityEngine;

[CreateAssetMenu(fileName = "BuildingInformation", menuName = "ScriptableObjects/BuildingInfo", order = 1)]
public class BuildingInfo : ScriptableObject
{
    public string Name;
    public string BuildDate;
    public string AdditionalInformation;
}
