// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a Virtual Machine Scale Set VM Reimage Parameters. </summary>
    public partial class VirtualMachineScaleSetVMReimageParameters : VirtualMachineReimageParameters
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMReimageParameters. </summary>
        public VirtualMachineScaleSetVMReimageParameters()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMReimageParameters. </summary>
        /// <param name="tempDisk"> Specifies whether to reimage temp disk. Default value: false. Note: This temp disk reimage parameter is only supported for VM/VMSS with Ephemeral OS disk. </param>
        internal VirtualMachineScaleSetVMReimageParameters(bool? tempDisk) : base(tempDisk)
        {
        }
    }
}