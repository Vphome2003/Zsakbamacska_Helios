using UnityEngine;

public class OutlineEnemy : MonoBehaviour
{
    private Outline outlineComponent;

    private void Start()
    {
        outlineComponent = GetComponent<Outline>();  //Kiemeles (korvonal hivatkozasa

        if (outlineComponent == null) //Ha nincs neki, adjon korvonalat
        {
            outlineComponent = gameObject.AddComponent<Outline>(); 
        }

        outlineComponent.enabled = true;  //Korvonal beallitasai
        outlineComponent.OutlineMode = Outline.Mode.OutlineAll;
        outlineComponent.OutlineColor = Color.red; 
        outlineComponent.OutlineWidth = 1f; 
    }
}
