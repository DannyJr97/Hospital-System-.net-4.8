using System;
using System.Management;
using System.Net.NetworkInformation;

namespace Hospital97.Activacao
{
    internal static class HardwareUtils
    {
        public static string GetHardwareID()
        {
            string cpuId = GetCpuId();
            string diskId = GetDiskSerial();
            string macAddress = GetMacAddress();

            return $"{cpuId}-{diskId}-{macAddress}";
        }

        private static string GetCpuId()
        {
            try
            {
                using (ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor"))
                {
                    foreach (ManagementObject mo in mos.Get())
                    {
                        return mo["ProcessorId"]?.ToString() ?? "CPU_NULL";
                    }
                }
            }
            catch
            {
                return "CPU_ERR";
            }

            return "CPU_NULL"; // Garantia de retorno mesmo se não entrar no foreach
        }


        private static string GetDiskSerial()
        {
            try
            {
                using (ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_PhysicalMedia"))
                {
                    foreach (ManagementObject mo in mos.Get())
                    {
                        string serial = mo["SerialNumber"]?.ToString()?.Trim();
                        if (!string.IsNullOrEmpty(serial))
                            return serial;
                    }
                }
            }
            catch
            {
                return "DISK_ERR";
            }

            return "DISK_NULL";
        }

        private static string GetMacAddress()
        {
            try
            {
                foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                    {
                        string mac = nic.GetPhysicalAddress().ToString();
                        if (!string.IsNullOrEmpty(mac))
                            return mac;
                    }
                }
            }
            catch
            {
                return "MAC_ERR";
            }

            return "MAC_NULL";
        }
    }
}
