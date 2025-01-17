using System.Collections;
using TMPro;
using UnityEngine;

public class MapUX : MonoBehaviour
{
    [SerializeField] private Vector3 uiOffset = Vector3.zero;
    [SerializeField] private GameObject buildingUI;
    [SerializeField] private TextMeshProUGUI header;
    [SerializeField] private TextMeshProUGUI body;

    private GameObject buildingShown = null;
    private Coroutine followBuildingCoroutine = null;

    public void OnBuildingSelect(GameObject building)
    {
        if (building == buildingShown)
        {
            CloseInfo();
            return;
        }

        buildingUI.SetActive(true);
        buildingShown = building;
        header.text = building.name;
        body.text = "A building";

        if (followBuildingCoroutine == null)
        {
            followBuildingCoroutine = StartCoroutine("followBuilding");
        }
    }

    public void CloseInfo()
    {
        StopCoroutine(followBuildingCoroutine);
        followBuildingCoroutine = null;
        buildingShown = null;
        buildingUI.SetActive(false);
    }

    private IEnumerator followBuilding()
    {
        while (true)
        {
            yield return new WaitForEndOfFrame();
            buildingUI.transform.position = buildingShown.transform.position + uiOffset;
        }
    }
}
