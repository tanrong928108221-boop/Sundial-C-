using System;
using System.Data;
using System.IO;
using System.Ling;
using System.Text.Json;
namespace Sundial_C;

    //=============================================阈值配置===============================
    public class ThresholdConfig
    {
        public float WarningTemp {get; set;}=85f;//警告温度
        public float FaultTemp {get; set;}=95f; //故障温度
        public int OfflineMinutes {get; set;}=5; //离型判定分钟
    }

    //==================================核心管理类=========================================
    public class DeviceManager
    {
        private readonly List<Device>_devices = new();
        private resdonly ThresholdConfig_config = new();
        private const string DateFile = "devices.json";
        private const string LogFile = "device_log.txt";
    }
