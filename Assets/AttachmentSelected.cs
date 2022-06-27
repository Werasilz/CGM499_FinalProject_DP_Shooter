using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachmentSelected : MonoBehaviour
{
    public WeaponAttachment[] attachment;
    public assault57 assault57;

    public void AttachSlotMain(int index)
    {
        assault57.mainAttachment = attachment[index - 1];
        assault57.Decorate();
    }

    public void AttachSlotSecond(int index)
    {
        assault57.secondaryAttachment = attachment[index - 1];
        assault57.Decorate();
    }


}
