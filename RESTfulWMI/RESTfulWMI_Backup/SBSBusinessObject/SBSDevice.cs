﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Instrumentation;
using System.Runtime.Serialization;
using System.Threading;

namespace SBSBusinessObject
{
    /*public enum DeviceType
    {
        ClientPC,
        Server,
        SecondServer
    }*/
    [ManagementEntity(Name = "SBS_Device", Singleton = false)]
    [DataContract]
    public class SBSDevice
    {
        private string deviceId;
        [ManagementKey]
        [DataMember]
        public string DeviceId
        {
            get { return deviceId; }
            set { deviceId = value; }
        }

        private string deviceName;
        [ManagementConfiguration(Mode = ManagementConfigurationType.OnCommit)]
        [DataMember]
        public string DeviceName
        {
            get { return deviceName; }
            set { deviceName = value; }
        }

        private string deviceType;
        [ManagementConfiguration(Mode = ManagementConfigurationType.OnCommit)]
        [DataMember]
        public string DeviceType
        {
            get { return deviceType; }
            set { deviceType = value; }
        }


        public SBSDevice(string DeviceName, string DeviceType)
        {
            this.deviceId = Guid.NewGuid().ToString();
            this.deviceName = DeviceName;
            this.deviceType = DeviceType;
        }

        [ManagementBind]
        public static SBSDevice GetInstance(string DeviceId)
        {
            foreach (SBSDevice d in MockRepository.sbsDevices)
            {
                if (string.Equals(d.DeviceId, DeviceId))
                {
                    return d;
                }
            }
            return null;
        }

        [ManagementCreate]
        public static SBSDevice CreateSBSDevice(string DeviceName, string DeviceType)
        {
            SBSDevice sbsDevice = new SBSDevice(DeviceName, DeviceType);
            MockRepository.sbsDevices.Add(sbsDevice);
            return sbsDevice;
        }

        [ManagementRemove]
        public void DeleteSBSDevice()
        {
            Logger.WriteLine("Delete the device with DeviceId: " + this.deviceId);
        }
        [ManagementCommit]
        public void Commitment()
        {
            Logger.WriteLine("Commitment: ");

        }
        [ManagementEnumerator]
        public static IEnumerable<SBSDevice> GetSBSDevices()
        {
            Logger.WriteLine("Hello Stupid: " + Thread.CurrentPrincipal.Identity.Name);
            foreach (SBSDevice device in MockRepository.sbsDevices)
            {
                yield return device;
            }
        }
    }
}
