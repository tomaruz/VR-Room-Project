using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
//using static UnityEditor.Experimental.GraphView.GraphView;

/// <summary>
/// Set the interaction layer of an interactor
/// </summary>
public class SetInteractionLayer : MonoBehaviour
{

    private XRBaseInteractor interactor = null;
    private InteractionLayerMask originalLayer;
    [Tooltip("The layer or layers that are switched to")]
    public InteractionLayerMask targetLayer = 0;


    private void Awake()
    {
        interactor = GetComponent<XRBaseInteractor>();
        originalLayer = interactor.interactionLayers;
    }

    public void ToggleTargetLayer()
    {
        if(interactor != null)
        {
            if (interactor.interactionLayers != originalLayer)
            {

                interactor.interactionLayers = originalLayer;
            }
            else
            {
                interactor.interactionLayers = targetLayer;
            }
        }

    }

}
