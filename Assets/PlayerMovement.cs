using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1.0f;
    private CharacterController characterController;

    // Use the XROrigin component instead of XRRig
    [SerializeField] private XROrigin xrRig;

    // Use the XRRig component instead of XRNode
    [SerializeField] private XRNode inputSource;

    private Vector2 inputAxis;

    private void Start()
    {

        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);

        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);

        Vector3 movement = new Vector3(inputAxis.x, 0, inputAxis.y);

        // Rotate movement vector to be relative to the XR rig's forward direction
        movement = xrRig.transform.TransformDirection(movement);
        movement.y = 0;

        characterController.Move(movement * moveSpeed * Time.deltaTime);
    }
}
